using System.Security.Cryptography;

namespace Decryptor
{
    public class BundleDecryptor
    {
        public BundleDecryptor(string decryptionKey)
        {
            _passphrase = decryptionKey;
        }

        public byte[] Decrypt(byte[] data)
        {
            try
            {
                byte[] salt = new byte[32];
                Array.Copy(data, 0, salt, 0, salt.Length);
                ICryptoTransform cryptoTransform = CreateDecryptor(salt);
                byte[] content = new byte[data.Length - salt.Length];
                Array.Copy(data, salt.Length, content, 0, content.Length);
                return CryptographyOrThrow(content, cryptoTransform);
            }
            catch
            {
                throw new CryptographicException($"Failed to decrypt data, the key {_passphrase} is probably incorrect.");
            }
        }

        private ICryptoTransform CreateDecryptor(byte[] salt)
        {
            byte[] key;
            byte[] iv;
            DeriveKeyInitVector(salt, out key, out iv);
            ICryptoTransform result;
            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.IV = iv;
                aes.Key = key;
                result = aes.CreateDecryptor(aes.Key, aes.IV);
            }
            return result;
        }

        private void DeriveKeyInitVector(byte[] salt, out byte[] key, out byte[] initVector)
        {
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(_passphrase, salt);
            initVector = new byte[16];
            Array.Copy(rfc2898DeriveBytes.GetBytes(8), 0, initVector, 0, 8);
            Array.Copy(salt, 8, initVector, 8, 8);
            key = rfc2898DeriveBytes.GetBytes(32);
        }

        private byte[] CryptographyOrThrow(byte[] data, ICryptoTransform cryptoTransform)
        {
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
            cryptoStream.Write(data, 0, data.Length);
            cryptoStream.FlushFinalBlock();
            return memoryStream.ToArray();
        }

        private readonly string _passphrase;
    }
}