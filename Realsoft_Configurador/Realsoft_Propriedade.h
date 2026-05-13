#include <io.h>;
#pragma once

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Drawing;
	using namespace std;
	using namespace System::Drawing::Design;

ref class Realsoft_Propriedade
{
public:
	Realsoft_Propriedade(void);

public:
	int Empresa;
	int Terminal;
	int ECF;
	int inicioCodigoEtiqueta;
	int FinalCodigoEtiqueta;
	int inicioValorEtiqueta;
	int FinalValorEtiqueta;
	String ^CaminhoPublicidade;
	String ^IpServidor;
	String ^PortaConexao;
	Boolean HabilitarPrevenda;
	Boolean SolicitarSenhaGaveta;

	void SetEmpresa(int _Empresa);
	int getEmpresa();

	void setTerminal(int _Terminal);
	int getTerminal();

	void setECF(int _ECF);
	int getECF();

	void setinicioCodigoEtiqueta(int _inicioCodigoEtiqueta);
	int getinicioCodigoEtiqueta();

	void setFinalCodigoEtiqueta(int _FinalCodigoEtiqueta);
	int getFinalCodigoEtiqueta();

	void setinicioValorEtiqueta(int _inicioValorEtiqueta);
	int getinicioValorEtiqueta();

	void setFinalValorEtiqueta(int _FinalValorEtiqueta);
	int getFinalValorEtiqueta();

	void setCaminhoPublicidade(String ^ _CaminhoPublicidade);
	String ^getCaminhoPublicidade();

	void setIpServidor(String ^ _IpServidor);
	String ^getIpServidor();

	void setPortaConexao(String ^_PortaConexao);
	String ^getPortaConexao();	

	void setHabilitarPrevenda(Boolean _HabilitarPrevenda);
	Boolean getHabilitarPrevenda();

	void setSolicitarSenhaGaveta(Boolean _SolicitarSenhaGaveta);
	Boolean getSolicitarSenhaGaveta();
};