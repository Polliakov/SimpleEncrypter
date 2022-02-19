using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleEncripter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtEncryptRC4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKey.Text))
            {
                MessageBox.Show("Enter the key.");
                return;
            }
            var key = Encoding.UTF8.GetBytes(tbKey.Text);
            string ciper = RC4.Encrypt(tbInput.Text, key);
            tbOutput.Text = ciper;
        }

        private void BtDecryptRC4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbKey.Text))
            {
                MessageBox.Show("Enter the key.");
                return;
            }
            var key = Encoding.UTF8.GetBytes(tbKey.Text);
            string decrypted = RC4.Decrypt(tbInput.Text, key);
            tbOutput.Text = decrypted;
        }
    }
}
