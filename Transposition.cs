using System;

namespace SimpleEncrypter
{
    public static class Transposition
    {
        public static string Encrypt(string text, string key)
        {
            if (text is null)
                throw new ArgumentNullException(nameof(text));
            if (key is null || key.Length == 0)
                throw new ArgumentNullException(nameof(key));

            var table = ToTable(text, key.Length);
            Array.Sort(key.ToCharArray(), table);
            return string.Join("", table);
        }

        public static string Decrypt(string text, string key)
        {
            if (text is null)
                throw new ArgumentNullException(nameof(text));
            if (key is null || key.Length == 0)
                throw new ArgumentNullException(nameof(key));

            var keyI = new int[key.Length];
            for (int i = 0; i < keyI.Length; i++)
                keyI[i] = i;
            Array.Sort(key.ToCharArray(), keyI);

            var table = ToTable(text, key.Length);
            Array.Sort(keyI, table);

            return string.Join("", table);
        }

        private static string[] ToTable(string text, int rowsCount)
        {
            var table = new string[rowsCount];

            if (text.Length % rowsCount != 0)
            {
                int toFull = (text.Length / rowsCount + 1) * rowsCount - text.Length;
                text = string.Concat(text, new string(' ', toFull));
            }
            int inRowCount = text.Length / rowsCount;

            for(int i = 0; i < table.Length; i++)
                table[i] = text.Substring(i * inRowCount, inRowCount);

            return table;
        }

    }
}
