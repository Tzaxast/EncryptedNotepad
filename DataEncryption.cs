using Encrypted_Notepad;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Crypto
{
    internal class DataEncryption
    {
        private static byte[] keybytes;
        private static byte[] ivbytes;

        //Used for encryption of the text on the disk
        private static byte[] DeriveKey(string userPassword)
        {
            byte[] KeySalt = new byte[16];
            using (RNGCryptoServiceProvider rng_crypto = new RNGCryptoServiceProvider())
            {
                rng_crypto.GetBytes(KeySalt);
            }

            Rfc2898DeriveBytes keybytes = new Rfc2898DeriveBytes(userPassword, KeySalt, 10000, HashAlgorithmName.SHA512);
            return keybytes.GetBytes(16);
        }

        public static string DecryptText(string TextToDecrypt = "", string userkey = "WmZq3t6w9z$C&F)J")
        {
            if (string.IsNullOrEmpty(TextToDecrypt)) { throw new ArgumentException("The string to decrypt passed was empty or null", TextToDecrypt); }
            else if (string.IsNullOrEmpty(userkey)) { throw new ArgumentException("The key for the decryption was empty", userkey); }

            byte[] cipherbytes;
            byte[] decrypted_data;

            using (Aes aes = Aes.Create())
            {
                aes.Key = keybytes;
                aes.IV = ivbytes;

                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                //1)Convert the base64 ciphertext to a ciphertext byte array
                cipherbytes = Convert.FromBase64String(TextToDecrypt);

                using (MemoryStream memoryData = new MemoryStream())
                {
                    using (CryptoStream decryptStream = new CryptoStream(memoryData, decryptor, CryptoStreamMode.Write))
                    {
                        decryptStream.Write(cipherbytes, 0, cipherbytes.Length);
                    }
                    decrypted_data = memoryData.ToArray();
                }
            }
            return Encoding.UTF8.GetString(InverseTransformString(decrypted_data));
        }


        public static string EncryptText(string TextToEncrypt = "", string userkey = "WmZq3t6w9z$C&F)J")
        {
            if (string.IsNullOrEmpty(TextToEncrypt)) { throw new ArgumentException("The string to encrypt passed was empty or null", TextToEncrypt); }
            else if (string.IsNullOrEmpty(userkey)) { throw new ArgumentException("The key for the encryption was empty", userkey); }

            byte[] iv = new byte[16];
            byte[] output;
            byte[] TransformedText;

            using (RNGCryptoServiceProvider rng_crypto = new RNGCryptoServiceProvider())
            {
                rng_crypto.GetBytes(iv);
            }

            ivbytes = iv;

            using (Aes aes = Aes.Create())
            {

                aes.Key = DeriveKey(userkey);
                keybytes = aes.Key;
                aes.IV = iv;

                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                //1) Transform text to byte array
                TransformedText = TransformString(TextToEncrypt);

                using (MemoryStream memoryData = new MemoryStream())
                {
                    using (CryptoStream encryptStream = new CryptoStream(memoryData, encryptor, CryptoStreamMode.Write))
                    {
                        //2) Encrypt byte array
                        encryptStream.Write(TransformedText, 0, TransformedText.Length);
                    }
                    output = memoryData.ToArray();
                }
            }
            //3)Convert to base64 the resulting cipher text
            return Convert.ToBase64String(output, Base64FormattingOptions.None);
        }

        private static byte[] TransformString(string str)
        {
            byte[] str_data = Encoding.UTF8.GetBytes(str);
            byte[] output = new byte[str_data.Length];

            for (int i = 0; i < str_data.Length; i++)
            {
                output[i] = Transforms.TransformByte(str_data[i]);
            }
            return output;
        }

        private static byte[] InverseTransformString(byte[] str)
        {
            byte[] str_data = str;
            byte[] output = new byte[str_data.Length];

            for (int i = 0; i < str_data.Length; i++)
            {
                output[i] = Transforms.InvertByteTransform(str_data[i]);
            }
            return output;
        }

        internal static void SaveEncryptedTextToFile(Stream file, string Encryptedtext)
        {
            using (StreamWriter writer = new StreamWriter(file))
            { 
                writer.Write(Encryptedtext);
            }
        }

        internal static void OpenDecryptedTextFile(Stream file)
        {
            string text_to_decrypt;
            using (StreamReader txtreader = new StreamReader(file))
            {
                text_to_decrypt = txtreader.ReadToEnd();
            }
            DecryptText(text_to_decrypt);
        }
    }
}
