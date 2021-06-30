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
    public partial class conge_deets : Form
    {
        public static string conn = ServerName.conn;
        public SqlConnection cone = new SqlConnection(conn);
        public SqlDataReader sdr;

        public void MajData()
        {

            try

            {
                if (cone.State == ConnectionState.Open)
                    cone.Close();

                cone.Open();

                string select = "select * from conge_accepté order by id_accepté ";

                SqlCommand command = new SqlCommand(select, cone);

                SqlDataReader rd = command.ExecuteReader();

                while (rd.Read())

                {

                    deets_table.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6]);

                }

                rd.Close();

                cone.Close();

            }

            catch (Exception Ex)

            {

                MessageBox.Show(Ex.Message);


            }
        }
            public conge_deets()
            {
                InitializeComponent();
            }

            private void guna2Button1_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void conge_deets_Activated(object sender, EventArgs e)
            {

            
            deets_table.Rows.Clear();
            MajData();
            }

        private void conge_deets_Load(object sender, EventArgs e)
        {
            deets_table.Columns["date_debut"].ValueType = typeof(DateTime);
            deets_table.Columns["date_fin"].ValueType = typeof(DateTime);
            deets_table.Columns["date_retour"].ValueType = typeof(DateTime);
        }
    }
}
