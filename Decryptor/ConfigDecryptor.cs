using System.Security.Cryptography;
using System.Text;

namespace _7dsgcDatamine
{
    public static class ConfigDecryptor
    {
        public static string Decrypt(string encrypted)
        {
            byte[] data = Convert.FromBase64String(encrypted);
            byte[] salt = new byte[8];
            byte[] content = new byte[data.Length - salt.Length - 8];
            Buffer.BlockCopy(data, 8, salt, 0, salt.Length);
            Buffer.BlockCopy(data, salt.Length + 8, content, 0, content.Length);
            DeriveKeyAndIV("funnypaw-Nanatsunotaizai-CDN-key", salt, out byte[] key, out byte[] iv);
            return DecryptStringFromBytesAes(content, key, iv);
        }

        private static void DeriveKeyAndIV(string passphrase, byte[] salt, out byte[] key, out byte[] iv)
        {
            List<byte> list = new List<byte>(48);
            byte[] bytes = Encoding.UTF8.GetBytes(passphrase);
            byte[] array = Array.Empty<byte>();
            MD5 md = MD5.Create();
            bool flag = false;
            while (!flag)
            {
                byte[] array2 = new byte[array.Length + bytes.Length + salt.Length];
                Buffer.BlockCopy(array, 0, array2, 0, array.Length);
                Buffer.BlockCopy(bytes, 0, array2, array.Length, bytes.Length);
                Buffer.BlockCopy(salt, 0, array2, array.Length + bytes.Length, salt.Length);
                array = md.ComputeHash(array2);
                list.AddRange(array);
                if (list.Count >= 48)
                {
                    flag = true;
                }
            }
            key = new byte[32];
            iv = new byte[16];
            list.CopyTo(0, key, 0, 32);
            list.CopyTo(32, iv, 0, 16);
        }

        private static string DecryptStringFromBytesAes(byte[] cipherText, byte[] key, byte[] iv)
        {
            Aes aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Key = key;
            aes.IV = iv;
            ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
            MemoryStream memoryStream = new MemoryStream(cipherText);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
            StreamReader streamReader = new StreamReader(cryptoStream);
            return streamReader.ReadToEnd();
        }
    }
}