using System;
using System.Windows.Forms;

namespace SampleAESAndDES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonAES.Checked = true;
        }

        //암호화
        private void ButtonEncryption_Click(object sender, EventArgs e)
        {
            string originData = TextBoxData.Text;
            if (originData.Length > 0)
            {
                bool isAES = radioButtonAES.Checked;
                if (isAES)
                {
                    TextBoxEncryptionData.Text = Aes.AESEncrypt(originData);
                }
                else //DES
                {
                    TextBoxEncryptionData.Text = Des.Result(Des.DES_TYPE.ENCRYPT, originData);
                }
            }
        }

        //복호화
        private void ButtonDecryption_Click(object sender, EventArgs e)
        {

            string encryptionData = TextBoxEncryptionData.Text;
            if (encryptionData.Length > 0)
            {
                bool isAES = radioButtonAES.Checked;
                if (isAES)
                {
                    TextBoxDecryptionData.Text = Aes.AESDecrypt(encryptionData);
                }
                else //DES
                {
                    TextBoxDecryptionData.Text = Des.Result(Des.DES_TYPE.DECRYPT, encryptionData);
                }

            }
        }

        private void RadioButtonAES_CheckedChanged(object sender, EventArgs e)
        {
            InitCryptionText();
        }

        private void RadioButtonDES_CheckedChanged(object sender, EventArgs e)
        {
            InitCryptionText();
        }

        private void InitCryptionText()
        {
            TextBoxEncryptionData.Text = string.Empty;
            TextBoxDecryptionData.Text = string.Empty;
        }
    }
}
