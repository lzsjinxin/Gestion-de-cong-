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
    public partial class emp_maladie : Form
    {
        public static string conn = "Data Source=localhost;Initial Catalog=gestion_conge;Integrated Security=True";
        public SqlConnection cone = new SqlConnection(conn);
        public SqlDataReader sdr;
        public emp_maladie()
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
        private void Demander_Click(object sender, EventArgs e)
        {
            if (cone.State == ConnectionState.Open)
                cone.Close();

            try
            {
                a = (date_fin.Value - date_debut.Value).TotalDays;
                if (date_fin.Value > date_retour.Value)
                {
                    MessageBox.Show("Date de retour ne peut pas etre inferieur a la Date de fin");
                    return;
                }
                else if (a < 0)
                {
                    MessageBox.Show("Date de fin ne peut pas etre inferieur a la date de debut !!");
                    return;
                }

                cone.Open();
                string com_insert = " insert into conge_accepté(login_emp,date_debut,date_fin,nbr_de_jour,date_retour,typee) values ( '" + Login.login + "', '" + date_debut.Value + "','" + date_fin.Value + "'," + Convert.ToInt32(a) + ",'" + date_retour.Value + "','Maladie')";
                SqlCommand command = new SqlCommand(com_insert, cone);
                command.ExecuteNonQuery();
                cone.Close();
                cone.Open();
                string com_update_en_conge = "update employeee set en_congé = 1 where loginn = '" + Login.login + "'";
                SqlCommand command_up_1 = new SqlCommand(com_update_en_conge, cone);
                command_up_1.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Congé Pris!!");
                Login l2 = new Login();
                this.Hide();
                l2.Show();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void date_retour_ValueChanged(object sender, EventArgs e)
        {
            a = (date_fin.Value - date_debut.Value).TotalDays;

            this.nombre_des_jours.Text = a.ToString();
        }

        private void emp_maladie_Load(object sender, EventArgs e)
        {
            date_debut.Value = DateTime.Today;
            date_fin.Value = DateTime.Today.AddDays(1);
            date_retour.Value = DateTime.Today.AddDays(2);
        }

        private void date_fin_ValueChanged(object sender, EventArgs e)
        {
            a = (date_fin.Value - date_debut.Value).TotalDays;

            this.nombre_des_jours.Text = a.ToString();
        }

        private void date_debut_ValueChanged(object sender, EventArgs e)
        {
            a = (date_fin.Value - date_debut.Value).TotalDays;

            this.nombre_des_jours.Text = a.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            type_dialog t2 = new type_dialog();
            this.Hide();
            t2.Show();
        }
    }
}
