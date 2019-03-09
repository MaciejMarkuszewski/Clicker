using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Clicker_2
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string l, n, h;
            l = textBox1.Text;
            h = textBox2.Text;
            n = textBox3.Text;

            Uzytkownik u1=new Uzytkownik();
            bool ok = true;
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (l.Length < 3 || l.Length > 10)
            {
                ok = false;
            }
            if(!r.IsMatch(l))
            {
                ok = false;
            }
            if (n.Length < 3 || n.Length > 10)
            {
                ok = false;
            }
            if (!r.IsMatch(n))
            {
                ok = false;
            }
            if (h.Length < 8 || h.Length > 20)
            {
                ok = false;
            }
            if (!r.IsMatch(h))
            {
                ok = false;
            }
            Gracz G=new Gracz();
            if (ok)
            {
                ok = u1.zaloz_konto(l, n, h, ref G);  
            }
            if (!ok)
            {
                label7.Visible = true;
            }
            if (ok)
            {
                this.Hide();
                Rozgrywka obj3 = new Rozgrywka(G);
                obj3.ShowDialog();
            }
         }

    }
}
