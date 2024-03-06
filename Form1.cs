using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Web;

namespace AES__enc_GUI
{
    // Создание Windows формы
    public partial class Form1 : Form
    {
        public Aes aes;
        GenKeyFrm genKeyFrm;
        KeyEnterFrm keyEnterFrm;
        public Form1()
        {
            // Создание АЕS объекта
            InitializeComponent();
            aes = Aes.Create();
            aes.KeySize = 256;
            aes.Mode = CipherMode.CBC; 
        }
        // Событие на перетаскивания файлов
        private void dragList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        // Добавление путей файлов в лист
        private void dragList_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = ((string[])e.Data.GetData(DataFormats.FileDrop, false));

            for (int i = 0; i < data.Length; i++)
            {
                dragList.Items.Add(data[i]);
            }
        }      

        // Открытие формы для создания ключа
        private void encButton_Click(object sender, EventArgs e)
        {
            if (CheckItemsCount())
            {
                genKeyFrm = new GenKeyFrm(this);
                genKeyFrm.Show();

            }
            
        }
        // Проверка количества элементов
        private bool CheckItemsCount()
        {
            // Если элементов нет - выдает ошибку
            if (dragList.Items.Count == 0)
            {
                MessageBox.Show("No files selected to encrypt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        // Само шифрование файлов используя сгенерированный ключ и вектор
        public void EncryptFiles()
        {
            genKeyFrm = null;
            ICryptoTransform encryptor = aes.CreateEncryptor();
            int len = dragList.Items.Count;
            // Цикл создания файлов
            for (int i = 0; i < len; i++)
            {
                string filePath = dragList.Items[i].ToString();
                string encFilePath = filePath;
                encFilePath = encFilePath.Substring(0, encFilePath.Length - 4);
            
                encFilePath += "_encrypted.txt";
                FileStream fs = File.Create(encFilePath);
                if (!File.Exists(encFilePath))
                {
                    MessageBox.Show("Invalid file path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fs.Flush();
                fs.Close();

                byte[] plainText = File.ReadAllBytes(filePath);
                byte[] cipher = encryptor.TransformFinalBlock(plainText, 0, plainText.Length);
                // Написание файлов с название "_encrypted" на конце
                File.WriteAllBytes(encFilePath, cipher);
            }
            MessageBox.Show("The files are encrypted");
            ClearList();
        }

        // Дешифровизация файлов
        public void DecryptFiles(byte[] key, byte[] IV)
        {
            keyEnterFrm = null;
            ICryptoTransform decryptor = aes.CreateDecryptor(key, IV);
            int len = dragList.Items.Count;
            // Цикл чтения файлов
            for (int i = 0; i < len; i++)
            {
                string curPath = dragList.Items[i].ToString();
                byte[] curCipherBytes = File.ReadAllBytes(curPath);
                byte[] plainTextBytes = decryptor.TransformFinalBlock(curCipherBytes, 0, curCipherBytes.Length);
                string plainText = Encoding.UTF8.GetString(plainTextBytes);
                File.WriteAllText(curPath, plainText);
            }
            MessageBox.Show("The files are decrypted");
            ClearList();
        }
        // Создание формы дешифровизации на нажатии кнопки
        private void decButton_Click(object sender, EventArgs e)
        {
            if (CheckItemsCount())
            {
                keyEnterFrm = new KeyEnterFrm(this);
                keyEnterFrm.Show();
            }
        }

        private void memeButton_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void memeButton_MouseEnter(object sender, EventArgs e)
        {
            memeButton.ForeColor = Color.Black;
        }

        private void memeButton_MouseLeave(object sender, EventArgs e)
        {
            memeButton.ForeColor = System.Drawing.SystemColors.Control;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        private void ClearList()
        {
            dragList.Items.Clear();

        }
    }
}
