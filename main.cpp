#include <iostream>
#include <fstream>
#include <string>
#include <ctime>
#include <stdlib.h>
#include <vector>
#include "Clicker.h"
#include "Ekran startowy.h"
#include "Rejestracja.h"
#include "Logowanie.h"
#include "Ranking.h"
#include "Rozgrywka.h"

using namespace std;
using namespace System;
using namespace System::Windows::Forms;
[STAThread]

void main()
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Clicker::Ekranstartowy form;
	Application::Run(%form);

}