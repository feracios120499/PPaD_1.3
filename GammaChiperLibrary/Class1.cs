using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammaChiperLibrary
{
    public class GammaChiper
    {
        private string alphabet = "АБВГДЕЁЖЗИЙКЛМОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public string Encrypt(string text, string key)
        {
            text = text.ToUpper();
            key = key.ToUpper();
            var mult = Convert.ToInt32(Math.Ceiling((double)(text.Length / key.Length)));
            for(int i = 0; i < mult; i++)
            {
                key += key;
            }
            key = key.Substring(0, text.Length);
            string encodeStr = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (alphabet.Contains(text[i]))
                {
                    encodeStr += alphabet[(alphabet.IndexOf(text[i]) + alphabet.IndexOf(key[i])) % alphabet.Length];
                }
                else
                {
                    encodeStr += text[i];
                }
                
            }
            return encodeStr;
        }
        public string Decrypt(string text,string key)
        {
            text = text.ToUpper();
            key = key.ToUpper();
            var mult = Convert.ToInt32(Math.Ceiling((double)(text.Length / key.Length)));
            for (int i = 0; i < mult; i++)
            {
                key += key;
            }
            key = key.Substring(0, text.Length);
            string originalStr = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (alphabet.Contains(text[i]))
                {
                    originalStr += alphabet[(alphabet.IndexOf(text[i]) + alphabet.Length - alphabet.IndexOf(key[i])) % alphabet.Length];
                }
                else
                {
                    originalStr += text[i];
                }

            }
            return originalStr;
        }

        public int Test(int a,int b)
        {
            return a ^ b;
        }
    }
}
