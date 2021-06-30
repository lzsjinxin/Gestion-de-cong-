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
    public partial class emp_maternité : Form
    {
        public static string conn = ServerName.conn;
        public SqlConnection cone = new SqlConnection(conn);
        public SqlDataReader sdr;
        public emp_maternité()
        {
            InitializeComponent();
        }

        private void leaave_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Voullez vous quitter?",
       "Quitter",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Voullez vous vraiment se deconnecter?",
      "Quitter",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                Login l2 = new Login();
                this.Hide();
                l2.Show();
            }
            else
            {
                return;
            }
        }
        public double a;
        private void emp_maternité_Load(object sender, EventArgs e)
        {
            date_debut.Value = DateTime.Today;
        }

        private void Demander_Click(object sender, EventArgs e)
        {
            if (cone.State == ConnectionState.Open)
                cone.Close();

            try
            {
                a = (DateTime.Now - date_debut.Value).TotalDays;
                var b = date_debut.Value.AddMonths(-2);
                var c = date_debut.Value.AddMonths(2);
                
                cone.Open();
                string com_insert = " insert into conge_accepté(login_emp,date_debut,date_fin,nbr_de_jour,date_retour,typee) values ( '" + Login.login + "', '" + b.ToString() + "','" + c.ToString() + "',121,'" + c.AddDays(1).ToString() + "','Maternité')";
                SqlCommand command = new SqlCommand(com_insert, cone);
                command.ExecuteNonQuery();
                cone.Close();
                cone.Open();
                string com_update_en_conge = "update employeee set en_congé = 1 where loginn = '" + Login.login + "'";
                SqlCommand command_up_1 = new SqlCommand(com_update_en_conge, cone);
                command_up_1.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Congé demandé!!");
                Login l2 = new Login();
                this.Hide();
                l2.Show();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            type_dialog t2 = new type_dialog();
            this.Hide();
            t2.Show();
        }
    }
}
