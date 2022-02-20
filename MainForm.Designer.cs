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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btEncryptRC4 = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btDecryptRC4 = new System.Windows.Forms.Button();
            this.btDecryptT = new System.Windows.Forms.Button();
            this.btEncryptT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btFileEncrypting = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(12, 32);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(395, 161);
            this.tbInput.TabIndex = 0;
            // 
            // btEncryptRC4
            // 
            this.btEncryptRC4.BackColor = System.Drawing.Color.AliceBlue;
            this.btEncryptRC4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEncryptRC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEncryptRC4.Location = new System.Drawing.Point(12, 439);
            this.btEncryptRC4.Name = "btEncryptRC4";
            this.btEncryptRC4.Size = new System.Drawing.Size(103, 30);
            this.btEncryptRC4.TabIndex = 1;
            this.btEncryptRC4.Text = "Encrypt RC4";
            this.btEncryptRC4.UseVisualStyleBackColor = false;
            this.btEncryptRC4.Click += new System.EventHandler(this.BtEncryptRC4_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput.Location = new System.Drawing.Point(13, 220);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(395, 161);
            this.tbOutput.TabIndex = 2;
            // 
            // tbKey
            // 
            this.tbKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKey.Location = new System.Drawing.Point(12, 408);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(395, 20);
            this.tbKey.TabIndex = 3;
            // 
            // btDecryptRC4
            // 
            this.btDecryptRC4.BackColor = System.Drawing.Color.AliceBlue;
            this.btDecryptRC4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDecryptRC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDecryptRC4.Location = new System.Drawing.Point(12, 475);
            this.btDecryptRC4.Name = "btDecryptRC4";
            this.btDecryptRC4.Size = new System.Drawing.Size(103, 30);
            this.btDecryptRC4.TabIndex = 4;
            this.btDecryptRC4.Text = "Decrypt RC4";
            this.btDecryptRC4.UseVisualStyleBackColor = false;
            this.btDecryptRC4.Click += new System.EventHandler(this.BtDecryptRC4_Click);
            // 
            // btDecryptT
            // 
            this.btDecryptT.BackColor = System.Drawing.Color.Snow;
            this.btDecryptT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDecryptT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDecryptT.Location = new System.Drawing.Point(121, 475);
            this.btDecryptT.Name = "btDecryptT";
            this.btDecryptT.Size = new System.Drawing.Size(103, 30);
            this.btDecryptT.TabIndex = 5;
            this.btDecryptT.Text = "Decrypt T";
            this.btDecryptT.UseVisualStyleBackColor = false;
            this.btDecryptT.Click += new System.EventHandler(this.btDecryptT_Click);
            // 
            // btEncryptT
            // 
            this.btEncryptT.BackColor = System.Drawing.Color.Snow;
            this.btEncryptT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEncryptT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEncryptT.Location = new System.Drawing.Point(121, 439);
            this.btEncryptT.Name = "btEncryptT";
            this.btEncryptT.Size = new System.Drawing.Size(103, 30);
            this.btEncryptT.TabIndex = 6;
            this.btEncryptT.Text = "Encrypt T";
            this.btEncryptT.UseVisualStyleBackColor = false;
            this.btEncryptT.Click += new System.EventHandler(this.BtEncryptT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plaintext";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ciphertext";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Key";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Chosee file...";
            // 
            // btFileEncrypting
            // 
            this.btFileEncrypting.BackColor = System.Drawing.Color.AliceBlue;
            this.btFileEncrypting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFileEncrypting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFileEncrypting.Location = new System.Drawing.Point(271, 470);
            this.btFileEncrypting.Name = "btFileEncrypting";
            this.btFileEncrypting.Size = new System.Drawing.Size(103, 30);
            this.btFileEncrypting.TabIndex = 10;
            this.btFileEncrypting.Text = "Open...";
            this.btFileEncrypting.UseVisualStyleBackColor = false;
            this.btFileEncrypting.Click += new System.EventHandler(this.BtFileEncrypting_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(251, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Encrypt/decrypt file";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(419, 518);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btFileEncrypting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEncryptT);
            this.Controls.Add(this.btDecryptT);
            this.Controls.Add(this.btDecryptRC4);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btEncryptRC4);
            this.Controls.Add(this.tbInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Simple Encrypter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btFileEncrypting;
        private System.Windows.Forms.Label label4;
    }
}