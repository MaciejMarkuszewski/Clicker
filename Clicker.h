#pragma once
#pragma once

#include <iostream>
#include <string>
#include <vector>

using namespace std;

class Baza_danych_uzytkownika;
class ranking;
class Gracz;
extern Gracz G;
extern int ID;

class Uzytkownik
{
	string login;
	string haslo;
	string status_logowania;

public:
	bool zaloz_konto(string, string, string,Gracz*,ranking*);
	int zweryfikuj_login(string, string,Gracz*,ranking*);
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
	friend bool Uzytkownik::zaloz_konto(string, string, string,Gracz*,ranking*);
};

class Gracz: public Informacje_gracza
{
public:
	Gracz();
	Gracz(int,ranking*);
	void dodaj_punkt();
	void zapisz_dane(ranking*);
	void wypisz();
	void usun_gracza();
};

class Administrator: public Gracz
{
	void usun_gracza();
	void zmien_liczbe_punktow_gracza();
};

class ranking
{
public:
	int liczba_graczy;
	vector <Informacje_gracza> dane ;
	ranking();
	void wypisz();
};


class Dane_logowania_uzytkownika
{
protected:
	string login;
	string haslo;
	time_t data_rejestracji;
public:
	friend bool Uzytkownik::zaloz_konto(string, string,string,Gracz*,ranking*);
	friend int Uzytkownik::zweryfikuj_login(string, string,Gracz*,ranking*);
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
