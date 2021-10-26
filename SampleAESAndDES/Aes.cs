using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace SampleAESAndDES
{
    //참고 출처: https://nickname.tistory.com/25
    class Aes
    {
        //AES-128
        //key 32자 : keySize 128
        private static readonly string key = "TESTTESTTESTTESTTESTTESTTESTTEST";
        //iv 16자
        private static readonly string iv = "testtesttesttest";
        private static readonly int multiCount = 5;

        //AES 암호화
        public static string AESEncrypt(string input)
        {
            try
            {
                RijndaelManaged aes = new()
                {
                    //KeySize = 256; //AES256으로 사용시 
                    KeySize = 128, //AES128로 사용시 
                    BlockSize = 128,
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.PKCS7,
                    Key = Encoding.UTF8.GetBytes(key),
                    IV = Encoding.UTF8.GetBytes(iv)
                };
                var encrypt = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] buf = null;
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encrypt, CryptoStreamMode.Write))
                    {
                        byte[] xXml = Encoding.UTF8.GetBytes(input);
                        cs.Write(xXml, 0, xXml.Length);
                    }
                    buf = ms.ToArray();
                }
                string Output = Convert.ToBase64String(buf);
                return Output;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //AES 복호화
        public static string AESDecrypt(string input)
        {
            try
            {
                RijndaelManaged aes = new()
                {
                    //KeySize = 256; //AES256으로 사용시 
                    KeySize = 128, //AES128로 사용시 
                    BlockSize = 128,
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.PKCS7,
                    Key = Encoding.UTF8.GetBytes(key),
                    IV = Encoding.UTF8.GetBytes(iv)
                };
                var decrypt = aes.CreateDecryptor();
                byte[] buf = null;
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, decrypt, CryptoStreamMode.Write))
                    {
                        byte[] xXml = Convert.FromBase64String(input);
                        cs.Write(xXml, 0, xXml.Length);
                    }
                    buf = ms.ToArray();
                }
                string Output = Encoding.UTF8.GetString(buf);
                return Output;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //AES 암호화 반복
        public static string MultiAESEncrypt(string input)
        {
            string rslt = input;
            for (int i = 0; i < multiCount; i++)
            {
                rslt = AESEncrypt(rslt);
            }
            return rslt;
        }

        //AES 복호화 반복
        public static string MultiAESDecrypt(string input)
        {
            string rslt = input;
            for (int i = 0; i < multiCount; i++)
            {
                rslt = AESDecrypt(rslt);
            }
            return rslt;
        }
    }
}
