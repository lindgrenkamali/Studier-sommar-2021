using System;
using System.Security.Cryptography; //CryptographicException
using CryptographyLib;
using static System.Console;

namespace EncryptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Skriv in något att kryptera: ");
            string meddelande = ReadLine();
            Write("Skriv in ett lösenord: ");
            string lösenord = ReadLine();

            string cryptoText = Protector.Encrypt(meddelande, lösenord);

            WriteLine(cryptoText);


            Write("Skriv in ditt lösenord: ");
            string lösenord2 = ReadLine();

            try
            {
                string clearText = Protector.Decrypt(cryptoText, lösenord2);
                WriteLine(clearText);
            }
            catch (CryptographicException ex)
            {

                WriteLine(ex.Message);
            }
        }
    }
}
