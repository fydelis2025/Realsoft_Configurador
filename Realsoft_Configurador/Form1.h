#include <iostream>;
#include <io.h>;
#include"Realsoft_Criptografia.h"
#include"Realsoft_ConfigurarConexao.h"
#include"Realsoft_Propriedade.h"
#include"Form2.h"
#pragma once

namespace Realsoft_Configurador {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
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
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}

	private: Megasoft::MegasoftStatusStrip^  megasoftStatusStrip1;















	private: System::Windows::Forms::ToolStripDropDownButton^  BtECF;





























	private: System::Windows::Forms::ToolStripMenuItem^  configurarConexaoToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  fecharToolStripMenuItem;

	private: System::Windows::Forms::ToolStripMenuItem^  configurarECfToolStripMenuItem;
	private: System::Windows::Forms::TabPage^  TbECF;
	private: System::Windows::Forms::PropertyGrid^  prpG;
	private: Megasoft::TabControl^  tabControl1;












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
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(Form1::typeid));
			this->megasoftStatusStrip1 = (gcnew Megasoft::MegasoftStatusStrip());
			this->BtECF = (gcnew System::Windows::Forms::ToolStripDropDownButton());
			this->configurarConexaoToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->configurarECfToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->fecharToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->TbECF = (gcnew System::Windows::Forms::TabPage());
			this->tabControl1 = (gcnew Megasoft::TabControl());
			this->prpG = (gcnew System::Windows::Forms::PropertyGrid());
			this->megasoftStatusStrip1->SuspendLayout();
			this->TbECF->SuspendLayout();
			this->tabControl1->SuspendLayout();
			this->SuspendLayout();
			// 
			// megasoftStatusStrip1
			// 
			this->megasoftStatusStrip1->Autor = nullptr;
			this->megasoftStatusStrip1->BackColor = System::Drawing::Color::Transparent;
			this->megasoftStatusStrip1->BaseColor = System::Drawing::Color::SteelBlue;
			this->megasoftStatusStrip1->ButtonColor = System::Drawing::SystemColors::Desktop;
			this->megasoftStatusStrip1->ButtonText = nullptr;
			this->megasoftStatusStrip1->ImageScalingSize = System::Drawing::Size(32, 32);
			this->megasoftStatusStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) {this->BtECF});
			this->megasoftStatusStrip1->Location = System::Drawing::Point(0, 470);
			this->megasoftStatusStrip1->Name = L"megasoftStatusStrip1";
			this->megasoftStatusStrip1->Size = System::Drawing::Size(510, 38);
			this->megasoftStatusStrip1->TabIndex = 1;
			this->megasoftStatusStrip1->Text = L"megasoftStatusStrip1";
			// 
			// BtECF
			// 
			this->BtECF->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(3) {this->configurarConexaoToolStripMenuItem, 
				this->configurarECfToolStripMenuItem, this->fecharToolStripMenuItem});
			this->BtECF->Font = (gcnew System::Drawing::Font(L"Tahoma", 8.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point, 
				static_cast<System::Byte>(0)));
			this->BtECF->ForeColor = System::Drawing::Color::White;
			this->BtECF->Image = (cli::safe_cast<System::Drawing::Image^  >(resources->GetObject(L"BtECF.Image")));
			this->BtECF->ImageTransparentColor = System::Drawing::Color::Magenta;
			this->BtECF->Name = L"BtECF";
			this->BtECF->Size = System::Drawing::Size(83, 36);
			this->BtECF->Text = L"Menu";
			// 
			// configurarConexaoToolStripMenuItem
			// 
			this->configurarConexaoToolStripMenuItem->BackColor = System::Drawing::Color::SteelBlue;
			this->configurarConexaoToolStripMenuItem->ForeColor = System::Drawing::Color::White;
			this->configurarConexaoToolStripMenuItem->Name = L"configurarConexaoToolStripMenuItem";
			this->configurarConexaoToolStripMenuItem->Size = System::Drawing::Size(185, 22);
			this->configurarConexaoToolStripMenuItem->Text = L"Configurar Conexao";
			this->configurarConexaoToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::configurarConexaoToolStripMenuItem_Click);
			// 
			// configurarECfToolStripMenuItem
			// 
			this->configurarECfToolStripMenuItem->BackColor = System::Drawing::Color::SteelBlue;
			this->configurarECfToolStripMenuItem->ForeColor = System::Drawing::Color::White;
			this->configurarECfToolStripMenuItem->Name = L"configurarECfToolStripMenuItem";
			this->configurarECfToolStripMenuItem->Size = System::Drawing::Size(185, 22);
			this->configurarECfToolStripMenuItem->Text = L"Configurar ECF";
			this->configurarECfToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::configurarECfToolStripMenuItem_Click);
			// 
			// fecharToolStripMenuItem
			// 
			this->fecharToolStripMenuItem->BackColor = System::Drawing::Color::SteelBlue;
			this->fecharToolStripMenuItem->ForeColor = System::Drawing::Color::White;
			this->fecharToolStripMenuItem->Name = L"fecharToolStripMenuItem";
			this->fecharToolStripMenuItem->Size = System::Drawing::Size(185, 22);
			this->fecharToolStripMenuItem->Text = L"Fechar";
			this->fecharToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::fecharToolStripMenuItem_Click);
			// 
			// TbECF
			// 
			this->TbECF->BackColor = System::Drawing::Color::White;
			this->TbECF->Controls->Add(this->prpG);
			this->TbECF->ForeColor = System::Drawing::Color::SteelBlue;
			this->TbECF->Location = System::Drawing::Point(4, 25);
			this->TbECF->Name = L"TbECF";
			this->TbECF->Padding = System::Windows::Forms::Padding(3);
			this->TbECF->Size = System::Drawing::Size(502, 441);
			this->TbECF->TabIndex = 0;
			this->TbECF->Text = L"tabPage1";
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
			this->tabControl1->Size = System::Drawing::Size(510, 470);
			this->tabControl1->TabIndex = 5;
			// 
			// prpG
			// 
			this->prpG->Dock = System::Windows::Forms::DockStyle::Fill;
			this->prpG->Location = System::Drawing::Point(3, 3);
			this->prpG->Name = L"prpG";
			this->prpG->Size = System::Drawing::Size(496, 435);
			this->prpG->TabIndex = 4;
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::Color::White;
			this->ClientSize = System::Drawing::Size(510, 508);
			this->ControlBox = false;
			this->Controls->Add(this->tabControl1);
			this->Controls->Add(this->megasoftStatusStrip1);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedSingle;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^  >(resources->GetObject(L"$this.Icon")));
			this->MaximizeBox = false;
			this->MinimizeBox = false;
			this->Name = L"Form1";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->Shown += gcnew System::EventHandler(this, &Form1::Form1_Shown);
			this->megasoftStatusStrip1->ResumeLayout(false);
			this->megasoftStatusStrip1->PerformLayout();
			this->TbECF->ResumeLayout(false);
			this->tabControl1->ResumeLayout(false);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void Form1_Shown(System::Object^  sender, System::EventArgs^  e) {
				 try
				 {

				 }
				 catch(Exception^ex)
				 {
					 MessageBox::Show(ex->Message,"Erro",MessageBoxButtons::OK, MessageBoxIcon::Error);
				 }
			 }


private: System::Void configurarConexaoToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
			 Realsoft_ConfigurarConexao ^Configura = gcnew Realsoft_ConfigurarConexao();
			 Configura->ShowDialog();
		 }
private: System::Void fecharToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {

			 Application::Exit();

		 }

private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {
			 try
			 {
				 Realsoft_Propriedade ^Propert = gcnew Realsoft_Propriedade();
				 prpG->SelectedObject = Propert;
			 }
			 catch(Exception ^ex)
			 {
				 MessageBox::Show(ex->Message,"Error",MessageBoxButtons::OK, MessageBoxIcon::Error);
			 }
		 }
private: System::Void configurarECfToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) {
			 Form2 ^ECF = gcnew Form2();
			 ECF->ShowDialog();
		 }
};
}

