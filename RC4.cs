using System;
using System.Text;

namespace SimpleEncrypter
{
    public static class RC4
    {
        public static string Encrypt(string str, byte[] key)
        {
            var data = Encoding.UTF8.GetBytes(str);
            var ciper = Bytes(data, key);
            return Convert.ToBase64String(ciper);
        }

        public static string Decrypt(string base64, byte[] key)
        {
            var data = Convert.FromBase64String(base64);
            var decrypted = Bytes(data, key);
            return Encoding.UTF8.GetString(decrypted);
        }

        public static byte[] Bytes(byte[] data, byte[] key)
        {
            if (data is null) 
                throw new ArgumentNullException(nameof(data));
            if (key is null || key.Length == 0) 
                throw new ArgumentNullException(nameof(key));

            byte[] s = KeySheduling(key);
            int x = 0;
            int y = 0;

            var result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
                result[i] = (byte)(data[i] ^ KeyItem(s, x, y));

            return result;
        }

        private static byte[] KeySheduling(byte[] key)
        {
            var s = new byte[256];
            for (int i = 0; i < 256; i++)
                s[i] = (byte)i;

            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + s[i] + key[i % key.Length]) % 256;

                Swap(s, i, j);
            }

            return s;
        }

        private static byte KeyItem(byte[] s, int x, int y)
        {
            x = (x + 1) % 256;
            y = (y + s[x]) % 256;

            Swap(s, x, y);

            return s[(s[x] + s[y]) % 256];
        }

        private static void Swap(byte[] source, int i, int j)
        {
            var tmp = source[i];
            source[i] = source[j];
            source[j] = tmp;
        }
    }
}
