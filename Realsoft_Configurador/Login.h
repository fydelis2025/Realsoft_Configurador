#include"Realsoft_Consultas.h"
#include"Realsoft_Criptografia.h"
#include"Realsoft_INI.h"
#include"Realsoft_Sistema.h"
#include"Realsoft_Login.h"
#include"Form1.h"
#pragma once

namespace Realsoft_Configurador {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Login
	/// </summary>
	public ref class Login : public System::Windows::Forms::Form
	{
	public:
		Login(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Login()
		{
			if (components)
			{
				delete components;
			}
		}
	private: Megasoft::TabControl^  tabControl1;
	protected: 
	private: System::Windows::Forms::TabPage^  TbECF;
	private: System::Windows::Forms::PictureBox^  pictureBox1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::TextBox^  TxSenha;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::TextBox^  TxLogin;
	private: Megasoft::MegasoftButton^  BtFechar;
	private: Megasoft::MegasoftButton^  BtEntrar;

	protected: 

	protected: 








	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(Login::typeid));
			this->tabControl1 = (gcnew Megasoft::TabControl());
			this->TbECF = (gcnew System::Windows::Forms::TabPage());
			this->BtFechar = (gcnew Megasoft::MegasoftButton());
			this->BtEntrar = (gcnew Megasoft::MegasoftButton());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->TxSenha = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->TxLogin = (gcnew System::Windows::Forms::TextBox());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->tabControl1->SuspendLayout();
			this->TbECF->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox1))->BeginInit();
			this->SuspendLayout();
			// 
			// tabControl1
			// 
			this->tabControl1->Autor = nullptr;
			this->tabControl1->BaseColor = System::Drawing::Color::SteelBlue;
			this->tabControl1->ButtonColor = System::Drawing::SystemColors::Desktop;
			this->tabControl1->ButtonText = nullptr;
			this->tabControl1->Controls->Add(this->TbECF);
			this->tabControl1->Dock = System::Windows::Forms::DockStyle::Fill;
			this->tabControl1->Location = System::Drawing::Point(0, 0);
			this->tabControl1->Name = L"tabControl1";
			this->tabControl1->SelectedIndex = 0;
			this->tabControl1->Size = System::Drawing::Size(474, 172);
			this->tabControl1->TabIndex = 6;
			// 
			// TbECF
			// 
			this->TbECF->BackColor = System::Drawing::Color::White;
			this->TbECF->Controls->Add(this->BtFechar);
			this->TbECF->Controls->Add(this->BtEntrar);
			this->TbECF->Controls->Add(this->label2);
			this->TbECF->Controls->Add(this->TxSenha);
			this->TbECF->Controls->Add(this->label1);
			this->TbECF->Controls->Add(this->TxLogin);
			this->TbECF->Controls->Add(this->pictureBox1);
			this->TbECF->Location = System::Drawing::Point(4, 25);
			this->TbECF->Name = L"TbECF";
			this->TbECF->Padding = System::Windows::Forms::Padding(3);
			this->TbECF->Size = System::Drawing::Size(466, 143);
			this->TbECF->TabIndex = 0;
			this->TbECF->Text = L"tabPage1";
			// 
			// BtFechar
			// 
			this->BtFechar->BackColor = System::Drawing::Color::Transparent;
			this->BtFechar->BaseColor = System::Drawing::Color::SteelBlue;
			this->BtFechar->ButtonText = L"Fechar";
			this->BtFechar->Location = System::Drawing::Point(391, 92);
			this->BtFechar->Name = L"BtFechar";
			this->BtFechar->Size = System::Drawing::Size(67, 37);
			this->BtFechar->TabIndex = 24;
			this->BtFechar->Click += gcnew System::EventHandler(this, &Login::BtFechar_Click_1);
			// 
			// BtEntrar
			// 
			this->BtEntrar->BackColor = System::Drawing::Color::Transparent;
			this->BtEntrar->BaseColor = System::Drawing::Color::SteelBlue;
			this->BtEntrar->ButtonText = L"OK";
			this->BtEntrar->Location = System::Drawing::Point(391, 31);
			this->BtEntrar->Name = L"BtEntrar";
			this->BtEntrar->Size = System::Drawing::Size(67, 37);
			this->BtEntrar->TabIndex = 23;
			this->BtEntrar->Click += gcnew System::EventHandler(this, &Login::BtEntrar_Click);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->ForeColor = System::Drawing::Color::SteelBlue;
			this->label2->Location = System::Drawing::Point(142, 80);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(38, 13);
			this->label2->TabIndex = 22;
			this->label2->Text = L"Senha";
			// 
			// TxSenha
			// 
			this->TxSenha->BorderStyle = System::Windows::Forms::BorderStyle::FixedSingle;
			this->TxSenha->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 15.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->TxSenha->Location = System::Drawing::Point(145, 96);
			this->TxSenha->Name = L"TxSenha";
			this->TxSenha->Size = System::Drawing::Size(239, 31);
			this->TxSenha->TabIndex = 21;
			this->TxSenha->UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->ForeColor = System::Drawing::Color::SteelBlue;
			this->label1->Location = System::Drawing::Point(142, 13);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(33, 13);
			this->label1->TabIndex = 20;
			this->label1->Text = L"Login";
			// 
			// TxLogin
			// 
			this->TxLogin->BorderStyle = System::Windows::Forms::BorderStyle::FixedSingle;
			this->TxLogin->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 15.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->TxLogin->Location = System::Drawing::Point(145, 29);
			this->TxLogin->Name = L"TxLogin";
			this->TxLogin->Size = System::Drawing::Size(239, 31);
			this->TxLogin->TabIndex = 19;
			this->TxLogin->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &Login::TxLogin_KeyDown);
			// 
			// pictureBox1
			// 
			this->pictureBox1->Image = (cli::safe_cast<System::Drawing::Image^  >(resources->GetObject(L"pictureBox1.Image")));
			this->pictureBox1->Location = System::Drawing::Point(17, 22);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(112, 102);
			this->pictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox1->TabIndex = 18;
			this->pictureBox1->TabStop = false;
			// 
			// Login
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::Color::White;
			this->ClientSize = System::Drawing::Size(474, 172);
			this->ControlBox = false;
			this->Controls->Add(this->tabControl1);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^  >(resources->GetObject(L"$this.Icon")));
			this->MaximizeBox = false;
			this->MinimizeBox = false;
			this->Name = L"Login";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->tabControl1->ResumeLayout(false);
			this->TbECF->ResumeLayout(false);
			this->TbECF->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox1))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
	
