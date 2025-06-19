using System.IO;
using System.Text;

public static class StringExtensions
{
    public static Stream ToStream(this string str, Encoding enc = null)
    {
        enc ??= Encoding.UTF8;
        return new MemoryStream(enc.GetBytes(str ?? ""));
    }
}
