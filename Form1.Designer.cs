namespace AES__enc_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dragList = new System.Windows.Forms.ListBox();
            this.appLabel = new System.Windows.Forms.Label();
            this.dragLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.genButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dragList
            // 
            this.dragList.AllowDrop = true;
            this.dragList.FormattingEnabled = true;
            this.dragList.ItemHeight = 16;
            this.dragList.Location = new System.Drawing.Point(47, 172);
            this.dragList.Name = "dragList";
            this.dragList.Size = new System.Drawing.Size(420, 116);
            this.dragList.TabIndex = 0;
            this.dragList.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragList_DragDrop);
            this.dragList.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragList_DragEnter);
            // 
            // appLabel
            // 
            this.appLabel.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appLabel.Location = new System.Drawing.Point(12, 9);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(353, 113);
            this.appLabel.TabIndex = 1;
            this.appLabel.Text = "AES Encryption";
            this.appLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dragLabel
            // 
            this.dragLabel.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragLabel.Location = new System.Drawing.Point(33, 127);
            this.dragLabel.Name = "dragLabel";
            this.dragLabel.Size = new System.Drawing.Size(254, 42);
            this.dragLabel.TabIndex = 2;
            this.dragLabel.Text = "Drag And Drop files here:";
            this.dragLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(517, 172);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 116);
            this.textBox1.TabIndex = 3;
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(517, 105);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(257, 48);
            this.genButton.TabIndex = 4;
            this.genButton.Text = "Generate key";
            this.genButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate key";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dragLabel);
            this.Controls.Add(this.appLabel);
            this.Controls.Add(this.dragList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dragList;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.Label dragLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.Button button1;
    }
}

