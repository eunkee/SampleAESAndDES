
namespace SampleAESAndDES
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxEncryptionData = new System.Windows.Forms.TextBox();
            this.TextBoxData = new System.Windows.Forms.TextBox();
            this.TextBoxDecryptionData = new System.Windows.Forms.TextBox();
            this.radioButtonAES = new System.Windows.Forms.RadioButton();
            this.radioButtonDES = new System.Windows.Forms.RadioButton();
            this.ButtonEncryption = new System.Windows.Forms.Button();
            this.ButtonDecryption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxEncryptionData
            // 
            this.TextBoxEncryptionData.Location = new System.Drawing.Point(1, 93);
            this.TextBoxEncryptionData.Multiline = true;
            this.TextBoxEncryptionData.Name = "TextBoxEncryptionData";
            this.TextBoxEncryptionData.ReadOnly = true;
            this.TextBoxEncryptionData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxEncryptionData.Size = new System.Drawing.Size(370, 215);
            this.TextBoxEncryptionData.TabIndex = 0;
            // 
            // TextBoxData
            // 
            this.TextBoxData.Location = new System.Drawing.Point(1, 35);
            this.TextBoxData.Name = "TextBoxData";
            this.TextBoxData.Size = new System.Drawing.Size(370, 23);
            this.TextBoxData.TabIndex = 1;
            // 
            // TextBoxDecryptionData
            // 
            this.TextBoxDecryptionData.Location = new System.Drawing.Point(1, 343);
            this.TextBoxDecryptionData.Name = "TextBoxDecryptionData";
            this.TextBoxDecryptionData.Size = new System.Drawing.Size(370, 23);
            this.TextBoxDecryptionData.TabIndex = 2;
            // 
            // radioButtonAES
            // 
            this.radioButtonAES.AutoSize = true;
            this.radioButtonAES.Location = new System.Drawing.Point(11, 8);
            this.radioButtonAES.Name = "radioButtonAES";
            this.radioButtonAES.Size = new System.Drawing.Size(46, 19);
            this.radioButtonAES.TabIndex = 3;
            this.radioButtonAES.TabStop = true;
            this.radioButtonAES.Text = "AES";
            this.radioButtonAES.UseVisualStyleBackColor = true;
            this.radioButtonAES.CheckedChanged += new System.EventHandler(this.RadioButtonAES_CheckedChanged);
            // 
            // radioButtonDES
            // 
            this.radioButtonDES.AutoSize = true;
            this.radioButtonDES.Location = new System.Drawing.Point(63, 8);
            this.radioButtonDES.Name = "radioButtonDES";
            this.radioButtonDES.Size = new System.Drawing.Size(47, 19);
            this.radioButtonDES.TabIndex = 4;
            this.radioButtonDES.TabStop = true;
            this.radioButtonDES.Text = "DES";
            this.radioButtonDES.UseVisualStyleBackColor = true;
            this.radioButtonDES.CheckedChanged += new System.EventHandler(this.RadioButtonDES_CheckedChanged);
            // 
            // ButtonEncryption
            // 
            this.ButtonEncryption.Location = new System.Drawing.Point(148, 64);
            this.ButtonEncryption.Name = "ButtonEncryption";
            this.ButtonEncryption.Size = new System.Drawing.Size(75, 23);
            this.ButtonEncryption.TabIndex = 5;
            this.ButtonEncryption.Text = "Encryption";
            this.ButtonEncryption.UseVisualStyleBackColor = true;
            this.ButtonEncryption.Click += new System.EventHandler(this.ButtonEncryption_Click);
            // 
            // ButtonDecryption
            // 
            this.ButtonDecryption.Location = new System.Drawing.Point(148, 314);
            this.ButtonDecryption.Name = "ButtonDecryption";
            this.ButtonDecryption.Size = new System.Drawing.Size(75, 23);
            this.ButtonDecryption.TabIndex = 6;
            this.ButtonDecryption.Text = "Decryption";
            this.ButtonDecryption.UseVisualStyleBackColor = true;
            this.ButtonDecryption.Click += new System.EventHandler(this.ButtonDecryption_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 374);
            this.Controls.Add(this.ButtonDecryption);
            this.Controls.Add(this.ButtonEncryption);
            this.Controls.Add(this.radioButtonDES);
            this.Controls.Add(this.radioButtonAES);
            this.Controls.Add(this.TextBoxDecryptionData);
            this.Controls.Add(this.TextBoxData);
            this.Controls.Add(this.TextBoxEncryptionData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sample AES & DES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEncryptionData;
        private System.Windows.Forms.TextBox TextBoxData;
        private System.Windows.Forms.TextBox TextBoxDecryptionData;
        private System.Windows.Forms.RadioButton radioButtonAES;
        private System.Windows.Forms.RadioButton radioButtonDES;
        private System.Windows.Forms.Button ButtonEncryption;
        private System.Windows.Forms.Button ButtonDecryption;
    }
}

