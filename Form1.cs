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
    public partial class Form1 : Form
    {
        public Aes aes;
        GenKeyFrm genKeyFrm;
        KeyEnterFrm keyEnterFrm;
        public Form1()
        {
            InitializeComponent();
            aes = Aes.Create();
            aes.KeySize = 256;
            aes.Mode = CipherMode.CBC; 
        }

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

        private void dragList_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = ((string[])e.Data.GetData(DataFormats.FileDrop, false));

            for (int i = 0; i < data.Length; i++)
            {
                dragList.Items.Add(data[i]);
            }
        }

        /*private void genButton_Click(object sender, EventArgs e)
        {
            aes.GenerateKey();
            aes.GenerateIV();
            keyTextBox.Text = BitConverter.ToString(aes.Key);
        }*/

        private void encButton_Click(object sender, EventArgs e)
        {
            if (CheckItemsCount())
            {
                genKeyFrm = new GenKeyFrm(this);
                genKeyFrm.Show();

            }
            
        }

        private bool CheckItemsCount()
        {
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

        public void EncryptFiles()
        {
            genKeyFrm = null;
            ICryptoTransform encryptor = aes.CreateEncryptor();
            int len = dragList.Items.Count;
            for (int i = 0; i < len; i++)
            {
                string filePath = dragList.Items[i].ToString();
                string encFilePath = filePath;
                encFilePath = encFilePath.Substring(0, encFilePath.Length - 4);
                /*for(int j = curPath.Length-1; j > 0; j--)
                {
                    if (curPath[j] == '.')
                    {
                        curPath.Remove(curPath[j]);
                        break;
                    }
                    else
                        curPath.Remove(curPath[j]);
                }*/
                encFilePath += "_encrypted.txt";
                FileStream fs = File.Create(encFilePath);
                if (!File.Exists(encFilePath))
                {
                    MessageBox.Show("Invalid file path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fs.Flush();
                fs.Close();
                // Not explicit UTF-8 Decoding call, can cause problems mb
                byte[] plainText = File.ReadAllBytes(filePath);
                byte[] cipher = encryptor.TransformFinalBlock(plainText, 0, plainText.Length);
                File.WriteAllBytes(encFilePath, cipher);
            }
            MessageBox.Show("The files are encrypted");
            ClearList();
        }


        public void DecryptFiles(byte[] key, byte[] IV)
        {
            keyEnterFrm = null;
            ICryptoTransform decryptor = aes.CreateDecryptor(key, IV);
            int len = dragList.Items.Count;
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
