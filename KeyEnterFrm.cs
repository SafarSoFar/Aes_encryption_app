using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES__enc_GUI
{
    public partial class KeyEnterFrm : Form
    {
        Form1 frm1;
        public KeyEnterFrm(Form1 frm1)
        {
            this.frm1 = frm1;
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(keyTextBox.Text.Length == 0 )
            {
                MessageBox.Show("Please,enter the key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frm1.aes.Key = Encoding.UTF8.GetBytes(keyTextBox.Text);
            //MessageBox.Show(", "Error", MessageBoxButtons.OK);
        }

        
    }
}
