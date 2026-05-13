#include<io.h>
#include<iostream>
#pragma once
	
	using namespace System;
	using namespace System::Collections;
	using namespace System::Collections::Generic;
	using namespace System::Data;
	using namespace System::Diagnostics;
	using namespace System::Runtime::InteropServices;
	using namespace System::Windows::Forms;
	using namespace System::Security::Cryptography;
	using namespace System::Text;

	[DllImport("kernel32")]
	extern int WritePrivateProfileString(String ^lpApplicationName, String ^lpKeyName, String ^lpString, String ^lpFileName);
	
	[DllImport("kernel32")]
	extern int GetPrivateProfileString(String ^lpApplicationName, String ^lpKeyName, String ^lpDefault, StringBuilder ^lpReturnedString, int nSize, String ^lpFileName);

ref class Realsoft_INI
{
public:
	Realsoft_INI(void);
		public: static String ^Espaco(int count)
        {
			String ^Retorno = "";

            return Retorno->PadLeft(count);
        }

public: static String ^GetIniString(String ^file_name, String ^section_name, String ^key_name, String ^default_value)
        {
            const int MAX_LENGTH = 500;
            StringBuilder ^string_builder = gcnew StringBuilder(MAX_LENGTH);
            GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, file_name);
            return string_builder->ToString();
        }

public: static String ^nomeArquivoINI()
        {
            String ^nome_arquivo_ini = Application::StartupPath;
            nome_arquivo_ini = nome_arquivo_ini->Substring(0, nome_arquivo_ini->IndexOf("\\"));
            return (nome_arquivo_ini + "AjusteConfig.ini");
        }
public: static void gravaarquivoini(String ^_chave, String ^_KeyValor, String ^_texto)
        {
            String ^nome_arquivo_ini = nomeArquivoINI();
            String ^valorSenha;

            WritePrivateProfileString(_chave, _KeyValor, _texto, nomeArquivoINI());
        }

public: static String ^CifraSenha(String ^strSenha)
        {
            // A mesma rotina encripta e descripta
            String ^nLetra = "";
            String ^cSenha = "";
            int L = 0;
            strSenha = strSenha->Trim();
            for (L = 1; (L <= strSenha->Length); L++)
            {
                nLetra = strSenha->Substring((L - 1), 1);

                cSenha = (cSenha + nLetra);
            }
            return cSenha;
        }

public: static String ^geraHash(String ^valor)
        {
            UnicodeEncoding ^Ue = gcnew UnicodeEncoding();
            
			array<Byte>^ ByteSourceText = Ue->GetBytes(valor);
            
			MD5CryptoServiceProvider ^Md5 = gcnew MD5CryptoServiceProvider();
            
			array<Byte>^ ByteHash = Md5->ComputeHash(ByteSourceText);
            
			return Convert::ToBase64String(ByteHash);

        }

};

