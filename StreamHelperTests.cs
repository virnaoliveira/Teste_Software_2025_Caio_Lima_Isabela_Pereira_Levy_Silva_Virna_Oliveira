
using System.IO;
using Xunit;

public class StreamHelperTests
{
    [Fact]
    public void GenerateStreamFromString_ShouldReturnReadableStream()
    {
        string input = "Hello, World!";
        using var stream = StreamHelper.GenerateStreamFromString(input);
        using var reader = new StreamReader(stream);
        string result = reader.ReadToEnd();
        Assert.Equal(input, result);
    }

    [Fact]
    public void GenerateStreamFromString_WithEmptyString_ReturnsEmptyStream()
    {
        string input = string.Empty;
        using var stream = StreamHelper.GenerateStreamFromString(input);
        using var reader = new StreamReader(stream);
        string result = reader.ReadToEnd();
        Assert.Equal(input, result);
    }

    [Fact]
    public void GenerateStreamFromString_WithUnicodeCharacters_ReturnsExpectedString()
    {
        string input = "Olá, mundo! 🌍";
        using var stream = StreamHelper.GenerateStreamFromString(input);
        using var reader = new StreamReader(stream);
        string result = reader.ReadToEnd();
        Assert.Equal(input, result);
    }

    [Fact]
    public void GenerateStreamFromString_MultipleCalls_ReturnEquivalentStreams()
    {
        string input = "Reutilizável";
        using var stream1 = StreamHelper.GenerateStreamFromString(input);
        using var reader1 = new StreamReader(stream1);
        string result1 = reader1.ReadToEnd();

        using var stream2 = StreamHelper.GenerateStreamFromString(input);
        using var reader2 = new StreamReader(stream2);
        string result2 = reader2.ReadToEnd();

        Assert.Equal(result1, result2);
    }
}
