#pragma once

namespace Realsoft_Configurador {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Realsoft_ConfigurarConexao
	/// </summary>
	public ref class Realsoft_ConfigurarConexao : public System::Windows::Forms::Form
	{
	public:
		Realsoft_ConfigurarConexao(void)
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
		~Realsoft_ConfigurarConexao()
		{
			if (components)
			{
				delete components;
			}
		}
	private: Megasoft::TabControl^  tabControl1;
	protected: 
	private: System::Windows::Forms::TabPage^  TbECF;





















	private: Megasoft::MegasoftButton^  BtServidor;

	private: System::Windows::Forms::TextBox^  TxServidor;

	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label2;
	private: Megasoft::MegasoftButton^  megasoftButton1;
	private: System::Windows::Forms::CheckBox^  ChSqlServer;
	private: System::Windows::Forms::CheckBox^  ChOracle;


	private: System::Windows::Forms::CheckBox^  ChPostGree;
	private: System::Windows::Forms::CheckBox^  ChMySql;



	private: System::Windows::Forms::PictureBox^  pictureBox1;

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
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(Realsoft_ConfigurarConexao::typeid));
			this->tabControl1 = (gcnew Megasoft::TabControl());
			this->TbECF = (gcnew System::Windows::Forms::TabPage());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->ChOracle = (gcnew System::Windows::Forms::CheckBox());
			this->ChPostGree = (gcnew System::Windows::Forms::CheckBox());
			this->ChMySql = (gcnew System::Windows::Forms::CheckBox());
			this->ChSqlServer = (gcnew System::Windows::Forms::CheckBox());
			this->megasoftButton1 = (gcnew Megasoft::MegasoftButton());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->BtServidor = (gcnew Megasoft::MegasoftButton());
			this->TxServidor = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
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
			this->tabControl1->Size = System::Drawing::Size(495, 225);
			this->tabControl1->TabIndex = 5;
			// 
			// TbECF
			// 
			this->TbECF->BackColor = System::Drawing::Color::White;
			this->TbECF->Controls->Add(this->pictureBox1);
			this->TbECF->Controls->Add(this->ChOracle);
			this->TbECF->Controls->Add(this->ChPostGree);
			this->TbECF->Controls->Add(this->ChMySql);
			this->TbECF->Controls->Add(this->ChSqlServer);
			this->TbECF->Controls->Add(this->megasoftButton1);
			this->TbECF->Controls->Add(this->label2);
			this->TbECF->Controls->Add(this->BtServidor);
			this->TbECF->Controls->Add(this->TxServidor);
			this->TbECF->Controls->Add(this->label3);
			this->TbECF->Location = System::Drawing::Point(4, 25);
			this->TbECF->Name = L"TbECF";
			this->TbECF->Padding = System::Windows::Forms::Padding(3);
			this->TbECF->Size = System::Drawing::Size(487, 196);
			this->TbECF->TabIndex = 0;
			this->TbECF->Text = L"tabPage1";
			// 
			// pictureBox1
			// 
			this->pictureBox1->Image = (cli::safe_cast<System::Drawing::Image^  >(resources->GetObject(L"pictureBox1.Image")));
			this->pictureBox1->Location = System::Drawing::Point(15, 14);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(105, 78);
			this->pictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox1->TabIndex = 30;
			this->pictureBox1->TabStop = false;
			// 
			// ChOracle
			// 
			this->ChOracle->AutoSize = true;
			this->ChOracle->FlatStyle = System::Windows::Forms::FlatStyle::Popup;
			this->ChOracle->ForeColor = System::Drawing::Color::SteelBlue;
			this->ChOracle->Location = System::Drawing::Point(382, 89);
			this->ChOracle->Name = L"ChOracle";
			this->ChOracle->Size = System::Drawing::Size(55, 17);
			this->ChOracle->TabIndex = 29;
			this->ChOracle->Text = L"Oracle";
			this->ChOracle->UseVisualStyleBackColor = true;
			// 
			// ChPostGree
			// 
			this->ChPostGree->AutoSize = true;
			this->ChPostGree->FlatStyle = System::Windows::Forms::FlatStyle::Popup;
			this->ChPostGree->ForeColor = System::Drawing::Color::SteelBlue;
			this->ChPostGree->Location = System::Drawing::Point(382, 66);
			this->ChPostGree->Name = L"ChPostGree";
			this->ChPostGree->Size = System::Drawing::Size(68, 17);
			this->ChPostGree->TabIndex = 27;
			this->ChPostGree->Text = L"PostGree";
			this->ChPostGree->UseVisualStyleBackColor = true;
			// 
			// ChMySql
			// 
			this->ChMySql->AutoSize = true;
			this->ChMySql->FlatStyle = System::Windows::Forms::FlatStyle::Popup;
			this->ChMySql->ForeColor = System::Drawing::Color::SteelBlue;
			this->ChMySql->Location = System::Drawing::Point(303, 89);
			this->ChMySql->Name = L"ChMySql";
			this->ChMySql->Size = System::Drawing::Size(53, 17);
			this->ChMySql->TabIndex = 26;
			this->ChMySql->Text = L"MySql";
			this->ChMySql->UseVisualStyleBackColor = true;
			// 
			// ChSqlServer
			// 
			this->ChSqlServer->AutoSize = true;
			this->ChSqlServer->FlatStyle = System::Windows::Forms::FlatStyle::Popup;
			this->ChSqlServer->ForeColor = System::Drawing::Color::SteelBlue;
			this->ChSqlServer->Location = System::Drawing::Point(303, 66);
			this->ChSqlServer->Name = L"ChSqlServer";
			this->ChSqlServer->Size = System::Drawing::Size(73, 17);
			this->ChSqlServer->TabIndex = 25;
			this->ChSqlServer->Text = L"Sql Server";
			this->ChSqlServer->UseVisualStyleBackColor = true;
			// 
			// megasoftButton1
			// 
			this->megasoftButton1->BackColor = System::Drawing::Color::Transparent;
			this->megasoftButton1->BaseColor = System::Drawing::SystemColors::Desktop;
			this->megasoftButton1->ButtonText = L"Fechar";
			this->megasoftButton1->Location = System::Drawing::Point(77, 147);
			this->megasoftButton1->Name = L"megasoftButton1";
			this->megasoftButton1->Size = System::Drawing::Size(56, 28);
			this->megasoftButton1->TabIndex = 24;
			this->megasoftButton1->Click += gcnew System::EventHandler(this, &Realsoft_ConfigurarConexao::megasoftButton1_Click);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 18, static_cast<System::Drawing::FontStyle>((System::Drawing::FontStyle::Bold | System::Drawing::FontStyle::Italic)), 
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->label2->ForeColor = System::Drawing::Color::Black;
			this->label2->Location = System::Drawing::Point(158, 14);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(245, 29);
			this->label2->TabIndex = 23;
			this->label2->Text = L"Configurar Conexão";
			// 
			// BtServidor
			// 
			this->BtServidor->BackColor = System::Drawing::Color::Transparent;
			this->BtServidor->BaseColor = System::Drawing::SystemColors::Desktop;
			this->BtServidor->ButtonText = L"OK";
			this->BtServidor->Location = System::Drawing::Point(15, 147);
			this->BtServidor->Name = L"BtServidor";
			this->BtServidor->Size = System::Drawing::Size(56, 28);
			this->BtServidor->TabIndex = 19;
			this->BtServidor->Click += gcnew System::EventHandler(this, &Realsoft_ConfigurarConexao::BtServidor_Click);
			// 
			// TxServidor
			// 
			this->TxServidor->BorderStyle = System::Windows::Forms::BorderStyle::FixedSingle;
			this->TxServidor->Location = System::Drawing::Point(15, 121);
			this->TxServidor->Name = L"TxServidor";
			this->TxServidor->Size = System::Drawing::Size(464, 20);
			this->TxServidor->TabIndex = 14;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->ForeColor = System::Drawing::Color::Black;
			this->label3->Location = System::Drawing::Point(12, 105);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(79, 13);
			this->label3->TabIndex = 11;
			this->label3->Text = L"String Conexao";
			// 
			// Realsoft_ConfigurarConexao
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(495, 225);
			this->ControlBox = false;
			this->Controls->Add(this->tabControl1);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Name = L"Realsoft_ConfigurarConexao";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->tabControl1->ResumeLayout(false);
			this->TbECF->ResumeLayout(false);
			this->TbECF->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox1))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void megasoftButton1_Click(System::Object^  sender, System::EventArgs^  e) {
				 this->Close();
			 }
private: System::Void BtServidor_Click(System::Object^  sender, System::EventArgs^  e) {
			 try
			 {
				 if(ChSqlServer->Checked == true)
				 {
					 TxServidor->Text = "";
				 }
				 else if(ChMySql->Checked == true)
				 {
					 TxServidor->Text = "";
				 }
				 else if(ChPostGree->Checked == true)
				 {
					 TxServidor->Text = "";
				 }
				 else if (ChOracle->Checked == true)
				 {
					 TxServidor->Text = "";
				 }
				 else
				 {
					 throw gcnew Exception("OPÇÃO INVÁLIDA");
				 }
			 }
			 catch(Exception ^ex)
			 {
				 MessageBox::Show(ex->Message,"Error",MessageBoxButtons::OK, MessageBoxIcon::Error);
			 }
		 }
};
}
