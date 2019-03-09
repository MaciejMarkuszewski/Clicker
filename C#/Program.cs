using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker_2
{
    public class Ranking_kl
    {
        public int liczba_graczy=0;
        public List<Informacje_gracza> dane;    
        public Ranking_kl()
        {
            dane = new List<Informacje_gracza>();
            liczba_graczy = 0;
            StreamReader rin;
            rin=new StreamReader("ranking.csv");
            string s;
            s = rin.ReadLine();
            for (int i = 0; s != null && s != ""; i++)
            {
                dane.Add(new Informacje_gracza(s));
                liczba_graczy++;
                s = rin.ReadLine();
                s = rin.ReadLine();
            }
            rin.Close();
        }
        public void Sortuj(int p, int k)
        {
            if (p < k)
            {
                int x = this.dane[(p + k) / 2].punkty;
                int i = p, j = k;
                Informacje_gracza w;
                while (i<=j)
                {
                    while (this.dane[j].punkty < x)
                        j--;
                    while (this.dane[i].punkty > x)
                        i++;
                    if (i <= j)
                    {
                        w = this.dane[i];
                        this.dane[i] = this.dane[j];
                        this.dane[j] = w;
                        i++;
                        j--;
                    }
                }
                this.Sortuj(p, j);
                this.Sortuj(i + 1, k);
            }
        }
    }

    class Uzytkownik
    {
        private string login;
        private string haslo;

        public bool zaloz_konto(string l, string n, string h, ref Gracz G)
        {
            this.login = l;
            this.haslo = h;
            bool ok = true;
            Baza_danych_uzytkownika B =new Baza_danych_uzytkownika();
            for (int i = 0; i < B.liczba_graczy; i++)
            {
                if (login == B.dane[i].login)
                {
                    ok = false;
                    break;
                }
            }
            Ranking_kl R = new Ranking_kl();
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                if (n == R.dane[i].nazwa_gracza)
                {
                    ok = false;
                }
            }
            if (ok)
            {
                Dane_logowania_uzytkownika d = new Dane_logowania_uzytkownika();
                d.login = login;
                d.haslo = haslo;
                d.data_rejestracji = DateTime.Now.Ticks ;
                Informacje_gracza ig=new Informacje_gracza(n, B.liczba_graczy);
                G.nazwa_gracza = ig.nazwa_gracza;
                G.punkty = ig.punkty;
                G.ID_logowania = ig.ID_logowania;
                G.ostatnia_wizyta = ig.ostatnia_wizyta;
                B.dane.Add(d);
                B.liczba_graczy++;
                R.dane.Add(ig);
                R.liczba_graczy++;
                StreamWriter pout, rout;
                pout = new StreamWriter("baza.csv");
                rout = new StreamWriter("ranking.csv");
                for (int i = 0; i < B.liczba_graczy; i++)
                {
                    pout.WriteLine("{0},{1},{2}\n", B.dane[i].login, B.dane[i].haslo, B.dane[i].data_rejestracji);
                }
                for (int i = 0; i < R.liczba_graczy; i++)
                {
                    rout.WriteLine("{0},{1},{2},{3}\n", R.dane[i].nazwa_gracza, R.dane[i].punkty, R.dane[i].ID_logowania, R.dane[i].ostatnia_wizyta);
                }
                pout.Close();
                rout.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public int zweryfikuj_login(string l, string h)
        {
            Baza_danych_uzytkownika B=new Baza_danych_uzytkownika();
            Ranking_kl R=new Ranking_kl();
            login = l;
            haslo = h;
            for (int i = 0; i < B.liczba_graczy; i++)
            {
                if (login == B.dane[i].login && haslo == B.dane[i].haslo)
                {
                    for (int j = 0; j < R.liczba_graczy; j++)
                    {
                        if (i == R.dane[j].ID_logowania)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }
    }   

    public class Informacje_gracza
    {
	    public string nazwa_gracza;
        public int punkty;
        public int ID_logowania;
        public long ostatnia_wizyta; 
        public Informacje_gracza()
        {
            //puste
        }
        public Informacje_gracza(string s)
        {
            string d = "";
            int i = 0;
            for (; s[i] != ','; i++)
            {
                nazwa_gracza += s[i];
            }
            i++;
            for (; s[i] != ','; i++)
            {
                d += s[i];
            }
            i++;
            punkty = Convert.ToInt32(d);
            d = "";
            for (; s[i] != ','; i++)
            {
                d += s[i];
            }
            i++;
            ID_logowania = Convert.ToInt32(d);
            d = "";
            for (; i < s.Length; i++)
            {
                d += s[i];
            }
            ostatnia_wizyta = Convert.ToInt64(d);
        }
        public Informacje_gracza(string n, int id)
        {
            nazwa_gracza = n;
            punkty = 0;
            ID_logowania = id;
            ostatnia_wizyta = DateTime.Now.Ticks;
        }
    }

    public class Gracz : Informacje_gracza
    {
        public Gracz()
        {
            //puste
        }
        public Gracz(int id)
        {
            Ranking_kl R = new Ranking_kl();
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                if (id == R.dane[i].ID_logowania)
                {
                    nazwa_gracza = R.dane[i].nazwa_gracza;
                    punkty = R.dane[i].punkty;
                    ID_logowania = R.dane[i].ID_logowania;
                    ostatnia_wizyta = DateTime.Now.Ticks;
                }
            }
        }
        public bool czy_administrator()
        {
            if (this.nazwa_gracza == "Admin" && this.ID_logowania == 0)
            {
                return true;
            }
            else return false;
        }
        public bool dodaj_punkt()

        {
            DateTime czas = new
                DateTime(this.ostatnia_wizyta);
            if(czas.Minute*60+czas.Second+120>
                DateTime.Now.Minute*60 +DateTime.Now.Second)
            {
                punkty++;
                this.ostatnia_wizyta = DateTime.Now.Ticks;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void zapisz_dane()
        {
            Ranking_kl R = new Ranking_kl();
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                if (R.dane[i].ID_logowania == ID_logowania)
                {
                    R.dane[i].punkty = punkty;
                    R.dane[i].ostatnia_wizyta = DateTime.Now.Ticks;
                    for (int j = 0; j < i; j++)
                    {
                        if (R.dane[i].punkty > R.dane[j].punkty)
                        {
                            R.dane.Insert(j, R.dane[i]); 
                            R.dane.RemoveAt(i + 1);
                        }
                    }
                    break;
                }
            }
            StreamWriter rout;
            rout = new StreamWriter("ranking.csv");
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                rout.WriteLine("{0},{1},{2},{3}\n",
                    R.dane[i].nazwa_gracza, R.dane[i].punkty,
                    R.dane[i].ID_logowania, R.dane[i].ostatnia_wizyta);
            }
            rout.Close();
        }
        public void usun_gracza()
        {
            Ranking_kl R=new Ranking_kl();
            Baza_danych_uzytkownika B = new Baza_danych_uzytkownika();
            for(int i = 0; i < R.liczba_graczy; i++)
            {
                if (R.dane[i].ID_logowania==this.ID_logowania)
                {
                    R.dane.RemoveAt(i);
                    B.dane.RemoveAt(this.ID_logowania);
                    R.liczba_graczy--;
                    B.liczba_graczy--;
                    break;
                }
            }
            for(int i = 0; i < R.liczba_graczy; i++)
            {
                if (R.dane[i].ID_logowania > this.ID_logowania)
                {
                    R.dane[i].ID_logowania--;
                }
            }
            StreamWriter rout;
            rout = new StreamWriter("ranking.csv");
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                rout.WriteLine("{0},{1},{2},{3}\n", R.dane[i].nazwa_gracza, R.dane[i].punkty, R.dane[i].ID_logowania, R.dane[i].ostatnia_wizyta);
            }
            rout.Close();
            StreamWriter pout;
            pout = new StreamWriter("baza.csv");
            for (int i = 0; i < B.liczba_graczy; i++)
            {
                pout.WriteLine("{0},{1},{2}\n", B.dane[i].login, B.dane[i].haslo, B.dane[i].data_rejestracji);
            }
            pout.Close();
        }
    }
    public class Administrator : Gracz
    {
        public Administrator(Gracz G)
        {
            this.ID_logowania = G.ID_logowania;
            this.nazwa_gracza = G.nazwa_gracza;
            this.punkty = G.punkty;
            this.ostatnia_wizyta = G.ostatnia_wizyta;
        }
	    public void usun_gracza(int ID,Ranking_kl R)
        {
            Baza_danych_uzytkownika B = new Baza_danych_uzytkownika();
            int ID_logowania = R.dane[ID].ID_logowania;
            B.dane.RemoveAt(ID_logowania);
            R.dane.RemoveAt(ID);
            R.liczba_graczy--;
            B.liczba_graczy--;
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                if (R.dane[i].ID_logowania >ID_logowania)
                {
                    R.dane[i].ID_logowania--;
                }
            }
            StreamWriter pout;
            pout = new StreamWriter("baza.csv");
            for (int i = 0; i < B.liczba_graczy; i++)
            {
                pout.WriteLine("{0},{1},{2}\n", B.dane[i].login, B.dane[i].haslo, B.dane[i].data_rejestracji);
            }
            pout.Close();
        }
        public void zmien_liczbe_punktow_gracza(int ID,int punkty,Ranking_kl R)
        {
            R.dane[ID].punkty = punkty;
            if (R.dane[ID].ID_logowania == this.ID_logowania)
            {
                this.punkty = punkty;
            }
        }
        public void zapisz_dane(Ranking_kl R)
        {
            Baza_danych_uzytkownika B = new Baza_danych_uzytkownika();
            StreamWriter rout;
            rout = new StreamWriter("ranking.csv");
            for (int i = 0; i < R.liczba_graczy; i++)
            {
                rout.WriteLine("{0},{1},{2},{3}\n", R.dane[i].nazwa_gracza, R.dane[i].punkty, R.dane[i].ID_logowania, R.dane[i].ostatnia_wizyta);
            }
            rout.Close();
            StreamWriter pout;
            pout = new StreamWriter("baza.csv");
            for (int i = 0; i < B.liczba_graczy; i++)
            {
                pout.WriteLine("{0},{1},{2}\n", B.dane[i].login, B.dane[i].haslo, B.dane[i].data_rejestracji);
            }
            pout.Close();
        }
    }

     class Dane_logowania_uzytkownika
    {
	    internal protected string login;
        internal protected string haslo;
        internal protected long data_rejestracji;
        public Dane_logowania_uzytkownika()
        {
            //puste
        }
        public Dane_logowania_uzytkownika(string s)
        {
            string d = "";
            int i = 0;
            for (; s[i] != ','; i++)
            {
                login += s[i];
            }
            i++;
            for (; s[i] != ','; i++)
            {
                haslo += s[i];
            }
            i++;
            for (; i < s.Length; i++)
            {
                d += s[i];
            }
            data_rejestracji = Convert.ToInt64(d);
        }
    }


    class Baza_danych_uzytkownika
    {
	    public int liczba_graczy;
        public List<Dane_logowania_uzytkownika> dane;
        public Baza_danych_uzytkownika()
        {
            dane = new List<Dane_logowania_uzytkownika>();
            liczba_graczy = 0;
            StreamReader pin;
            pin=new StreamReader("baza.csv");
            string s;
            s = pin.ReadLine();
            for (int i = 0; s != null && s!="" ; i++)
            {
                dane.Add(new Dane_logowania_uzytkownika(s));
                liczba_graczy++;
                s = pin.ReadLine();
                s = pin.ReadLine();
            }
            pin.Close();
    }
 }

static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
