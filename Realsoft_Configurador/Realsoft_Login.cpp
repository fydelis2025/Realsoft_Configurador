#include "StdAfx.h"
#include "Realsoft_Login.h"


Realsoft_Login::Realsoft_Login(void)
{
}
void Realsoft_Login::setID(int _ID)
	{
		ID = _ID;
	}
	int Realsoft_Login::getID()
	{
		return ID;
	}

	void Realsoft_Login::setNome(String ^_Nome)
	{
		Nome = _Nome;
	}
	String ^Realsoft_Login::getNome()
	{
		return Nome;
	}

	void Realsoft_Login::setDescricao(String ^_Descricao)
	{
		Descricao = _Descricao;
	}
	String ^Realsoft_Login::getDescricao()
	{
		return Descricao;
	}

	void Realsoft_Login::setFiscal(int _IDFiscal)
	{
		IDFiscal = _IDFiscal;
	}
	int Realsoft_Login::getFiscal()
	{
		return IDFiscal;
	}