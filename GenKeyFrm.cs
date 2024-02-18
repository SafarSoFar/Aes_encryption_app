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

        private void genButton_Click(object sender, EventArgs e)
        {
            this.frm1.aes.GenerateKey();
            this.frm1.aes.GenerateIV();
            keyTextBox.Text = BitConverter.ToString(this.frm1.aes.Key);
        }
        private void VIGenButton_Click(object sender, EventArgs e)
        {
            this.frm1.aes.GenerateIV();
            VITextBox.Text = BitConverter.ToString(this.frm1.aes.IV);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(keyTextBox.Text == "")
            {
                MessageBox.Show("A key was not generated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            MessageBox.Show("Choose the location where to store the key");
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Write(frm1.aes.Key,0,frm1.aes.Key.Length);
                    myStream.Close();
                }
                frm1.EncryptFiles();
                this.Close();
            }
        }

    }
}
