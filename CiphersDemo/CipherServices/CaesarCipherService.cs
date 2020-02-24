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
            return "Encryption functionality implementation is in progress";
        }

        public string Decrypt(string inputText)
        {
            return "Decryption functionality implementation is in progress";
        }
    }
}
