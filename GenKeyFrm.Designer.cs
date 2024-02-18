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
            this.genButton = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.dragLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.VITextBox = new System.Windows.Forms.TextBox();
            this.VIGenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(78, 165);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(257, 48);
            this.genButton.TabIndex = 6;
            this.genButton.Text = "Generate key";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(33, 82);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(349, 68);
            this.keyTextBox.TabIndex = 5;
            // 
            // dragLabel
            // 
            this.dragLabel.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragLabel.Location = new System.Drawing.Point(81, 19);
            this.dragLabel.Name = "dragLabel";
            this.dragLabel.Size = new System.Drawing.Size(254, 42);
            this.dragLabel.TabIndex = 7;
            this.dragLabel.Text = "Key generation";
            this.dragLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(131, 395);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(152, 62);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // VITextBox
            // 
            this.VITextBox.Location = new System.Drawing.Point(33, 228);
            this.VITextBox.Multiline = true;
            this.VITextBox.Name = "VITextBox";
            this.VITextBox.Size = new System.Drawing.Size(349, 68);
            this.VITextBox.TabIndex = 9;
            // 
            // VIGenButton
            // 
            this.VIGenButton.Location = new System.Drawing.Point(78, 315);
            this.VIGenButton.Name = "VIGenButton";
            this.VIGenButton.Size = new System.Drawing.Size(257, 48);
            this.VIGenButton.TabIndex = 10;
            this.VIGenButton.Text = "Generate initialization vector";
            this.VIGenButton.UseVisualStyleBackColor = true;
            this.VIGenButton.Click += new System.EventHandler(this.VIGenButton_Click);
            // 
            // GenKeyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 469);
            this.Controls.Add(this.VIGenButton);
            this.Controls.Add(this.VITextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dragLabel);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.keyTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenKeyFrm";
            this.Text = "GenKeyFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

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