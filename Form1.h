#pragma once
#include<vector>
#include"Form2.h"
namespace CppCLRWinFormsProject {

	using namespace System;
	using namespace System::IO;
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
	private: System::Windows::Forms::Label^ app_name;
	private: System::Windows::Forms::ListBox^ drag_list;

	private: System::Windows::Forms::Label^ drop_label;
	private: System::Windows::Forms::TextBox^ key_textBox;

	private: System::Windows::Forms::Label^ key_label;
	private: System::Windows::Forms::Button^ generate_label;

	private: System::Windows::Forms::Button^ enc_button;
	private: System::Windows::Forms::Button^ dec_button;
	private: System::Windows::Forms::Label^ event_label;
	private: System::Windows::Forms::Button^ clear_button;
	private: System::Windows::Forms::Label^ easter_egg_button;
	//private: std::vector<std::string> paths;



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
			this->app_name = (gcnew System::Windows::Forms::Label());
			this->drag_list = (gcnew System::Windows::Forms::ListBox());
			this->drop_label = (gcnew System::Windows::Forms::Label());
			this->key_textBox = (gcnew System::Windows::Forms::TextBox());
			this->key_label = (gcnew System::Windows::Forms::Label());
			this->generate_label = (gcnew System::Windows::Forms::Button());
			this->enc_button = (gcnew System::Windows::Forms::Button());
			this->dec_button = (gcnew System::Windows::Forms::Button());
			this->event_label = (gcnew System::Windows::Forms::Label());
			this->clear_button = (gcnew System::Windows::Forms::Button());
			this->easter_egg_button = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// app_name
			// 
			this->app_name->Anchor = System::Windows::Forms::AnchorStyles::Top;
			this->app_name->Font = (gcnew System::Drawing::Font(L"Impact", 22.2F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->app_name->Location = System::Drawing::Point(223, 21);
			this->app_name->Name = L"app_name";
			this->app_name->Size = System::Drawing::Size(269, 53);
			this->app_name->TabIndex = 0;
			this->app_name->Text = L"AES Encryption";
			this->app_name->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// drag_list
			// 
			this->drag_list->AllowDrop = true;
			this->drag_list->BackColor = System::Drawing::Color::LightGray;
			this->drag_list->FormattingEnabled = true;
			this->drag_list->ItemHeight = 16;
			this->drag_list->Location = System::Drawing::Point(12, 175);
			this->drag_list->Name = L"drag_list";
			this->drag_list->Size = System::Drawing::Size(288, 164);
			this->drag_list->TabIndex = 1;
			this->drag_list->DragDrop += gcnew System::Windows::Forms::DragEventHandler(this, &Form1::drag_list_DragDrop);
			this->drag_list->DragEnter += gcnew System::Windows::Forms::DragEventHandler(this, &Form1::drag_list_DragEnter);
			// 
			// drop_label
			// 
			this->drop_label->Anchor = System::Windows::Forms::AnchorStyles::Top;
			this->drop_label->Font = (gcnew System::Drawing::Font(L"Impact", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->drop_label->Location = System::Drawing::Point(21, 119);
			this->drop_label->Name = L"drop_label";
			this->drop_label->Size = System::Drawing::Size(269, 53);
			this->drop_label->TabIndex = 2;
			this->drop_label->Text = L"Drop files here";
			this->drop_label->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// key_textBox
			// 
			this->key_textBox->BackColor = System::Drawing::Color::LightGray;
			this->key_textBox->Location = System::Drawing::Point(387, 175);
			this->key_textBox->Multiline = true;
			this->key_textBox->Name = L"key_textBox";
			this->key_textBox->Size = System::Drawing::Size(282, 65);
			this->key_textBox->TabIndex = 3;
			// 
			// key_label
			// 
			this->key_label->Anchor = System::Windows::Forms::AnchorStyles::Top;
			this->key_label->Font = (gcnew System::Drawing::Font(L"Impact", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->key_label->Location = System::Drawing::Point(391, 119);
			this->key_label->Name = L"key_label";
			this->key_label->Size = System::Drawing::Size(278, 53);
			this->key_label->TabIndex = 4;
			this->key_label->Text = L"Enter a key (or generate)";
			this->key_label->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// generate_label
			// 
			this->generate_label->Location = System::Drawing::Point(387, 274);
			this->generate_label->Name = L"generate_label";
			this->generate_label->Size = System::Drawing::Size(282, 47);
			this->generate_label->TabIndex = 5;
			this->generate_label->Text = L"Generate random key";
			this->generate_label->UseVisualStyleBackColor = true;
			// 
			// enc_button
			// 
			this->enc_button->Location = System::Drawing::Point(303, 376);
			this->enc_button->Name = L"enc_button";
			this->enc_button->Size = System::Drawing::Size(171, 78);
			this->enc_button->TabIndex = 7;
			this->enc_button->Text = L"Encrypt file";
			this->enc_button->UseVisualStyleBackColor = true;
			this->enc_button->Click += gcnew System::EventHandler(this, &Form1::enc_button_Click);
			// 
			// dec_button
			// 
			this->dec_button->Location = System::Drawing::Point(521, 376);
			this->dec_button->Name = L"dec_button";
			this->dec_button->Size = System::Drawing::Size(171, 78);
			this->dec_button->TabIndex = 8;
			this->dec_button->Text = L"Decrypt file";
			this->dec_button->UseVisualStyleBackColor = true;
			this->dec_button->Click += gcnew System::EventHandler(this, &Form1::dec_button_Click);
			// 
			// event_label
			// 
			this->event_label->Anchor = System::Windows::Forms::AnchorStyles::Top;
			this->event_label->Font = (gcnew System::Drawing::Font(L"Impact", 10.8F, System::Drawing::FontStyle::Italic, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->event_label->Location = System::Drawing::Point(-52, 21);
			this->event_label->Name = L"event_label";
			this->event_label->Size = System::Drawing::Size(269, 53);
			this->event_label->TabIndex = 9;
			this->event_label->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// clear_button
			// 
			this->clear_button->Location = System::Drawing::Point(12, 357);
			this->clear_button->Name = L"clear_button";
			this->clear_button->Size = System::Drawing::Size(171, 47);
			this->clear_button->TabIndex = 10;
			this->clear_button->Text = L"Clear the list";
			this->clear_button->UseVisualStyleBackColor = true;
			this->clear_button->Click += gcnew System::EventHandler(this, &Form1::clear_button_Click);
			// 
			// easter_egg_button
			// 
			this->easter_egg_button->Anchor = System::Windows::Forms::AnchorStyles::Top;
			this->easter_egg_button->Font = (gcnew System::Drawing::Font(L"Impact", 10.8F, System::Drawing::FontStyle::Italic, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->easter_egg_button->ForeColor = System::Drawing::Color::Bisque;
			this->easter_egg_button->Location = System::Drawing::Point(8, 467);
			this->easter_egg_button->Name = L"easter_egg_button";
			this->easter_egg_button->Size = System::Drawing::Size(139, 20);
			this->easter_egg_button->TabIndex = 11;
			this->easter_egg_button->Text = L"Easter egg";
			this->easter_egg_button->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			this->easter_egg_button->Click += gcnew System::EventHandler(this, &Form1::easter_egg_button_Click);
			this->easter_egg_button->MouseEnter += gcnew System::EventHandler(this, &Form1::easter_egg_button_MouseEnter);
			this->easter_egg_button->MouseLeave += gcnew System::EventHandler(this, &Form1::easter_egg_button_MouseLeave);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::Color::Bisque;
			this->ClientSize = System::Drawing::Size(717, 496);
			this->Controls->Add(this->easter_egg_button);
			this->Controls->Add(this->clear_button);
			this->Controls->Add(this->event_label);
			this->Controls->Add(this->dec_button);
			this->Controls->Add(this->enc_button);
			this->Controls->Add(this->generate_label);
			this->Controls->Add(this->key_label);
			this->Controls->Add(this->key_textBox);
			this->Controls->Add(this->drop_label);
			this->Controls->Add(this->drag_list);
			this->Controls->Add(this->app_name);
			this->ForeColor = System::Drawing::SystemColors::ControlText;
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::Fixed3D;
			this->Name = L"Form1";
			this->Text = L"AES Encryption";
			this->TransparencyKey = System::Drawing::SystemColors::ActiveBorder;
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	
		private: System::Void enc_button_Click(System::Object^ sender, System::EventArgs^ e) {
			event_label->Text = "Files Encrypted!";
			int len = drag_list->Items->Count;
			for (int i = 0; i < len; i++) {
				
				//std::fstream fps, fpt;
				String^ filePath = this->drag_list->Items[i]->ToString();
				//MessageBox::Show(tmp_str);
				//char* fileName = (char*)Marshal::StringToHGlobalAnsi(tmp_str).ToPointer();						
				//try
				//{
					//FileStream^ fs = gcnew FileStream(filePath, FileMode::Open);
					/*StreamReader^ sr = File::OpenText(filePath);
					
					String^ str;
					while ((str = sr->ReadLine()) != nullptr)
					{
						MessageBox::Show(str);
					}*/

					/*FileSource fs1(fileName, true,
						new DefaultEncryptorWithMAC(
							(byte*)&password[0], password.size(),
							new HexEncoder(
								new StringSink(encrypted)
							)
						)
					);*/

				}
				/*catch (Exception^ e)
				{
					if (dynamic_cast<FileNotFoundException^>(e))
						Console::WriteLine("file '{0}' not found", filePath);
					else
						Console::WriteLine("problem reading file '{0}'", filePath);
				}
				String^ key = key_textBox->Text;
				String^ encrypted;*/
				
				//cout << "Password (authentication tag): " << password << endl;
				/*FileSource fs1(fileName, true,
					new DefaultEncryptorWithMAC(
						(byte*)&key[0], password.size(),
						new HexEncoder(
							new StringSink(encrypted)
						)
					)
				);*/

			//}
			//cout << "Enter the File name: ";
			//msclr::interop::marshal_as<std::string>(str);
			//cout << "Encrypted: \n\n" << encrypted << endl;



		}
		private: System::Void dec_button_Click(System::Object^ sender, System::EventArgs^ e) {
			event_label->Text = "Files Decrypted!";
		}
		private: System::Void drag_list_DragEnter(System::Object^ sender, System::Windows::Forms::DragEventArgs^ e) {
			if (e->Data->GetDataPresent(DataFormats::FileDrop)) {
				e->Effect = DragDropEffects::All;
			}
			else {
				e->Effect = DragDropEffects::None;
			}
		}
		private: System::Void drag_list_DragDrop(System::Object^ sender, System::Windows::Forms::DragEventArgs^ e) {
			array<String^>^data = (array<String^>^)e->Data->GetData(DataFormats::FileDrop, false);

			for (int i = 0; i < data->Length; i++) {
				drag_list->Items->Add(data[i]);
			}

		}
		private: System::Void clear_button_Click(System::Object^ sender, System::EventArgs^ e) {
			drag_list->Items->Clear();
			//Form2
			
		}
		private: System::Void easter_egg_button_MouseEnter(System::Object^ sender, System::EventArgs^ e) {
			this->easter_egg_button->ForeColor = System::Drawing::Color::Black;
		}
		private: System::Void easter_egg_button_MouseLeave(System::Object^ sender, System::EventArgs^ e) {
			this->easter_egg_button->ForeColor = System::Drawing::Color::Bisque;
		}
		private: System::Void easter_egg_button_Click(System::Object^ sender, System::EventArgs^ e) {
			Form2^ frm2 = gcnew Form2();
			frm2->Show();
		}
};
}
