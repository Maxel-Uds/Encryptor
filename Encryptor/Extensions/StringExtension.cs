using System.Text;

namespace System
{
    public static class StringExtension
    {
        private static string normalLetter = "qwertyuiopasdfghjklçzxcvbnmáéíóìàôõâãê";
        private static string codeLetter = "!9$%3@?/*8&56-:;0274^~[]{}|jsbghjvu1><";
        public static string Encrypt(this string s)
        {
            StringBuilder text = new StringBuilder();

            for(int i = 0; i < s.Length; i++)
            {
                for(int j = 0; j < normalLetter.Length; j++)
                {
                    if(s[i] == normalLetter[j])
                    {
                        text.Append(codeLetter[j]);
                        break;
                    }
                    else if(Char.IsWhiteSpace(s[i]))
                    {
                        text.Append(".");
                        break;
                    }
                    else if(Char.IsUpper(s[i]))
                    {
                        text.Append(s[i]);
                        break;
                    }
                }
            }

            return text.ToString();
        }

        public static string DeCrypt(this string s)
        {
            StringBuilder text = new StringBuilder();

            for(int i = 0; i < s.Length; i++)
            {
                for(int j = 0; j < codeLetter.Length; j++)
                {
                    if(s[i] == codeLetter[j])
                    {
                        text.Append(normalLetter[j]);
                        break;
                    }
                    else if(s[i] == (".")[0])
                    {
                        text.Append(" ");
                        break;
                    }
                    else if(Char.IsUpper(s[i]))
                    {
                        text.Append(s[i]);
                        break;
                    }
                }
            }

            return text.ToString();
        }
    }
}