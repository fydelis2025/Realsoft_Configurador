#include <iostream>
#include<io.h>
#include"Realsoft_INI.h"
#pragma once

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Collections::Generic;	
	using namespace System::Data;
	using namespace std;
	using namespace System::Threading;
	using namespace System::Windows::Forms;


ref class Realsoft_Sistema
{
public:
	Realsoft_Sistema(void);

public: static String ^_descriptografado;
public: static String ^_textocriptografado;
public: static String ^passPhrase = "Pas5pr@se";
public: static String ^saltValue = "s@1tValue";
public: static String ^hashAlgorithm = "SHA1";
public: static int _interacao = 2;
public: static String ^_initvector = "@1B2c3D4e5F6g7H8";
public: static int keySize = 256;

};

