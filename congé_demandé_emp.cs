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
    public partial class congé_demandé_emp : Form
    {
        public static string conn = ServerName.conn;
        public SqlConnection cone = new SqlConnection(conn);
        public SqlDataReader sdr;
        public congé_demandé_emp()
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

                string select = "select date_debut,date_fin,nbr_de_jour,date_retour,typee from conge where login_emp='"+Login.login+"'and demandé = 1";

                SqlCommand command = new SqlCommand(select, cone);

                SqlDataReader rd = command.ExecuteReader();

                while (rd.Read())

                {

                    deets_table.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4]);

                }

                rd.Close();

                cone.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);


            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void congé_demandé_emp_Load(object sender, EventArgs e)
        {
            deets_table.Columns["date_debut"].ValueType = typeof(DateTime);
            deets_table.Columns["date_fin"].ValueType = typeof(DateTime);
            deets_table.Columns["date_retour"].ValueType = typeof(DateTime);
        }

        private void congé_demandé_emp_Activated(object sender, EventArgs e)
        {
            deets_table.Rows.Clear();
            MajData();

        }
    }
}
