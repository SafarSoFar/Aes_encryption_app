using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES__enc_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
