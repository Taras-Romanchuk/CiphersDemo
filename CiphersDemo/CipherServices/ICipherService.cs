namespace CiphersDemo.CipherServices
{
    interface ICipherService
    {
        string Encrypt(string inputText);

        string Decrypt(string inputText);
    }
}
