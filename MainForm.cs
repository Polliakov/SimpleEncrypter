using System;
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
            if (!CheckKey()) return;

            var key = Encoding.UTF8.GetBytes(tbKey.Text);
            tbOutput.Text = RC4.Encrypt(tbInput.Text, key);
        }

        private void BtDecryptRC4_Click(object sender, EventArgs e)
        {
            if (!CheckKey()) return;

            var key = Encoding.UTF8.GetBytes(tbKey.Text);
            tbOutput.Text = RC4.Decrypt(tbInput.Text, key);
        }

        private void BtEncryptT_Click(object sender, EventArgs e)
        {
            if (!CheckKey()) return;
            tbOutput.Text = Transposition.Encrypt(tbInput.Text, tbKey.Text);
        }

        private void btDecryptT_Click(object sender, EventArgs e)
        {
            if (!CheckKey()) return;
            tbOutput.Text = Transposition.Decrypt(tbInput.Text, tbKey.Text);
        }

        private bool CheckKey()
        {
            if (string.IsNullOrEmpty(tbKey.Text))
            {
                MessageBox.Show("Enter the key.");
                return false;
            }
            return true;
        }
    }
}
