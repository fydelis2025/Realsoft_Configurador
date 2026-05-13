#include"Realsoft_INI.h"
#include"Realsoft_Login.h"
#include"Realsoft_Sistema.h"
#include"Realsoft_Criptografia.h"
#pragma once

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Collections::Generic;	
	using namespace System::Data;
	using namespace System::Data::SqlClient;	
	using namespace MySql::Data;
	using namespace MySql::Data::MySqlClient;	
	using namespace std;

ref class Realsoft_Consultas
{
public:
	Realsoft_Consultas(void);

	public: static MySqlConnection ^_ConectaMysql;
public: static MySqlConnection ^getConectaMysql()
		 {
			String ^Conexao = Realsoft_INI::GetIniString(Realsoft_INI::nomeArquivoINI(), "conexao", "mysql", "xxxx");

			String ^Descript = Realsoft_Criptografia::Decrypt(Conexao, Realsoft_Sistema::passPhrase, Realsoft_Sistema::saltValue, Realsoft_Sistema::hashAlgorithm, Realsoft_Sistema::_interacao, Realsoft_Sistema::_initvector, Realsoft_Sistema::keySize);

			_ConectaMysql = gcnew MySqlConnection(Descript);
			_ConectaMysql->Open();

			return _ConectaMysql;
			 			
		 }

public: static IDbDataParameter ^CreateParameter(IDbCommand ^Comando, String ^Nome, DbType ^Tipo, Object ^Valor)
{
	try
	{
		IDbDataParameter ^P = Comando->CreateParameter();
	
		P->DbType::set(*Tipo);
		P->ParameterName = Nome;
		P->Value = Valor;

		return P;
	}
	catch(Exception^ex)
	{
		throw ex;
	}

}

public: static Realsoft_Login ^Consultar_UsuarioFiscal(String^ Login, String ^Senha)
		 {
			 try
				{
					MySqlCommand ^comando = getConectaMysql()->CreateCommand();
					comando->CommandText = "SELECT LOGIN FROM REALSOFT_SISTEMA_LOGIN WHERE LOGIN = @LOGIN AND SENHA = @SENHA AND ABS(ATIVO)=1 ";

					comando->Parameters->Add(CreateParameter(comando, "@LOGIN", DbType::String, Login));
					comando->Parameters->Add(CreateParameter(comando, "@SENHA", DbType::String, Senha));

					MySqlDataReader ^leitura = comando->ExecuteReader(CommandBehavior::CloseConnection);

					Realsoft_Login ^_login = nullptr;

					if (leitura->Read())
					{
						_login = gcnew Realsoft_Login();

						if (!leitura->IsDBNull(0))
						{
							_login->Nome = leitura->GetString(0);
						}	
					}

					leitura->Close();
					return _login;
				}
				catch(MySqlException^ex)
				{
					try
					{
						_ConectaMysql->Close();
					}
					catch (MySqlException^ ex)
					{
						throw ex;
					}
				}
		 }

};

