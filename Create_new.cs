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
    public partial class Create_new : Form
    {
        public static string conn = ServerName.conn;
        public SqlConnection cone = new SqlConnection(conn);
        public SqlDataReader sdr;
        public Create_new()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void creer_mdp_button_Click(object sender, EventArgs e)
        {
            if (cone.State == ConnectionState.Open)
                cone.Close();
            try
            {
                if (mdp_create.Text.Length <8)
                {
                    MessageBox.Show("un mot de passe doit etre au moins 8 charactéres");
                    return;
                }
                if (mdp_create.Text != conf_mdp_create.Text)
                {
                    MessageBox.Show("Les mdps sont pas identiques");
                    return;
                }
                else if (Login_create.Text == "" || nom_create.Text == "" || prenom_create.Text == "" || mdp_create.Text == "" || conf_mdp_create.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                    return;
                }
                else
                {
                    cone.Open();
                    string com = " insert into employeee(loginn,nom,prenom,passe) values ( '"+ Login_create.Text + "', '" + nom_create.Text + "','" + prenom_create.Text + "','" + mdp_create.Text + "')";
                    SqlCommand command = new SqlCommand(com, cone);
                    command.ExecuteNonQuery();
                    cone.Close();
                    MessageBox.Show("Ajout bien fait!!");
                    Login_create.Text = "";
                    nom_create.Text = "";
                    prenom_create.Text = "";
                    mdp_create.Text = "";
                    conf_mdp_create.Text = "";
                    this.Hide();
                    


                }
            }
            catch (Exception Ex)
            {
                //if(Ex.ErrorCode == -2146232060)
                //{
                //    MessageBox.Show("Ce login existe deja !!");
                //    return;
                //}
               MessageBox.Show(Ex.Message);
                return;
            }
        }

        private void conf_mdp_create_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                creer_mdp_button_Click(this, new EventArgs());
            }
        }

    }
}
