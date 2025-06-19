using System.IO;
using System.Text;
using Xunit;

public class StringExtensionsTests
{
    [Fact]
    public void ToStream_WithoutEncoding_ShouldUseUTF8()
    {
        string text = "Exemplo de texto";
        
        using (var stream = text.ToStream())
        using (var reader = new StreamReader(stream, Encoding.UTF8))
        {
            string result = reader.ReadToEnd();
            Assert.Equal(text, result);
        }
    }

    [Fact]
    public void ToStream_WithEncoding_ShouldReturnCorrectStream()
    {
        string text = "Teste com codificação";
        Encoding encoding = Encoding.ASCII;

        using (var stream = text.ToStream(encoding))
        using (var reader = new StreamReader(stream, encoding))
        {
            string result = reader.ReadToEnd();
            Assert.Equal(text, result);
        }
    }

    [Fact]
    public void ToStream_WithNullString_ShouldReturnEmptyStream()
    {
        string text = null;

        using (var stream = text.ToStream())
        using (var reader = new StreamReader(stream, Encoding.UTF8))
        {
            string result = reader.ReadToEnd();

            Assert.Equal(string.Empty, result);
        }
    }
}
