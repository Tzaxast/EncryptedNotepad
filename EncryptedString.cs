using System;
using System.Diagnostics;
//using System.Text;

namespace Crypto
{
    public sealed class EncryptedString : IEquatable<EncryptedString>
    {
        private char[] cryptoKey;
        private char[] encrypted_char_data;
        private static EncryptedString instance;

        private EncryptedString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return;
            }
            cryptoKey = new char[input.ToCharArray().Length];
            GetRandomKey(ref cryptoKey);
            encrypted_char_data = Encrypt(input.ToCharArray(), cryptoKey);
            instance = this;
        }

        private static char[] Encrypt(char[] value, char[] key)
        {

            if (value == null || value.Length == 0)
            {
                return value;
            }
            var result = new char[value.Length];
            var transformedtext = new char[value.Length];

            if (key.Length == 0) { Debug.Fail("The Encryption key cannot be empty or null."); return value; }

            for (int i = 0; i < value.Length; i++)
            {
                transformedtext[i] = Convert.ToChar(Transforms.TransformByte(Convert.ToByte(value[i])));
            }

            for (int i = 0; i < value.Length; i++)
            {
                result[i] = (char) (value[i] ^ (key[i] ^ 0xfe));
            }
            return result;
        }

        private static void GetRandomKey(ref char[] outcharbytes)
        {
            Random rnd = new Random();
            for (int i = 0; i < outcharbytes.Length; i++)
            {
                outcharbytes[i] = Convert.ToChar((Transforms.TransformByte(rnd.Next(256)))^ 0xfe);
            }
        }

        private static char[] Decrypt(char[] value, char[] key)
        {
            if (value == null || value.Length == 0)
            {
                return value;
            }
            var result = new char[value.Length];
            var transformedtext = new char[value.Length];

            if (key.Length == 0) { Debug.Fail("The Encryption key cannot be empty or null."); return value; }


            for (int i = 0; i < value.Length; i++)
            {
                transformedtext[i] = Convert.ToChar(Transforms.InvertByteTransform(Convert.ToByte(value[i])));
            }

            for (int i = 0; i < value.Length; i++)
            {
                result[i] = (char) (value[i] ^ (key[i] ^ 0xfe));
            }
            return result;
        }

        public int Length => cryptoKey.Length;

        private string GetDecryptedValue
        {
            get
            {
                return new string(Decrypt(encrypted_char_data, cryptoKey));
            }
        }

        private char[] GetDecryptedChars
        {
            get
            {
                return Decrypt(encrypted_char_data, cryptoKey);
            }
        }

        public char this[int position]
        {
            get
            {
                if (position < 0 || position >= cryptoKey.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return Decrypt(encrypted_char_data, cryptoKey)[position];
            }
        }

        private static EncryptedString GetInstance()
        {
            //if (instance == null) { throw new NullReferenceException(); }

            return instance;
        }

        public static implicit operator EncryptedString(string value)
        {
            return value == null ? null : new EncryptedString(value);
        }

        public static implicit operator string(EncryptedString value)
        {
            return value == null ? null : value.GetDecryptedValue;
        }

        public override int GetHashCode()
        {
            return GetDecryptedValue.GetHashCode();
        }

        public override string ToString()
        {
            return GetDecryptedValue;
        }

        public bool Equals(EncryptedString other)
        {
            if (other == null) return false;

            if (cryptoKey == other.cryptoKey)
            {
                return ArraysEquals(encrypted_char_data, other.encrypted_char_data);
            }

            return ArraysEquals(GetDecryptedChars, other.GetDecryptedChars);
        }

        public string Substring(int startPosition)
        {
            return Substring(startPosition, Length - startPosition);
        }

        public string Substring(int startPosition, int length)
        {
            return GetDecryptedValue.Substring(startPosition, length);
        }

        private static bool ArraysEquals(char[] left, char[] right)
        {
            if (left == right) return true;
            if (left == null || right == null) return false;
            if (left.Length != right.Length) return false;

            for (var i = 0; i < left.Length; i++)
            {
                if (left[i] != right[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
