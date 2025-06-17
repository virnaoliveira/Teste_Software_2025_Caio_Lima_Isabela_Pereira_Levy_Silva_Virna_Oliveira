// Esse é o que possui -2 votos
using System.IO;

namespace MeuProjeto
{
    public static class StringExtensions
    {
        public static byte[] GetBytes(this string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static Stream ToStream(this string str)
        {
            Stream stringStream = new MemoryStream();
            stringStream.Read(str.GetBytes(), 0, str.Length);
            return stringStream;
        }
    }
}
