using System.Text;

namespace System
{
    public static class StringExtension
    {
        private static string nomarlLetter = "qwertyuiopasdfghjklçzxcvbnmáéíóìàôõâãê";
        private static string codeLetter = "!9$%3@?/*8&56-:;0274^~[]{}|jsbghjvu1><";
        public static string Encrypt(this string s)
        {
            StringBuilder text = new StringBuilder();

            for(int i = 0; i < s.Length; i++)
            {
                for(int j = 0; j < nomarlLetter.Length; j++)
                {
                    if(s[i] == nomarlLetter[j])
                    {
                        text.Append(codeLetter[j]);
                    }
                }
            }

            return text.ToString();
        }
    }
}