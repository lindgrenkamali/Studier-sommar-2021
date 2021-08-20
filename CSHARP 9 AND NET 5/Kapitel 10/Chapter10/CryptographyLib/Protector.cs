using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptographyLib
{
    public static class Protector
    {
        //Salt storleken måste åtminstone ha 8 bytes, kommer använda 32 bitar
        private static readonly byte[] salt = Encoding.UTF32.GetBytes("TioTusenÅr");

        //Iterationerna måste vara minst 1000, använder mig av 3000
        private static readonly int iterations = 3000;

        public static Dictionary<string, User> Users = new();

        public static User Register(string username, string password)
        {
            //Genererar random en salt
            var rng = RandomNumberGenerator.Create();
            var saltbytes = new byte[16];
            rng.GetBytes(saltbytes);
            var saltText = Convert.ToBase64String(saltbytes);

            //Genererar det saltade och hashade lösenordet
            var saltedhashedPassword = SaltAndHashPassword(password, saltText);

            var user = new User
            {
                Name = username,
                Salt = saltText,
                SaltedHashedPassword = saltedhashedPassword
            };
            Users.Add(user.Name, user);
            return user;
        }

        public static  bool CheckPassword(string username, string password)
        {
            if(!Users.ContainsKey(username))
            {
                return false;
            }
            var user = Users[username];

            //Re-generate det saltade och hashade lösenordet
            var saltedhashedPassword = SaltAndHashPassword(password, user.Salt);
            return (saltedhashedPassword == user.SaltedHashedPassword);
        }

        private static string SaltAndHashPassword(string password, string salt)
        {
            var sha = SHA256.Create();
            var saltedPassword = password + salt;
            return Convert.ToBase64String(sha.ComputeHash(Encoding.Unicode.GetBytes(saltedPassword)));
        }

        public static string Encrypt(string plainText, string password)
        {
            byte[] encryptedBytes;

            byte[] plainBytes = Encoding.UTF32.GetBytes(plainText);

            var aes = Aes.Create(); //Abstrakt klass factory metod

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);

            aes.Key = pbkdf2.GetBytes(32); // 256-bitars nyckel
            aes.IV = pbkdf2.GetBytes(16); // 128-bitars IV

            using (var ms = new MemoryStream())
            {
                using(var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(plainBytes, 0, plainBytes.Length);
                }

                encryptedBytes = ms.ToArray();
            }
            
            return Convert.ToBase64String(encryptedBytes);
        }

        public static string Decrypt(string cryptoText, string password)
        {
            byte[] plainBytes;

            byte[] cryptoBytes = Convert.FromBase64String(cryptoText);

            var aes = Aes.Create();

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);

            aes.Key = pbkdf2.GetBytes(32);
            aes.IV = pbkdf2.GetBytes(16);

            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cryptoBytes, 0, cryptoBytes.Length);
                }
                plainBytes = ms.ToArray();
            }
            return Encoding.UTF32.GetString(plainBytes);
        }
    }
    
}
