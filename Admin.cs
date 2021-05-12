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
    public partial class Admin : Form
    {
        public static string conn = "Data Source=localhost;Initial Catalog=gestion_conge;Integrated Security=True";
        public SqlConnection cone = new SqlConnection(conn);
        public SqlDataReader sdr;
        public Admin()
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

                string select = "select * from employeee order by id ";

                SqlCommand command = new SqlCommand(select, cone);

                SqlDataReader rd = command.ExecuteReader();

                while (rd.Read())

                {

                    employee_table.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6]);

                }

                rd.Close();

                cone.Close();

            }

            catch (Exception Ex)

            {

                MessageBox.Show(Ex.Message);


            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Voullez-vous quitter?",
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

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Voullez-vous vraiment se deconnecter?",
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

        private void conge_show_Click(object sender, EventArgs e)
        {
            conge_deets c1 = new conge_deets();
            c1.Show();

        }

        private void ajouter_Click(object sender, EventArgs e)
        {

            try
            {
                Create_new c2 = new Create_new();
                c2.Show();

            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void Admin_Activated(object sender, EventArgs e)
        {
            employee_table.Rows.Clear();
            MajData();
        }

        private void employee_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.employee_table.Rows[e.RowIndex];
                    id_text.Text = row.Cells[0].Value.ToString();
                    login_text_admin.Text = row.Cells[1].Value.ToString();
                    nom_text_admin.Text = row.Cells[2].Value.ToString();
                    prenom_text_admin.Text = row.Cells[3].Value.ToString();
                    mdp_text_admin.Text = row.Cells[4].Value.ToString();
                    conge_text.Text = row.Cells[5].Value.ToString();
                    true_conge_value.Text = row.Cells[5].Value.ToString();
                    solde_text.Text = row.Cells[6].Value.ToString();
                    if(conge_text.Text =="1")
                    {
                        conge_text.Text = "Oui";
                    }
                    else if (conge_text.Text == "0")
                    {
                        conge_text.Text = "Non";
                    }
                   

                }
            }catch (Exception) {
                id_text.Text = "";
                login_text_admin.Text = "";
                nom_text_admin.Text = "";
                prenom_text_admin.Text = "";
                mdp_text_admin.Text = "";
                conge_text.Text = "";
                true_conge_value.Text = "";
                solde_text.Text = "";
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (ConnectionState.Open == cone.State)
            {
                cone.Close();
            }
            try
            {
                if (conge_text.Text == "Oui"|| conge_text.Text == "oui"|| conge_text.Text == "OUI")
                {
                    true_conge_value.Text = "1";
                }
                else if(conge_text.Text == "Non" || conge_text.Text == "non" || conge_text.Text == "NON")
                {
                    true_conge_value.Text = "0";
                }
                cone.Open();
                string sqlCom = "UPDATE employeee SET nom = '" + nom_text_admin.Text + "', prenom = '" + prenom_text_admin.Text + "',passe =  '" + mdp_text_admin.Text + "',en_congé = " + Convert.ToInt32(true_conge_value.Text) + ",solde = "+Convert.ToInt32(solde_text.Text)+ "WHERE  loginn = '" +login_text_admin.Text +"'";
                SqlCommand command = new SqlCommand(sqlCom, cone);
                command.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Modification Bien fait!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Admin_Activated(sender, e);
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            suppr_dialog s1 = new suppr_dialog();
            s1.Show();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            try
            {
                int prev = this.employee_table.CurrentRow.Index - 1;
                this.employee_table.CurrentCell = this.employee_table.Rows[prev].Cells[this.employee_table.CurrentCell.ColumnIndex];
                
            }
            catch (Exception) { MessageBox.Show("Premier Element !"); }
        }

        private void next_Click(object sender, EventArgs e)
        {
            try
            {
                int next = this.employee_table.CurrentRow.Index + 1;
                this.employee_table.CurrentCell = this.employee_table.Rows[next].Cells[this.employee_table.CurrentCell.ColumnIndex];
            }
            catch (Exception) { MessageBox.Show("Dernier element!"); }
        }

        private void first_Click(object sender, EventArgs e)
        {
            employee_table.CurrentCell = employee_table.Rows[0].Cells[0];
        }
        public int cpt;
        public int cell;
        private void last_Click(object sender, EventArgs e)
        {
            cpt = employee_table.Rows.Count - 2;

            employee_table.CurrentCell = employee_table.Rows[cpt].Cells[0];
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                employee_table.Rows.Clear();
                MajData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void search_text_nom_TextChanged(object sender, EventArgs e)
        {
            try

            {
                if (cone.State == ConnectionState.Open)
                    cone.Close();

                cone.Open();

                string select = "select * from employeee where nom like '" + search_text_nom.Text + "%'order by id ";

                SqlCommand command = new SqlCommand(select, cone);

                SqlDataReader rd = command.ExecuteReader();

                employee_table.Rows.Clear();

                while (rd.Read())
                {
                    employee_table.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6]);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void search_text_login_TextChanged(object sender, EventArgs e)
        {
            try

            {
                if (cone.State == ConnectionState.Open)
                    cone.Close();

                cone.Open();

                string select = "select * from employeee where loginn like '" + search_text_login.Text + "%'order by id ";

                SqlCommand command = new SqlCommand(select, cone);

                SqlDataReader rd = command.ExecuteReader();

                employee_table.Rows.Clear();

                while (rd.Read())
                {
                    employee_table.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6]);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void search_text_id_TextChanged(object sender, EventArgs e)
        {
            try

            {
                if (cone.State == ConnectionState.Open)
                    cone.Close();


                cone.Open();

                string select = "select * from employeee where id = " + search_text_id.Text + "";

                SqlCommand command = new SqlCommand(select, cone);

                SqlDataReader rd = command.ExecuteReader();

                employee_table.Rows.Clear();

                while (rd.Read())
                {
                    employee_table.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5], rd[6]);
                }
            }
            catch (Exception) { rechercher_Click(sender,e); }
        }

        private void employee_table_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.Value is int)
                {
                    if (e.Value.ToString() == "1")
                    {
                        e.Value = "Oui";
                    }
                    else if (e.Value.ToString() == "0")
                    {
                        e.Value = "Non";
                    }
                    else
                    {
                        return;
                    }
                    
                    e.FormattingApplied = true;
                }
            }

            
        }

        private void afficher_demandé_Click(object sender, EventArgs e)
        {
            conge_demandé c2 = new conge_demandé();
            c2.Show();
        }
    }
}
