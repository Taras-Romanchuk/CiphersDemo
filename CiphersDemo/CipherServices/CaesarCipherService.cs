using System;

namespace CiphersDemo.CipherServices
{
    public class CaesarCipherService : ICipherService
    {
        private int shift;

        public CaesarCipherService(CaesarCipherData caesarCipherData)
        {
            shift = caesarCipherData.Shift;
        }

        public string Encrypt(string inputText)
        {
            string outputText = String.Empty;

            foreach (var character in inputText)
            {
                if (character == ' ')
                {
                    outputText += ' ';
                }
                else
                {
                    outputText += (char)(character + shift);
                }
            }

            return outputText;
        }

        public string Decrypt(string inputText)
        {
            return "Decryption functionality implementation is in progress";
        }
    }
}
