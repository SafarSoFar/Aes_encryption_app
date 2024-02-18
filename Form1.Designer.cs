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
            dragList = new ListBox();
            appLabel = new Label();
            dragLabel = new Label();
            encButton = new Button();
            decButton = new Button();
            memeButton = new Label();
            clearButton = new Button();
            SuspendLayout();
            // 
            // dragList
            // 
            dragList.AllowDrop = true;
            dragList.FormattingEnabled = true;
            dragList.Location = new Point(47, 215);
            dragList.Margin = new Padding(3, 4, 3, 4);
            dragList.Name = "dragList";
            dragList.Size = new Size(583, 144);
            dragList.TabIndex = 0;
            dragList.DragDrop += dragList_DragDrop;
            dragList.DragEnter += dragList_DragEnter;
            // 
            // appLabel
            // 
            appLabel.Font = new Font("Yu Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appLabel.Location = new Point(169, 9);
            appLabel.Name = "appLabel";
            appLabel.Size = new Size(353, 141);
            appLabel.TabIndex = 1;
            appLabel.Text = "AES Encryption";
            appLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dragLabel
            // 
            dragLabel.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dragLabel.Location = new Point(33, 159);
            dragLabel.Name = "dragLabel";
            dragLabel.Size = new Size(254, 52);
            dragLabel.TabIndex = 2;
            dragLabel.Text = "Drag And Drop files here:";
            dragLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // encButton
            // 
            encButton.Location = new Point(47, 480);
            encButton.Margin = new Padding(3, 4, 3, 4);
            encButton.Name = "encButton";
            encButton.Size = new Size(240, 59);
            encButton.TabIndex = 5;
            encButton.Text = "Encrypt files";
            encButton.UseVisualStyleBackColor = true;
            encButton.Click += encButton_Click;
            // 
            // decButton
            // 
            decButton.Location = new Point(390, 480);
            decButton.Margin = new Padding(3, 4, 3, 4);
            decButton.Name = "decButton";
            decButton.Size = new Size(240, 59);
            decButton.TabIndex = 6;
            decButton.Text = "Decrypt files";
            decButton.UseVisualStyleBackColor = true;
            decButton.Click += decButton_Click;
            // 
            // memeButton
            // 
            memeButton.Font = new Font("Yu Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            memeButton.ForeColor = SystemColors.Control;
            memeButton.Location = new Point(-67, 543);
            memeButton.Name = "memeButton";
            memeButton.Size = new Size(254, 41);
            memeButton.TabIndex = 7;
            memeButton.Text = "Easter egg";
            memeButton.TextAlign = ContentAlignment.MiddleCenter;
            memeButton.Click += memeButton_Click;
            memeButton.MouseEnter += memeButton_MouseEnter;
            memeButton.MouseLeave += memeButton_MouseLeave;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(47, 381);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(583, 56);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear the list";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 585);
            Controls.Add(clearButton);
            Controls.Add(memeButton);
            Controls.Add(decButton);
            Controls.Add(encButton);
            Controls.Add(dragLabel);
            Controls.Add(appLabel);
            Controls.Add(dragList);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox dragList;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.Label dragLabel;
        private System.Windows.Forms.Button encButton;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.Label memeButton;
        private System.Windows.Forms.Button clearButton;
    }
}

