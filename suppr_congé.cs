using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_de_congé
{
    public partial class suppr_congé : Form
    {

        public static string conn = ServerName.conn;
        public SqlConnection cone = new SqlConnection(conn);
        public SqlDataReader sdr;
        public suppr_congé()
        {
            InitializeComponent();
        }

        public void MajData()
        {

            try

            {
                if (cone.State == ConnectionState.Open)
                    cone.Close();

                cone.Open();

                string select = "select * from conge_accepté order by id_accepté  ";

                SqlCommand command = new SqlCommand(select, cone);

                SqlDataReader rd = command.ExecuteReader();

                while (rd.Read())

                {

                    deets_table.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6]);

                }

                rd.Close();

                cone.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);


            }
        }
        private void supprimer_Click(object sender, EventArgs e)
        {
            if (ConnectionState.Open == cone.State)
            {
                cone.Close();
            }
            try
            {
                DialogResult result1 = MessageBox.Show("Voullez-vous vraiment Supprimer?",
                "Quitter",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result1 == DialogResult.Yes)
                {


                    cone.Open();
                    string sqlCom = "DELETE FROM conge_accepté WHERE login_emp = '" + login_text.Text + "' and typee = '"+type_text.Text+"'";
                    SqlCommand command = new SqlCommand(sqlCom, cone);
                    command.ExecuteNonQuery();
                    cone.Close();
                    cone.Open();
                    string com_update_enn_conge = "update employeee set en_congé = 0 where loginn = '" + login_text.Text + "'";
                    SqlCommand command_upp_1 = new SqlCommand(com_update_enn_conge, cone);
                    command_upp_1.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Suppression Bien fait");
                    supprimer.Enabled = false;
                    this.Close();
                }
                else
                {
                    return;
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
        }

        private void suppr_congé_Load(object sender, EventArgs e)
        {
            deets_table.Columns["date_debut"].ValueType = typeof(DateTime);
            deets_table.Columns["date_fin"].ValueType = typeof(DateTime);
            deets_table.Columns["date_retour"].ValueType = typeof(DateTime);
            supprimer.Enabled = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void suppr_congé_Activated(object sender, EventArgs e)
        {
            deets_table.Rows.Clear();
            MajData();
        }

        private void deets_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.deets_table.Rows[e.RowIndex];

                    login_text.Text = row.Cells[1].Value.ToString();
                    date_debut_text.Text = row.Cells[2].Value.ToString();
                    date_fin_text.Text = row.Cells[3].Value.ToString();
                    nbr_jour_text.Text = row.Cells[4].Value.ToString();
                    date_retour_text.Text = row.Cells[5].Value.ToString();
                    type_text.Text = row.Cells[6].Value.ToString();
                    supprimer.Enabled = true;
                   
                }
            }
            catch (Exception)
            {
                login_text.Text = "";
                date_debut_text.Text = "";
                date_fin_text.Text = "";
                nbr_jour_text.Text = "";
                date_retour_text.Text = "";
                type_text.Text = "";
                supprimer.Enabled = false;
                
            }
        }
    }
}
