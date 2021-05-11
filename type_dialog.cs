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
    public partial class type_dialog : Form
    {
        public type_dialog()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Close();
        }

        private void annuel_but_Click(object sender, EventArgs e)
        {
            emp_page em_a = new emp_page();
            em_a.Show();
            this.Close();
        }

        private void maladie_butt_Click(object sender, EventArgs e)
        {
            emp_maladie em_m = new emp_maladie();
            em_m.Show();
            this.Close();
        }

        private void maternite_but_Click(object sender, EventArgs e)
        {
            emp_maternité em_ma = new emp_maternité();
            em_ma.Show();
            this.Close();
        }

        private void autre_but_Click(object sender, EventArgs e)
        {
            emp_autre em_a = new emp_autre();
            em_a.Show();
            this.Close();
        }

        private void conge_accepté_Click(object sender, EventArgs e)
        {
            congé_accepté c_a = new congé_accepté();
            c_a.Show();
            
        }

        private void conge_refusé_Click(object sender, EventArgs e)
        {
            congé_refusé c_r = new congé_refusé();
            c_r.Show();
            
        }

        private void conge_demandé_Click(object sender, EventArgs e)
        {
            congé_demandé_emp c_d = new congé_demandé_emp();
            c_d.Show();
            
        }
    }
}
