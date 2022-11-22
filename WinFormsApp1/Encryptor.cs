using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Encryptor
    {
        /// <summary>
        /// SHA1 加密 
        /// </summary>
        /// <param name="content">需要加密字符串</param>
        /// <param name="encode">指定加密编码</param>
        /// <param name="upperOrLower">大小写格式（大写：X2;小写:x2）默认小写</param> 
        public static string SHA1Encrypt(string content, Encoding encode, string upperOrLower = "x2")
        {
            try
            {
                var buffer = encode.GetBytes(content);//用指定编码转为bytes数组
                var data = SHA1.Create().ComputeHash(buffer);
                var sb = new StringBuilder();
                foreach (var t in data)
                {
                    sb.Append(t.ToString(upperOrLower));
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                return "SHA1加密出错：" + ex.Message;
            }
        }

        /// <summary>
        /// SHA256加密
        /// </summary>
        /// <param name="strIN">要加密的string字符串</param>
        /// <returns>SHA256加密之后的密文</returns>
        public static string SHA256Encrypt(string strIN)
        {
            byte[] tmpByte;
            SHA256 sha256 = SHA256.Create();//new SHA256Managed();
            tmpByte = sha256.ComputeHash(GetKeyByteArray(strIN));

            StringBuilder rst = new StringBuilder();
            for (int i = 0; i < tmpByte.Length; i++)
            {
                rst.Append(tmpByte[i].ToString("x2"));
            }
            sha256.Clear();
            return rst.ToString();
        }

        /// <summary>
        /// 获取要加密的string字符串字节数组
        /// </summary>
        /// <param name="strKey">待加密字符串</param>
        /// <returns>加密数组</returns>
        private static byte[] GetKeyByteArray(string strKey)
        {
            UTF8Encoding Asc = new UTF8Encoding();
            int tmpStrLen = strKey.Length;
            byte[] tmpByte = new byte[tmpStrLen - 1];
            tmpByte = Asc.GetBytes(strKey);
            return tmpByte;
        }
    }
}
