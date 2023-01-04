using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt_Decrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string Encrypt(string value)
        {
            using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding uTF8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValue.Text))
            {
                MessageBox.Show("Please Enter Your Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
                    }
            txtEncrypt.Text = Encrypt(txtValue.Text);
        }

        
    }
}
