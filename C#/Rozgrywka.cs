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
    public partial class Rozgrywka : Form
    {
        public Gracz G;
        public Administrator A;
        public int tick=120;
        public Rozgrywka(Gracz G)
        {
            this.G = G;
            InitializeComponent(G);
            timer1.Start();
            label1.Text = G.nazwa_gracza;
            label3.Text = Convert.ToString(G.punkty);
        }
        public Rozgrywka(Administrator A)
        {
            this.A = A;
            InitializeComponent(A);
            timer1.Start();
            label1.Text = A.nazwa_gracza;
            label3.Text = Convert.ToString(A.punkty);
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

        private void button1_ClickG(object sender, EventArgs e)
        {
            tick = 120;
            Ranking_kl R = new Ranking_kl();
            if (!G.dodaj_punkt())
            {
                G.zapisz_dane();
                this.Hide();
                Application.Exit();
            } 
            string ss = Convert.ToString(G.punkty);
            label3.Text = ss;
            label4.Text = "120";
        }

        private void button2_ClickG(object sender, EventArgs e)
        {
            G.zapisz_dane(); 
            this.Hide();
            Ranking obj4 = new Ranking(this,G);
            obj4.ShowDialog();
        }

        private void button3_ClickG(object sender, EventArgs e)
        {
            G.zapisz_dane(); 
            this.Hide();
            Application.Exit();
        }
        private void button1_ClickA(object sender, EventArgs e)
        {
            tick = 120;
            Ranking_kl R = new Ranking_kl();
            if (!A.dodaj_punkt())
            {
                A.zapisz_dane();
                this.Hide();
                Application.Exit();
            }
            string ss = Convert.ToString(A.punkty);
            label3.Text = ss;
            label4.Text = "120";
        }

        private void button2_ClickA(object sender, EventArgs e)
        {
            A.zapisz_dane();
            this.Hide();
            Ranking obj4 = new Ranking(this, A);
            obj4.ShowDialog();
        }

        private void button3_ClickA(object sender, EventArgs e)
        {
            A.zapisz_dane();
            this.Hide();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick--;
            label4.Text = Convert.ToString(tick);
            if (tick == 0)
            {
                timer1.Stop();
            }
        }
    }
}
