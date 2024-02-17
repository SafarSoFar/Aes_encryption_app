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
            this.encButton = new System.Windows.Forms.Button();
            this.decButton = new System.Windows.Forms.Button();
            this.memeButton = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dragList
            // 
            this.dragList.AllowDrop = true;
            this.dragList.FormattingEnabled = true;
            this.dragList.ItemHeight = 16;
            this.dragList.Location = new System.Drawing.Point(47, 172);
            this.dragList.Name = "dragList";
            this.dragList.Size = new System.Drawing.Size(641, 116);
            this.dragList.TabIndex = 0;
            this.dragList.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragList_DragDrop);
            this.dragList.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragList_DragEnter);
            // 
            // appLabel
            // 
            this.appLabel.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appLabel.Location = new System.Drawing.Point(208, 9);
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
            // encButton
            // 
            this.encButton.Location = new System.Drawing.Point(47, 384);
            this.encButton.Name = "encButton";
            this.encButton.Size = new System.Drawing.Size(273, 66);
            this.encButton.TabIndex = 5;
            this.encButton.Text = "Encrypt files";
            this.encButton.UseVisualStyleBackColor = true;
            this.encButton.Click += new System.EventHandler(this.encButton_Click);
            // 
            // decButton
            // 
            this.decButton.Location = new System.Drawing.Point(415, 384);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(273, 66);
            this.decButton.TabIndex = 6;
            this.decButton.Text = "Decrypt files";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // memeButton
            // 
            this.memeButton.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.memeButton.Location = new System.Drawing.Point(-3, 471);
            this.memeButton.Name = "memeButton";
            this.memeButton.Size = new System.Drawing.Size(254, 33);
            this.memeButton.TabIndex = 7;
            this.memeButton.Text = "Easter egg";
            this.memeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.memeButton.Click += new System.EventHandler(this.memeButton_Click);
            this.memeButton.MouseEnter += new System.EventHandler(this.memeButton_MouseEnter);
            this.memeButton.MouseLeave += new System.EventHandler(this.memeButton_MouseLeave);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(47, 305);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(641, 45);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear the list";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 513);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.memeButton);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.encButton);
            this.Controls.Add(this.dragLabel);
            this.Controls.Add(this.appLabel);
            this.Controls.Add(this.dragList);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

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

