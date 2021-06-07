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
    public partial class emp_page : Form
    {
        public static string conn = "Data Source=localhost;Initial Catalog=gestion_conge;Integrated Security=True";
        public SqlConnection cone = new SqlConnection(conn);
        public SqlDataReader sdr;
        public emp_page()
        {
            InitializeComponent();
        }

        public static int solde;
        private void emp_page_Load(object sender, EventArgs e)
        {
            cone.Open();
            string cmd = "select solde from employeee where loginn ='" + Login.login + "'";
            SqlCommand comm = new SqlCommand(cmd, cone);
            sdr = comm.ExecuteReader();
            sdr.Read();
            solde = Convert.ToInt32(sdr[0]);
            date_debut.Value = DateTime.Today;
            date_fin.Value = DateTime.Today.AddDays(1);
            date_retour.Value = DateTime.Today.AddDays(2);
            now.Value = DateTime.Now;
        }
        private void Consulter_solde_Click(object sender, EventArgs e)
        {
            if (cone.State == ConnectionState.Open)
                cone.Close();
            try
            {
                this.solde_text.Text = solde.ToString()+" jours";
                solde_text.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public double a;
        public double b;
        private void Demander_Click(object sender, EventArgs e)
        {
            if (cone.State == ConnectionState.Open)
                cone.Close();

            try
            {
                
               
                b = (date_debut.Value - now.Value).TotalDays;
                if (date_fin.Value > date_retour.Value)
                {
                    MessageBox.Show("Date de retour ne peut pas etre inferieur a la Date de fin");
                    return;
                }

                else if(a<0)
                {
                    MessageBox.Show("Date de fin ne peut pas etre inferieur a la date de debut !!");
                    return;
                }
                else if(a>solde)
                {
                    MessageBox.Show("Vous n'avez pass assez de solde");
                    return;
                }
                 else if (b <0 )
                {
                    MessageBox.Show("Vous pouvez pas demander un congé pour aujourd'hui");
                    return;
                }
                 
                   
                    cone.Open();
                    string com_insert = " insert into conge(login_emp,date_debut,date_fin,nbr_de_jour,date_retour,typee) values ( '" + Login.login + "', '" + date_debut.Value + "','" + date_fin.Value + "',"+Convert.ToInt32(a)+",'" + date_retour.Value + "','Annuel')";
                    SqlCommand command = new SqlCommand(com_insert, cone);
                    command.ExecuteNonQuery();
                    cone.Close();
       
                    cone.Open();
                    string com_update_solde = "update employeee set solde = solde -"+Convert.ToInt32(a)+" where loginn = '" + Login.login + "'";
                    SqlCommand command_up_2 = new SqlCommand(com_update_solde, cone);
                    command_up_2.ExecuteNonQuery();
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

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void date_retour_ValueChanged(object sender, EventArgs e)
        {
            a = (date_fin.Value - date_debut.Value).TotalDays;

            this.nombre_des_jours.Text = a.ToString();
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
