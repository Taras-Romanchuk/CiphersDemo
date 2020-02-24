namespace CiphersDemo.CipherServices
{
    public class CaesarCipherData
    {
        public int Shift { get; set; }

        public CaesarCipherData(int shift)
        {
            Shift = shift;
        }
    }
}
