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
            this.confirmButton = new System.Windows.Forms.Button();
            this.dragLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VITextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(95, 357);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(257, 58);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // dragLabel
            // 
            this.dragLabel.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragLabel.Location = new System.Drawing.Point(98, 23);
            this.dragLabel.Name = "dragLabel";
            this.dragLabel.Size = new System.Drawing.Size(254, 42);
            this.dragLabel.TabIndex = 11;
            this.dragLabel.Text = "Enter the key";
            this.dragLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(50, 103);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(349, 68);
            this.keyTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter the VI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VITextBox
            // 
            this.VITextBox.Location = new System.Drawing.Point(50, 258);
            this.VITextBox.Multiline = true;
            this.VITextBox.Name = "VITextBox";
            this.VITextBox.Size = new System.Drawing.Size(349, 68);
            this.VITextBox.TabIndex = 14;
            // 
            // KeyEnterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 459);
            this.Controls.Add(this.VITextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dragLabel);
            this.Controls.Add(this.keyTextBox);
            this.Name = "KeyEnterFrm";
            this.Text = "KeyEnterFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label dragLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VITextBox;
    }
}