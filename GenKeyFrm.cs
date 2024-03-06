using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace AES__enc_GUI
{
    public partial class GenKeyFrm : Form
    {
        Form1 frm1;
        public GenKeyFrm(Form1 frm1)
        {
            this.frm1 = frm1;
            InitializeComponent();
        }
        // Создание ключа на нажатие кнопки
        private void genKeyButton_Click(object sender, EventArgs e)
        {
            this.frm1.aes.GenerateKey();
            keyTextBox.Text = Convert.ToBase64String(this.frm1.aes.Key);
        }
        // Создание вектора на нажатие кнопки
        private void VIGenButton_Click(object sender, EventArgs e)
        {
            this.frm1.aes.GenerateIV();
            VITextBox.Text = Convert.ToBase64String(this.frm1.aes.IV);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Если ключи пустой - ошибка
            if (keyTextBox.Text == "")
            {
                MessageBox.Show("A key was not generated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Выбор локации где сохранить ключ
            MessageBox.Show("Choose the location where to store the key");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            // Два формата - Все, .txt
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            // Если все в порядке - создается файл ключа
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Запись данных ключа
                string text = "*DO NOT OVERWRITE THE FILE!*\n";
                text += "Key->";
                text += keyTextBox.Text + "<-Key\n";
                text += "Initialization vector->";
                text += VITextBox.Text + "<-Initialization vector";
                
                File.WriteAllText(saveFileDialog1.FileName, text);
                
                frm1.EncryptFiles();
                this.Close();
            }
        }

        
    }
}
