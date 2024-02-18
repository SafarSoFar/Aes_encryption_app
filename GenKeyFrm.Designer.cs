namespace AES__enc_GUI
{
    partial class GenKeyFrm
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
            genButton = new Button();
            keyTextBox = new TextBox();
            dragLabel = new Label();
            confirmButton = new Button();
            VITextBox = new TextBox();
            VIGenButton = new Button();
            SuspendLayout();
            // 
            // genButton
            // 
            genButton.Location = new Point(78, 205);
            genButton.Margin = new Padding(3, 4, 3, 4);
            genButton.Name = "genButton";
            genButton.Size = new Size(266, 48);
            genButton.TabIndex = 6;
            genButton.Text = "Generate key";
            genButton.UseVisualStyleBackColor = true;
            genButton.Click += genButton_Click;
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(33, 102);
            keyTextBox.Margin = new Padding(3, 4, 3, 4);
            keyTextBox.Multiline = true;
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(349, 84);
            keyTextBox.TabIndex = 5;
            // 
            // dragLabel
            // 
            dragLabel.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dragLabel.Location = new Point(90, 28);
            dragLabel.Name = "dragLabel";
            dragLabel.Size = new Size(254, 52);
            dragLabel.TabIndex = 7;
            dragLabel.Text = "Key generation";
            dragLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(78, 449);
            confirmButton.Margin = new Padding(3, 4, 3, 4);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(266, 38);
            confirmButton.TabIndex = 8;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // VITextBox
            // 
            VITextBox.Location = new Point(33, 278);
            VITextBox.Margin = new Padding(3, 4, 3, 4);
            VITextBox.Multiline = true;
            VITextBox.Name = "VITextBox";
            VITextBox.Size = new Size(349, 84);
            VITextBox.TabIndex = 9;
            // 
            // VIGenButton
            // 
            VIGenButton.Location = new Point(78, 380);
            VIGenButton.Margin = new Padding(3, 4, 3, 4);
            VIGenButton.Name = "VIGenButton";
            VIGenButton.Size = new Size(266, 48);
            VIGenButton.TabIndex = 10;
            VIGenButton.Text = "Generate initialization vector";
            VIGenButton.UseVisualStyleBackColor = true;
            VIGenButton.Click += VIGenButton_Click;
            // 
            // GenKeyFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 514);
            Controls.Add(VIGenButton);
            Controls.Add(VITextBox);
            Controls.Add(confirmButton);
            Controls.Add(dragLabel);
            Controls.Add(genButton);
            Controls.Add(keyTextBox);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GenKeyFrm";
            Text = "GenKeyFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label dragLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox VITextBox;
        private System.Windows.Forms.Button VIGenButton;
    }
}