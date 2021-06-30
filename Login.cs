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
    public partial class Login : Form
    {
        public static string conn = ServerName.conn;
        public SqlConnection cone = new SqlConnection(conn);
        public SqlDataReader sdr;
        public static string login;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            mdp_text.PasswordChar = '*';
        }

        private void create_new_button_Click(object sender, EventArgs e)
        {
            Create_new c = new Create_new();
            c.Show();
        }

        private void afficher_mdp_CheckedChanged(object sender, EventArgs e)
        {
            if (afficher_mdp.Checked == true)
            {
                mdp_text.PasswordChar = '\0';
            }
            else
            {
                mdp_text.PasswordChar = '*';
            }
        }

        private void login_butt_Click(object sender, EventArgs e)
        {
            if (cone.State == ConnectionState.Open)
                cone.Close();
            try
            {
                cone.Open();
                string cmd = string.Format("select loginn,passe from employeee where loginn = '{0}' and passe = '{1}'", login_text.Text,mdp_text.Text);
                SqlCommand comm = new SqlCommand(cmd, cone);
                sdr = comm.ExecuteReader();
                sdr.Read();
                if (login_text.Text == "admin" && mdp_text.Text == "admin")
                {
                    Admin a1 = new Admin();
                    this.Hide();
                    a1.Show();

                }

                else if(login_text.Text == sdr[0].ToString() && mdp_text.Text == sdr[1].ToString())
                    {
                        Login.login = login_text.Text;
                        type_dialog et = new type_dialog();
                        et.Show();
                        this.Hide();
                    }
      
                   
                cone.Close();
                //string.Format("select loginn,passe from employeee where loginn = '{0}' and passe = '{1}'", login_text.Text, mdp_text.Text)string.Format("select loginn,passe from employeee where loginn = '{0}' and passe = '{1}'", login_text.Text,mdp_text.Text)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void mdp_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_butt_Click(this, new EventArgs());
            }
        }
        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.Down)
            {
                Change_server FFRM = new Change_server();
                FFRM.ShowDialog();
            }
        }
    }
}
