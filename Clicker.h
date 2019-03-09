#pragma once
#pragma once

#include <iostream>
#include <string>
#include <vector>

using namespace std;

class Baza_danych_uzytkownika;
class Ranking;
class Gracz;
extern Gracz G;
extern int ID;

class Uzytkownik
{
	string login;
	string haslo;
	string status_logowania;

public:
	bool zaloz_konto(string, string, string,Gracz*,Ranking*);
	int zweryfikuj_login(string, string,Gracz*,Ranking*);
};

class Informacje_gracza
{
public:
	string nazwa_gracza;
	int punkty;
	int ID_logowania;
	time_t ostatnia_wizyta;
public:
	Informacje_gracza();
	Informacje_gracza(string);
	Informacje_gracza(string, int);
	void wypisz();
	friend bool Uzytkownik::zaloz_konto(string, string, string,Gracz*,Ranking*);
};

class Gracz: public Informacje_gracza
{
public:
	Gracz();
	Gracz(int,Ranking*);
	void dodaj_punkt();
	void zapisz_dane(Ranking*);
	void wypisz();
	void usun_gracza();
};

class Administrator: public Gracz
{
	void usun_gracza();
	void zmien_liczbe_punktow_gracza();
};

class Ranking
{
public:
	int liczba_graczy;
	vector <Informacje_gracza> dane ;
	Ranking();
	void wypisz();
};


class Dane_logowania_uzytkownika
{
protected:
	string login;
	string haslo;
	time_t data_rejestracji;
public:
	friend bool Uzytkownik::zaloz_konto(string, string,string,Gracz*,Ranking*);
	friend int Uzytkownik::zweryfikuj_login(string, string,Gracz*,Ranking*);
	Dane_logowania_uzytkownika();
	Dane_logowania_uzytkownika(string);
};

class Baza_danych_uzytkownika
{
public:
	int liczba_graczy;
	vector <Dane_logowania_uzytkownika> dane;
	Baza_danych_uzytkownika();
};
