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
            return CaesarCipherEncryption(inputText, shift);
        }

        public string Decrypt(string inputText)
        {
            return CaesarCipherEncryption(inputText, 26 - shift);
        }

        private string CaesarCipherEncryption(string inputText, int shift)
        {
            var outputText = String.Empty;

            foreach (var character in inputText)
            {
                if (character == ' ')
                {
                    outputText += ' ';
                }
                else
                {
                    outputText += ShiftedCharacter(character, shift);
                }
            }

            return outputText;
        }

        private char ShiftedCharacter(char character, int shift)
        {
            var shiftedCharacter = character + shift;

            if (!IsInAlphabetRange(character + shift))
            {
                shiftedCharacter -= 26;
            }

            return (char) shiftedCharacter;
        }

        private bool IsInAlphabetRange(int character)
        {
            return character >= 65 && character <= 90;
        }
    }
}
