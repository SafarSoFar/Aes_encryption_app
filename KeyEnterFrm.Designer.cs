namespace AES__enc_GUI
{
    partial class KeyEnterFrm
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
            confirmButton = new Button();
            dragLabel = new Label();
            keyTextBox = new TextBox();
            label1 = new Label();
            VITextBox = new TextBox();
            SuspendLayout();
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(95, 359);
            confirmButton.Margin = new Padding(3, 4, 3, 4);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(257, 45);
            confirmButton.TabIndex = 12;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // dragLabel
            // 
            dragLabel.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dragLabel.Location = new Point(98, 29);
            dragLabel.Name = "dragLabel";
            dragLabel.Size = new Size(254, 52);
            dragLabel.TabIndex = 11;
            dragLabel.Text = "Enter the key";
            dragLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(50, 85);
            keyTextBox.Margin = new Padding(3, 4, 3, 4);
            keyTextBox.Multiline = true;
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(349, 84);
            keyTextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 190);
            label1.Name = "label1";
            label1.Size = new Size(254, 52);
            label1.TabIndex = 13;
            label1.Text = "Enter the VI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VITextBox
            // 
            VITextBox.Location = new Point(50, 246);
            VITextBox.Margin = new Padding(3, 4, 3, 4);
            VITextBox.Multiline = true;
            VITextBox.Name = "VITextBox";
            VITextBox.Size = new Size(349, 84);
            VITextBox.TabIndex = 14;
            // 
            // KeyEnterFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 429);
            Controls.Add(VITextBox);
            Controls.Add(label1);
            Controls.Add(confirmButton);
            Controls.Add(dragLabel);
            Controls.Add(keyTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KeyEnterFrm";
            Text = "KeyEnterFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label dragLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VITextBox;
    }
}