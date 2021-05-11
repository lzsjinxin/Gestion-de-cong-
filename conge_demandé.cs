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
    public partial class conge_demandé : Form
    {
        public static string conn = "Data Source=localhost;Initial Catalog=gestion_conge;Integrated Security=True";
        public SqlConnection cone = new SqlConnection(conn);
        public SqlDataReader sdr;
        public conge_demandé()
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

                string select = "select id_en_conge,login_emp,nom,prenom,date_debut,date_fin,nbr_de_jour,date_retour,typee from employeee e, conge c where loginn=login_emp and demandé = 1 order by id_en_conge ";

                SqlCommand command = new SqlCommand(select, cone);

                SqlDataReader rd = command.ExecuteReader();

                while (rd.Read())

                {

                    deets_table.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6], rd[7], rd[8]);

                }

                rd.Close();

                cone.Close();

            }

            catch (Exception ex)

            {

               MessageBox.Show(ex.Message);


            }
        }
        private void conge_demandé_Load(object sender, EventArgs e)
        {
            accepter.Enabled = false;
            refuser.Enabled = false;
            deets_table.Columns["date_debut"].ValueType = typeof(DateTime);
            deets_table.Columns["date_fin"].ValueType = typeof(DateTime);
            deets_table.Columns["date_retour"].ValueType = typeof(DateTime);
        }

        private void conge_demandé_Activated(object sender, EventArgs e)
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
                    date_debut_text.Text = row.Cells[4].Value.ToString();
                    date_fin_text.Text = row.Cells[5].Value.ToString();
                    nbr_jour_text.Text = row.Cells[6].Value.ToString();
                    date_retour_text.Text = row.Cells[7].Value.ToString();
                    type_text.Text = row.Cells[8].Value.ToString();
                    accepter.Enabled = true;
                    refuser.Enabled = true;
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
                accepter.Enabled = false;
                refuser.Enabled = false;
            }
        }

        private void accepter_Click(object sender, EventArgs e)
        {
            if(cone.State == ConnectionState.Open)
            {
                cone.Close();
            }
            try
            {
                cone.Open();
                string com_update_en_conge = "update conge set accepté = 1 , demandé = 0 where login_emp = '" + login_text.Text + "' and typee = '"+type_text.Text+"'";
                SqlCommand command_up_1 = new SqlCommand(com_update_en_conge, cone);
                command_up_1.ExecuteNonQuery();
                cone.Close();
                cone.Open();
                string com_insert_accepted = "insert into conge_accepté(login_emp,date_debut,date_fin,nbr_de_jour,date_retour,typee) values ('" + login_text.Text + "','" + date_debut_text.Text + "','" + date_fin_text.Text + "'," + Convert.ToInt32(nbr_jour_text.Text) + ",'" + date_retour_text.Text + "','" + type_text.Text + "')";
                SqlCommand command_ins_acc = new SqlCommand(com_insert_accepted, cone);
                command_ins_acc.ExecuteNonQuery();
                cone.Close();
                cone.Open();
                string com_update_enn_conge = "update employeee set en_congé = 1 where loginn = '" + Login.login + "'";
                SqlCommand command_upp_1 = new SqlCommand(com_update_enn_conge, cone);
                command_upp_1.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Ok");
                type_text.Text = "";
                login_text.Text = "";
                deets_table.ClearSelection();
                accepter.Enabled = false;
                refuser.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void refuser_Click(object sender, EventArgs e)
        {
            if (cone.State == ConnectionState.Open)
            {
                cone.Close();
            }
            try
                
            {
                cone.Open();
                string com_insert_refused = "insert into conge_refusé(login_emp,date_debut,date_fin,nbr_de_jour,date_retour,typee) values ('" + login_text.Text + "','" + date_debut_text.Text + "','" + date_fin_text.Text + "'," + Convert.ToInt32(nbr_jour_text.Text) + ",'" + date_retour_text.Text + "','" + type_text.Text + "')";
                SqlCommand command_ins_ref = new SqlCommand(com_insert_refused, cone);
                command_ins_ref.ExecuteNonQuery();
                cone.Close();
                cone.Open();
                string com_update_en_conge = "update conge set demandé = 0 , accepté = 0 where login_emp = '" + login_text.Text + "'";
                SqlCommand command_up_1 = new SqlCommand(com_update_en_conge, cone);
                command_up_1.ExecuteNonQuery();
                cone.Close();
                cone.Open();
                string com_update_en_cc = "delete from conge where login_emp = '" + login_text.Text + "' and demandé = 0 and accepté = 0";
                SqlCommand command_up_2 = new SqlCommand(com_update_en_cc, cone);
                command_up_2.ExecuteNonQuery();
                cone.Close();

                MessageBox.Show("Ok");
                type_text.Text = "";
                login_text.Text = "";
                deets_table.ClearSelection();
                accepter.Enabled = false;
                refuser.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}