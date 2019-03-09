using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clicker_2
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              Uzytkownik u1=new Uzytkownik();
              int ID;
              string l, h;
              l = textBox1.Text;
              h = textBox2.Text;
              ID = u1.zweryfikuj_login(l, h); 
              if (ID == -1)
              {
                  label3.Visible = true;
              }
              else
              {
                Gracz G = new Gracz(ID);
                if (G.czy_administrator())
                {
                    Administrator A= new Administrator(G);
                    Rozgrywka obj3 = new Rozgrywka(A);
                    this.Hide();
                    obj3.ShowDialog();
                }
                else
                {
                    Rozgrywka obj3 = new Rozgrywka(G);
                    this.Hide();
                    obj3.ShowDialog();
                }
              }
         }
    }
}
