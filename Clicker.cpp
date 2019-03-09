#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <ctime>
#include <stdlib.h>
#include <vector>
#include <locale>
#include "Clicker.h"
#include "Ekran startowy.h"
#include "Rejestracja.h"

using namespace std;
Gracz G;
ranking R;

bool Uzytkownik::zaloz_konto(string l,string n, string h,Gracz *G,ranking *R)
{
	this->login = l;
	this->haslo = h;
	bool ok = true;
	Baza_danych_uzytkownika B;
	for (int i = 0; i < B.liczba_graczy; i++)
	{
		if (login == B.dane[i].login)
		{
			ok = false;
			break;
		}
	}
	for (int i = 0; i < R->liczba_graczy; i++) {
		if (n == R->dane[i].nazwa_gracza) {
			ok = false;
		}
	}
	if (ok)
	{
		Dane_logowania_uzytkownika d;
		d.login = login;
		d.haslo = haslo;
		d.data_rejestracji=time(NULL);
		Informacje_gracza ig(n,B.liczba_graczy);
		G->nazwa_gracza = ig.nazwa_gracza;
		G->punkty = ig.punkty;
		G->ID_logowania = ig.ID_logowania;
		G->ostatnia_wizyta = ig.ostatnia_wizyta;
		B.dane.push_back(d);
		B.liczba_graczy++;
		R->dane.push_back(ig);
		R->liczba_graczy++;
		ofstream pout, rout;
		pout.open("baza.csv");
		rout.open("ranking.csv");
		for (int i = 0; i < B.liczba_graczy; i++) {
			pout << B.dane[i].login << "," << B.dane[i].haslo << "," << B.dane[i].data_rejestracji << endl;
		}
		for (int i = 0; i < R->liczba_graczy; i++) {
			rout<< R->dane[i].nazwa_gracza << "," << R->dane[i].punkty << "," << R->dane[i].ID_logowania<<","<< R->dane[i].ostatnia_wizyta << endl ;
		}
		pout.close();
		rout.close();
		return true;
	}
	else 
	{
		return false;
	}
}
int Uzytkownik::zweryfikuj_login(string l, string h,Gracz *G,ranking *R)
{
	Baza_danych_uzytkownika B;
	login = l;
	haslo = h;
	for (int i = 0; i < B.liczba_graczy; i++)
	{
		if (login == B.dane[i].login && haslo==B.dane[i].haslo)
		{
			for (int j = 0; j < R->liczba_graczy; j++) 
			{
				if (i == R->dane[j].ID_logowania) 
				{
					return j;
				}
			}
		}
	}
	return -1;

}

Informacje_gracza::Informacje_gracza()
{
	//puste
}

Informacje_gracza::Informacje_gracza(string s)
{
	string  d = "";
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
	istringstream issp(d);
	issp >> punkty;
	d = "";
	for (; s[i] != ','; i++)
	{
		d += s[i];
	}
	i++;
	istringstream issid(d);
	issid >> ID_logowania;
	d = "";
	for (;i<s.size(); i++)
	{
		d += s[i];
	}
	istringstream issow(d);
	issow >> ostatnia_wizyta;
}

Informacje_gracza::Informacje_gracza(string n, int id)
{
	nazwa_gracza = n;
	punkty = 0;
	ID_logowania = id;
	ostatnia_wizyta=time(NULL);
}

Gracz::Gracz() {

}

Gracz::Gracz(int id,ranking *R) 
{
	for (int i = 0; i < R->liczba_graczy; i++)
	{
		if (id == R->dane[i].ID_logowania)
		{
			nazwa_gracza = R->dane[i].nazwa_gracza;
			punkty = R->dane[i].punkty;
			ID_logowania = R->dane[i].ID_logowania;
			ostatnia_wizyta = R->dane[i].ostatnia_wizyta;
		}
	}
}

void Gracz::dodaj_punkt() 
{
	punkty++;
}

void Gracz::zapisz_dane(ranking *R)
{
	for (int i = 0; i < R->liczba_graczy; i++) 
	{
		if (R->dane[i].ID_logowania == ID_logowania)
		{
			R->dane[i].punkty = punkty;
			R->dane[i].ostatnia_wizyta = time(NULL);
		}
	}
	for (int i = 0; i < R->liczba_graczy; i++)
	{
		if (ID_logowania == R->dane[i].ID_logowania)
		{
			for (int j = 0; j < i; j++)
			{
				if (R->dane[i].punkty > R->dane[j].punkty)
				{
					R->dane.insert(R->dane.begin() + j, R->dane[i]);
					R->dane.erase(R->dane.begin() + i + 1);
				}
			}
			break;
		}
	}
	ofstream rout;
	rout.open("ranking.csv");
	for (int i = 0; i < R->liczba_graczy; i++) {
		rout << R->dane[i].nazwa_gracza << "," << R->dane[i].punkty << "," << R->dane[i].ID_logowania << "," << R->dane[i].ostatnia_wizyta << endl;
	}
	rout.close();
}

Dane_logowania_uzytkownika::Dane_logowania_uzytkownika()
{

}

Dane_logowania_uzytkownika::Dane_logowania_uzytkownika(string s)
{
	string  d="";
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
	for (;i<s.size(); i++)
	{
		d += s[i];
	}
	istringstream iss(d);
	iss >> this->data_rejestracji;
}


Baza_danych_uzytkownika::Baza_danych_uzytkownika()
{
	liczba_graczy = 0;
	ifstream pin;
	pin.open("baza.csv");
	string s;
	pin >> s;
	for (int i = 0; !pin.eof(); i++)
	{
		if (s != "") 
		{
			dane.push_back(Dane_logowania_uzytkownika(s));
			liczba_graczy++;
		}
		pin >> s;
	}
	pin.close();
}

ranking::ranking()
{
	liczba_graczy = 0;
	ifstream rin;
	rin.open("ranking.csv");
	string s;
	rin >> s;
	for (int i = 0; !rin.eof(); i++)
	{
		if (s != "") 
		{
			dane.push_back(Informacje_gracza(s));
			liczba_graczy++;
		}
		rin >> s;
	}
	rin.close();
}


