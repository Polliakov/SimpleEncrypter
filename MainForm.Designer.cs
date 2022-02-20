
namespace SimpleEncrypter
{
    partial class MainForm
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btEncryptRC4 = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btDecryptRC4 = new System.Windows.Forms.Button();
            this.btDecryptT = new System.Windows.Forms.Button();
            this.btEncryptT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(12, 12);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(776, 20);
            this.tbInput.TabIndex = 0;
            // 
            // btEncryptRC4
            // 
            this.btEncryptRC4.Location = new System.Drawing.Point(13, 123);
            this.btEncryptRC4.Name = "btEncryptRC4";
            this.btEncryptRC4.Size = new System.Drawing.Size(98, 23);
            this.btEncryptRC4.TabIndex = 1;
            this.btEncryptRC4.Text = "Encrypt RC4";
            this.btEncryptRC4.UseVisualStyleBackColor = true;
            this.btEncryptRC4.Click += new System.EventHandler(this.BtEncryptRC4_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput.Location = new System.Drawing.Point(12, 64);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(776, 20);
            this.tbOutput.TabIndex = 2;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(118, 125);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(246, 20);
            this.tbKey.TabIndex = 3;
            // 
            // btDecryptRC4
            // 
            this.btDecryptRC4.Location = new System.Drawing.Point(13, 152);
            this.btDecryptRC4.Name = "btDecryptRC4";
            this.btDecryptRC4.Size = new System.Drawing.Size(98, 23);
            this.btDecryptRC4.TabIndex = 4;
            this.btDecryptRC4.Text = "Decrypt RC4";
            this.btDecryptRC4.UseVisualStyleBackColor = true;
            this.btDecryptRC4.Click += new System.EventHandler(this.BtDecryptRC4_Click);
            // 
            // btDecryptT
            // 
            this.btDecryptT.Location = new System.Drawing.Point(13, 210);
            this.btDecryptT.Name = "btDecryptT";
            this.btDecryptT.Size = new System.Drawing.Size(98, 23);
            this.btDecryptT.TabIndex = 5;
            this.btDecryptT.Text = "Decrypt T";
            this.btDecryptT.UseVisualStyleBackColor = true;
            this.btDecryptT.Click += new System.EventHandler(this.btDecryptT_Click);
            // 
            // btEncryptT
            // 
            this.btEncryptT.Location = new System.Drawing.Point(13, 181);
            this.btEncryptT.Name = "btEncryptT";
            this.btEncryptT.Size = new System.Drawing.Size(98, 23);
            this.btEncryptT.TabIndex = 6;
            this.btEncryptT.Text = "Encrypt T";
            this.btEncryptT.UseVisualStyleBackColor = true;
            this.btEncryptT.Click += new System.EventHandler(this.BtEncryptT_Click);
            // 
            // SimpleEncrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 477);
            this.Controls.Add(this.btEncryptT);
            this.Controls.Add(this.btDecryptT);
            this.Controls.Add(this.btDecryptRC4);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btEncryptRC4);
            this.Controls.Add(this.tbInput);
            this.Name = "SimpleEncrypter";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btEncryptRC4;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btDecryptRC4;
        private System.Windows.Forms.Button btDecryptT;
        private System.Windows.Forms.Button btEncryptT;
    }
}