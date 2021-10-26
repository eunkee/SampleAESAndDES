using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SampleAESAndDES
{
    //참고 출처: https://im-first-rate.tistory.com/65
    public class Des
    {
        // 키값 = 8자
        private static readonly string KEY = "TESTTEST";
        // 사용시 반복 횟수
        private static readonly int multiCount = 5;

        public enum DES_TYPE
        {
            ENCRYPT = 0,    // 암호화
            DECRYPT = 1     // 복호화
        }

        //  암호화 / 복호화
        public static string Result(DES_TYPE type, string input)
        {
            byte[] Key = ASCIIEncoding.ASCII.GetBytes(KEY);

            var des = new DESCryptoServiceProvider()
            {
                Key = Key,
                IV = Key
            };

            var ms = new MemoryStream();

            // 익명 타입으로 transform / data 정의
            var property = new
            {
                transform = type.Equals(DES_TYPE.ENCRYPT) ? des.CreateEncryptor() : des.CreateDecryptor(),
                data = type.Equals(DES_TYPE.ENCRYPT) ? Encoding.UTF8.GetBytes(input.ToCharArray()) : Convert.FromBase64String(input)
            };

            var cryStream = new CryptoStream(ms, property.transform, CryptoStreamMode.Write);
            var data = property.data;

            cryStream.Write(data, 0, data.Length);
            cryStream.FlushFinalBlock();

            return type.Equals(DES_TYPE.ENCRYPT) ? Convert.ToBase64String(ms.ToArray()) : Encoding.UTF8.GetString(ms.GetBuffer());
        }

        // 반복 암호화 / 복호화
        public static string MultiResult(DES_TYPE type, string input)
        {
            string rslt = "";
            if (type == DES_TYPE.ENCRYPT)
            {
                string temp = input;
                for (int i = 0; i < multiCount; i++)
                {
                    byte[] baseByte = Encoding.UTF8.GetBytes(temp);
                    string encode64 = Convert.ToBase64String(baseByte);
                    temp = Result(DES_TYPE.ENCRYPT, encode64);
                }
                rslt = temp;
            }
            else if (type == DES_TYPE.DECRYPT)
            {
                string temp = input;
                for (int i = 0; i < multiCount; i++)
                {
                    string reEncode64 = Result(DES_TYPE.DECRYPT, temp).Replace("\0", "");
                    byte[] byteData = Convert.FromBase64String(reEncode64);
                    temp = Encoding.UTF8.GetString(byteData);
                }
                rslt = temp;
            }
            return rslt;
        }
    }
}
