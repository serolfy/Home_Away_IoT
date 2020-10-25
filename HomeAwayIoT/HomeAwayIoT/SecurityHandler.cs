using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ProjectBroker
{
    public class SecurityHandler
    {
        /// <summary>
        /// Encrypt a string.
        /// </summary>
        /// <param name="plainText">String to be encrypted</param>
        /// <param name="password">Password</param>
        public string Encrypt(string plainText, string password)
        {
            if (plainText == null)
            {
                return null;
            }

            if (password == null)
            {
                password = String.Empty;
            }

            // Get the bytes of the string
            var bytesToBeEncrypted = Encoding.UTF8.GetBytes(plainText);
            var passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            var bytesEncrypted = SecurityHandler.Encrypt(bytesToBeEncrypted, passwordBytes);
            Form1.gui.WriteLog(Convert.ToBase64String(bytesEncrypted));
            return Convert.ToBase64String(bytesEncrypted);
        }

        /// <summary>
        /// Decrypt a string.
        /// </summary>
        /// <param name="encryptedText">String to be decrypted</param>
        /// <param name="password">Password used during encryption</param>
        /// <exception cref="FormatException"></exception>
        public static string Decrypt(string encryptedText, string password)
        {
            if (encryptedText == null)
            {
                return null;
            }

            if (password == null)
            {
                password = String.Empty;
            }

            // Get the bytes of the string
            var bytesToBeDecrypted = Convert.FromBase64String(encryptedText);
            var passwordBytes = Encoding.UTF8.GetBytes(password);

            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            var bytesDecrypted = SecurityHandler.Decrypt(bytesToBeDecrypted, passwordBytes);

            return Encoding.UTF8.GetString(bytesDecrypted);
        }

        private static byte[] Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            using (AesCryptoServiceProvider csp = new AesCryptoServiceProvider())
            {
                csp.KeySize = 256;
                csp.BlockSize = 128;
                csp.Key = passwordBytes;
                csp.Padding = PaddingMode.PKCS7;
                csp.Mode = CipherMode.ECB;
                ICryptoTransform encrypter = csp.CreateEncryptor();
                return encrypter.TransformFinalBlock(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
            }
        }
            


        private static byte[] Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            using (AesCryptoServiceProvider csp = new AesCryptoServiceProvider())
            {
                csp.KeySize = 256;
                csp.BlockSize = 128;
                csp.Key = passwordBytes;
                csp.Padding = PaddingMode.PKCS7;
                csp.Mode = CipherMode.ECB;
                ICryptoTransform decrypter = csp.CreateDecryptor();
                return decrypter.TransformFinalBlock(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
            }
        }
            
    }
}
