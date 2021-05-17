using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordProtectedCypher
{
    public static class CipherFunctions
    {
        public static char CipherAlgorithm(char c, int offset)
        {
            if (!Char.IsLetter(c)) {
                return c;
            }
            char a = char.IsUpper(c) ? 'A' : 'a';
            return (char)((((c + offset) - a) % 26) + a);
        }
        public static string DecryptText(string inputText, int offset) 
        {
            var output = String.Empty;
            foreach(char c in inputText) {
                output += CipherAlgorithm(c, 26 - offset);
            }
            return output;
        }
        public static string EncryptText(string inputText, int offset)
        {
            var output = String.Empty;
            foreach (char c in inputText) {
                output += CipherAlgorithm(c, offset);
            }
            return output;
        }

    }
}
