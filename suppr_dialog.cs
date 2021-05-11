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
    public partial class suppr_dialog : Form
    {
        public suppr_dialog()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emp_button_Click(object sender, EventArgs e)
        {
            suppr_emp em = new suppr_emp();
            em.Show();
            this.Close();
        }

        private void conge_button_Click(object sender, EventArgs e)
        {
            suppr_congé con = new suppr_congé();
            con.Show();
            this.Close();
        }
    }
}