private: System::Void BtEntrar_Click(System::Object^  sender, System::EventArgs^  e) {
 			 try
			 {
				if (TxLogin->Text->Trim()->Length == 0 )
				{
					throw gcnew Exception("LOGIN OU SENHA INVÁLIDO");
				}
				else
				{
					Realsoft_Login ^ Logon = gcnew Realsoft_Login();

					String ^Descript = Realsoft_Criptografia::Encrypt(TxSenha->Text, Realsoft_Sistema::passPhrase, Realsoft_Sistema::saltValue, Realsoft_Sistema::hashAlgorithm, Realsoft_Sistema::_interacao, Realsoft_Sistema::_initvector, Realsoft_Sistema::keySize);

					Logon = Realsoft_Consultas::Consultar_UsuarioFiscal(TxLogin->Text,Descript);

					if (Logon != nullptr)
					{
						Form1 ^Main = gcnew Form1();
						this->Hide();
						Main->ShowDialog();
					}
					else
					{
						throw gcnew Exception("LOGIN OU SENHA INCORRETO");
					}
				}
				 
			 }
			 catch(Exception ^ex)
			 {
				 MessageBox::Show(ex->Message,"Error",MessageBoxButtons::OK, MessageBoxIcon::Error);
			 }

		 }

private: System::Void BtFechar_Click_1(System::Object^  sender, System::EventArgs^  e) {
			 Application::Exit();
		 }

private: System::Void TxLogin_KeyDown(System::Object^  sender, System::Windows::Forms::KeyEventArgs^  e) {
			 if(e->KeyCode == Keys::Enter)
			 {
				 TxSenha->Focus();
			 }
		 }
};
}
