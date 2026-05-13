#include <iostream>
#include<io.h>
#pragma once
	
	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Collections::Generic;	
	using namespace std;
	using namespace System::Security::Cryptography;
	using namespace System::Text;
	using namespace System::IO;

ref class Realsoft_Criptografia
{
public:
	Realsoft_Criptografia(void);

public: static String ^Encrypt(String ^plainText, String ^passPhrase, String ^saltValue, String ^hashAlgorithm, int passwordIterations, String ^initVector, int keySize)
		{

			array<Byte>^ initVectorBytes, ^saltValueBytes, ^plainTextBytes, ^keyBytes;  
			
			initVectorBytes = Encoding::ASCII->GetBytes(initVector);
            saltValueBytes = Encoding::ASCII->GetBytes(saltValue);

            
            plainTextBytes = Encoding::UTF8->GetBytes(plainText);

            
            PasswordDeriveBytes ^password = gcnew PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations);

            
            keyBytes = password->GetBytes(keySize / 8);

            
            RijndaelManaged ^symmetricKey = gcnew RijndaelManaged();

           
            symmetricKey->Mode = CipherMode::CBC;

            ICryptoTransform ^encryptor = symmetricKey->CreateEncryptor(keyBytes, initVectorBytes);

            
            MemoryStream ^memoryStream = gcnew MemoryStream();

            
            CryptoStream ^cryptoStream = gcnew CryptoStream(memoryStream, encryptor, CryptoStreamMode::Write);
            cryptoStream->Write(plainTextBytes, 0, plainTextBytes->Length);

            cryptoStream->FlushFinalBlock();

            
            array<Byte>^ cipherTextBytes = memoryStream->ToArray();

            
            memoryStream->Close();
            cryptoStream->Close();

            
            String ^cipherText = Convert::ToBase64String(cipherTextBytes);

            
            return cipherText;
 
		}


public: static String ^Decrypt(String ^cipherText, String ^passPhrase, String ^saltValue, String ^hashAlgorithm,  int passwordIterations, String ^initVector, int keySize)
        {

            array<Byte>^ initVectorBytes, ^saltValueBytes, ^cipherTextBytes, ^keyBytes, ^plainTextBytes; 
			
			initVectorBytes = Encoding::ASCII->GetBytes(initVector);
            
			saltValueBytes = Encoding::ASCII->GetBytes(saltValue);

            cipherTextBytes = Convert::FromBase64String(cipherText);
            
            PasswordDeriveBytes ^password = gcnew PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations);

            keyBytes = password->GetBytes(keySize / 8);

            RijndaelManaged ^symmetricKey = gcnew RijndaelManaged();
            
            symmetricKey->Mode = CipherMode::CBC;

            ICryptoTransform ^decryptor = symmetricKey->CreateDecryptor(keyBytes, initVectorBytes);

            MemoryStream ^memoryStream = gcnew MemoryStream(cipherTextBytes);
            
            CryptoStream ^cryptoStream = gcnew CryptoStream(memoryStream, decryptor, CryptoStreamMode::Read);
			
			//plainTextBytes = Convert::ToByte(cipherTextBytes);
			
            int decryptedByteCount = cryptoStream->Read(cipherTextBytes, 0, cipherTextBytes.Length);
            
            memoryStream->Close();
            cryptoStream->Close();
            
            String ^plainText = Encoding::UTF8->GetString(cipherTextBytes,   0,  decryptedByteCount);
            
            return plainText;
        }

};

