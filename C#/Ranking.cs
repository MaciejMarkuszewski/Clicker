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
    public partial class Ranking : Form
    {
        public Gracz G;
        public Administrator A;
        public Form  obj;
        public Ranking(Gracz G)
        {
            InitializeComponent(G);
            this.G = G;
        }
        public Ranking(Form obj4,Gracz G)
        {
            obj = obj4;
            InitializeComponent(G);
            this.G = G;
            //
            //TODO: W tym miejscu dodaj kod konstruktora
            //
        }
        public Ranking(Form obj4, Administrator A)
        {
            obj = obj4;
            InitializeComponent(A);
            this.A = A;
            //
            //TODO: W tym miejscu dodaj kod konstruktora
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            obj.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            G.usun_gracza();
            this.Hide();
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Ranking_kl R=new Ranking_kl();
            int usuwanie = 0;
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                if (checkbox1[i].Checked)
                {
                    A.usun_gracza(i - usuwanie, R);
                    usuwanie++;
                }
                else
                {
                    A.zmien_liczbe_punktow_gracza(i - usuwanie, Convert.ToInt32(textbox7[i].Text), R);
                }
            }
            R.Sortuj(0,R.liczba_graczy-1);
            A.zapisz_dane(R);
            this.Hide();
            obj.Show();
        }
    }
}
