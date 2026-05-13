#include "StdAfx.h"
#include "Realsoft_Propriedade.h"


Realsoft_Propriedade::Realsoft_Propriedade(void)
{
}

	void Realsoft_Propriedade::SetEmpresa(int _Empresa)
	{
		this->Empresa = _Empresa;
	}
	int Realsoft_Propriedade::getEmpresa()
	{
		return this->Empresa;
	}

	void Realsoft_Propriedade::setTerminal(int _Terminal)
	{
		this->Terminal = _Terminal;
	}
	int Realsoft_Propriedade::getTerminal()
	{
		return this->Terminal;
	}

	void Realsoft_Propriedade::setECF(int _ECF)
	{
		this->ECF = _ECF;
	}
	int Realsoft_Propriedade::getECF()
	{
		return this->ECF;
	}

	void Realsoft_Propriedade::setinicioCodigoEtiqueta(int _inicioCodigoEtiqueta)
	{
		this->inicioCodigoEtiqueta = _inicioCodigoEtiqueta;
	}
	int Realsoft_Propriedade::getinicioCodigoEtiqueta()
	{
		return this->inicioCodigoEtiqueta;
	}
	void Realsoft_Propriedade::setFinalCodigoEtiqueta(int _FinalCodigoEtiqueta)
	{
		this->FinalCodigoEtiqueta = _FinalCodigoEtiqueta;
	}
	int Realsoft_Propriedade::getFinalCodigoEtiqueta()
	{
		return this->FinalCodigoEtiqueta;
	}

	void Realsoft_Propriedade::setinicioValorEtiqueta(int _inicioValorEtiqueta)
	{
		this->inicioValorEtiqueta = _inicioValorEtiqueta;
	}
	int Realsoft_Propriedade::getinicioValorEtiqueta()
	{
		return this->inicioValorEtiqueta;
	}

	void Realsoft_Propriedade::setFinalValorEtiqueta(int _FinalValorEtiqueta)
	{
		this->FinalValorEtiqueta = _FinalValorEtiqueta;
	}
	int Realsoft_Propriedade::getFinalValorEtiqueta()
	{
		return this->FinalValorEtiqueta;
	}
	void Realsoft_Propriedade::setCaminhoPublicidade(String ^ _CaminhoPublicidade)
	{
		this->CaminhoPublicidade = _CaminhoPublicidade;
	}
	String ^Realsoft_Propriedade::getCaminhoPublicidade()
	{
		return this->CaminhoPublicidade;
	}

	void Realsoft_Propriedade::setIpServidor(String ^ _IpServidor)
	{
		this->IpServidor = _IpServidor;
	}
	String ^Realsoft_Propriedade::getIpServidor()
	{
		return this->IpServidor;
	}

	void Realsoft_Propriedade::setPortaConexao(String ^_PortaConexao)
	{
		this->PortaConexao = _PortaConexao;
	}
	String ^Realsoft_Propriedade::getPortaConexao()
	{
		return this->PortaConexao;
	}

	void Realsoft_Propriedade::setHabilitarPrevenda(Boolean _HabilitarPrevenda)
	{
		this->HabilitarPrevenda = _HabilitarPrevenda;
	}
	Boolean Realsoft_Propriedade::getHabilitarPrevenda()
	{
		return this->HabilitarPrevenda;
	}

	void Realsoft_Propriedade::setSolicitarSenhaGaveta(Boolean _SolicitarSenhaGaveta)
	{
		this->SolicitarSenhaGaveta = _SolicitarSenhaGaveta;
	}
	Boolean Realsoft_Propriedade::getSolicitarSenhaGaveta()
	{
		return this->SolicitarSenhaGaveta;
	}