using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_congé
{
    public partial class Change_server : Form
    {
        public Change_server()
        {   
            InitializeComponent();
        }
        public static string str = ServerName.conn;
        private void button1_Click(object sender, EventArgs e)
        {
            ServerName.conn = textBox3.Text;
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox3.Text = @"Data Source=DESKTOP-17K3P2J\SQLEXPRESS;Initial Catalog=gestion_conge;Integrated Security=True";
            textBox2.Enabled = false;
        }

        private void Change_server_Load(object sender, EventArgs e)
        {
                
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox3.Text = @"Data Source=DESKTOP-OFHQIC5\SQLEXPRESS;Initial Catalog=gestion_conge;Integrated Security=True";
            textBox2.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox3.Text = @"Data Source = " + textBox2.Text + "; Initial Catalog = gestion_conge; Integrated Security = True";
            if (textBox2.Text == "")
            {
                button1.Enabled = false;
                textBox2.Text = "";
            }
            textBox2.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            radioButton3.Checked = true;
            textBox3.Text = @"Data Source = " + textBox2.Text + "; Initial Catalog = gestion_conge; Integrated Security = True";
        }

    }
}
