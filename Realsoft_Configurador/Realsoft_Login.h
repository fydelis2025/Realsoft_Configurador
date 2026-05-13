#include <iostream>
#include<io.h>
#pragma once

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Collections::Generic;	
	using namespace std;

ref class Realsoft_Login
{
public:
	Realsoft_Login(void);
	public: 
	int ID;
	int IDFiscal;
	String ^Nome;
	String ^Descricao;

	void setID(int _ID);
	int getID();

	void setNome(String ^_Nome);
	String ^getNome();

	void setDescricao(String ^_Descricao);
	String ^getDescricao();

	void setFiscal(int _IDFiscal);
	int getFiscal();

};

