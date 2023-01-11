using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        byte[] abc;
        byte[,] table;
        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = od.FileName;
            }
        }

        private void rdEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEncrypt.Checked)
            {
                rdEncrypt.Checked = true;
            }
        }

        private void rdDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDecrypt.Checked)
                rdDecrypt.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdEncrypt.Checked = true;

            
            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);

            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            
            if (!File.Exists(txtPath.Text))
            {
                MessageBox.Show("File does not exist.");
                return;
            }
            if (String.IsNullOrEmpty(txtKey.Text))
            {
                MessageBox.Show("Password empty. Please enter your password");
                return;
            }

                byte[] fileContent = File.ReadAllBytes(txtPath.Text);
                byte[] passwordTmp = Encoding.ASCII.GetBytes(txtKey.Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                keys[i] = passwordTmp[i % passwordTmp.Length];

                // Encrypt
                byte[] result = new byte[fileContent.Length];

                if (rdEncrypt.Checked)
                {
                  for (int i = 0; i < fileContent.Length; i++)
                    {
                      byte value = fileContent[i];
                      byte key = keys[i];
                      int valueIndex = -1, keyIndex = -1;
                      for (int j = 0; j < 256; j++)
                        if (abc[j] == value)
                           {
                                valueIndex = j;
                                break;
                           }
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        result[i] = table[keyIndex, valueIndex];
                    }
                }
                // Decrypt
                else
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (table[keyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        result[i] = abc[valueIndex];
                    }
                }

                // Dosyayý yeni bir belge olarak kaydeder.
                String fileExt = Path.GetExtension(txtPath.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, result);
                }
            /////////////////// String encryptor
            
        }
        static string Encrypt(string value)
        {
            string hash = "Example";
            byte[] data = UTF8Encoding.UTF8.GetBytes(value);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));

                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }
        public string Decrypt(string encrypted)
        {
            try
            {
                string hash = "Example";
                byte[] data = Convert.FromBase64String(encrypted);

                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {

                    using (TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider())
                    {

                        tripDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                        tripDES.Mode = CipherMode.ECB;
                        tripDES.Padding = PaddingMode.PKCS7;
                        ICryptoTransform transform = tripDES.CreateDecryptor();
                        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                        return UTF8Encoding.UTF8.GetString(result);
                    }
                }
            }

            catch (Exception ex)
            {
                var exception = ex;
                return "";
            }

        }
        private void bttnRun_Click(object sender, EventArgs e)
        {
            txtEncrypt.Text = Encrypt(txtValue.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtDecrypt.Text = Decrypt(txtEncrypt.Text);
        }
    }
}