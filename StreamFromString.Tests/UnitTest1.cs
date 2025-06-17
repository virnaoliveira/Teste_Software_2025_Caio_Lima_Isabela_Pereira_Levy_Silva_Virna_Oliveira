using System.IO;
using Xunit;
using MeuProjeto;

namespace MeuProjeto.Tests
{
    public class CsvProcessorTests
    {

        [Fact]
        public void ToStream_DeveConverterStringParaStreamComConteudoCorreto()
        {
            string textoOriginal = "Olá, mundo!";

            using var streamResultado = textoOriginal.ToStream();

            using var reader = new StreamReader(streamResultado);
            string textoNoStream = reader.ReadToEnd();

            Assert.Equal(textoOriginal, textoNoStream);
        }

    }
}