using System.IO;
using System.Text;
using Xunit;

public class StringExtensionsTests
{
    [Fact]
    public void ToStream_WithValidStringAndEncoding_ReturnsCorrectStream()
    {
        string input = "This is a Test";
        Encoding encoding = Encoding.UTF8;

        using (Stream stream = input.ToStream(encoding))
        using (StreamReader reader = new StreamReader(stream, encoding))
        {
            string result = reader.ReadToEnd();
            Assert.Equal(input, result);
        }
    }

    [Fact]
    public void ToStream_WithNullString_ReturnsEmptyStream()
    {
        string input = null;
        Encoding encoding = Encoding.UTF8;

        using (Stream stream = input.ToStream(encoding))
        using (StreamReader reader = new StreamReader(stream, encoding))
        {
            string result = reader.ReadToEnd();
            Assert.Equal(string.Empty, result);
        }
    }
}
