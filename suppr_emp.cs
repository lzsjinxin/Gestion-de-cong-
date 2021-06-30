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
    public partial class suppr_emp : Form
    {

        public static string conn = ServerName.conn;
        public SqlConnection cone = new SqlConnection(conn);
        public SqlDataReader sdr;
        public suppr_emp()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void par_login_check_CheckedChanged(object sender, EventArgs e)
        {
            if (par_login_check.Checked == true)
            {
                par_login.Enabled = true;
                par_id.Enabled = false;
                par_id_check.Checked = false;
            }
            else if (par_login_check.Checked == false)
            {
                if (par_login_check.Checked == false && par_id_check.Checked == false)
                {
                    par_login.Enabled = false;
                    par_id.Enabled = false;
                }
                else
                {
                    par_login.Enabled = false;
                }
                   
            }

        }

        private void par_id_check_CheckedChanged(object sender, EventArgs e)
        {
            if (par_id_check.Checked == true)
            {
                par_id.Enabled = true;
                par_login.Enabled = false;
                par_login_check.Checked = false;
            }
            else if (par_id_check.Checked == false)
            {
                if (par_login_check.Checked == false && par_id_check.Checked == false)
                {
                    par_id.Enabled = false;
                    par_login.Enabled = false;
                }
                else
                    par_id.Enabled = false;


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

                    if (par_login.Text == "" && par_id.Text =="")
                    {
                        MessageBox.Show("Veuillez Remplir avant de supprimer");
                        return;
                    }
                    if (par_login_check.Checked == true)
                    {

                        cone.Open();
                        string sqlCom = "DELETE FROM employeee WHERE loginn = '" + par_login.Text + "'";
                        SqlCommand command = new SqlCommand(sqlCom, cone);
                        command.ExecuteNonQuery();
                        cone.Close();
                    
                        MessageBox.Show("Suppression Bien fait");
                        this.Close();
                    }
                    else if (par_id_check.Checked == true)
                    {
                        cone.Open();
                        string sqlCom = "DELETE FROM employeee WHERE id = " + Convert.ToInt32(par_id.Text) ;
                        SqlCommand command = new SqlCommand(sqlCom, cone);
                        command.ExecuteNonQuery();
                        cone.Close();
                       

                        MessageBox.Show("Suppression Bien fait");
                        this.Close();
                    }
                }
                else
                {
                    return;
                }


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void suppr_emp_Load(object sender, EventArgs e)
        {
            par_id_check.Checked = false;
            par_login_check.Checked = false;
            if(par_login_check.Checked ==false && par_id_check.Checked == false)
            {
                par_id.Enabled = false;
                par_login.Enabled = false;
            }
        }
    }
}
