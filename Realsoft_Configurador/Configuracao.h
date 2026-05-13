#pragma once

namespace Realsoft_Configurador {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Configuracao
	/// </summary>
	public ref class Configuracao : public System::Windows::Forms::Form
	{
	public:
		Configuracao(void)
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
		~Configuracao()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::PropertyGrid^  Propert;
	protected: 

	protected: 

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
			this->Propert = (gcnew System::Windows::Forms::PropertyGrid());
			this->SuspendLayout();
			// 
			// Propert
			// 
			this->Propert->Dock = System::Windows::Forms::DockStyle::Fill;
			this->Propert->Location = System::Drawing::Point(0, 0);
			this->Propert->Name = L"Propert";
			this->Propert->Size = System::Drawing::Size(403, 506);
			this->Propert->TabIndex = 0;
			// 
			// Configuracao
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(403, 506);
			this->Controls->Add(this->Propert);
			this->Name = L"Configuracao";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->Text = L"Configuracao do caixa";
			this->ResumeLayout(false);

		}
#pragma endregion
	};
}
