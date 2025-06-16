
# StreamFromString - Teste de Software

Este projeto foi desenvolvido para a disciplina de **Teste de Software**, com base na pergunta do Stack Overflow:

> [How do I generate a stream from a string?](https://stackoverflow.com/questions/1879395/how-do-i-generate-a-stream-from-a-string)

O objetivo foi implementar a função sugerida na resposta mais votada e aplicar testes unitários para validar sua funcionalidade.

## 🚀 Tecnologias Utilizadas

- [.NET 8 SDK ou superior](https://dotnet.microsoft.com/en-us/download)
- Linguagem **C#**
- Framework de testes: [xUnit](https://xunit.net/)

## 📁 Estrutura do Projeto

```
StreamFromStringSolution
├── StreamFromString/                  # Biblioteca principal
│   └── StreamHelper.cs                # Função para gerar um Stream a partir de uma string
├── StreamFromString.Tests/           # Projeto de testes
│   └── StreamHelperTests.cs          # Testes unitários com xUnit
└── StreamFromStringSolution.sln      # Solução .NET
```

## ⚙️ Como Executar

1. **Clone o repositório:**

```bash
git clone https://github.com/virnaoliveira/Teste_Software_2025_Caio_Lima_Isabela_Pereira_Levy_Silva_Virna_Oliveira
cd Teste_Software_2025_Caio_Lima_Isabela_Pereira_Levy_Silva_Virna_Oliveira
```

2. **Compile a solução:**

```bash
dotnet build
```

3. **Execute os testes:**

```bash
dotnet test
```

## 🧪 Cenários de Teste

- ✅ Leitura simples de string
- ✅ String vazia
- ✅ String com caracteres especiais e Unicode
- ✅ Validação de múltiplas chamadas com resultados equivalentes

## 📜 Fonte da Solução

A implementação foi baseada na resposta mais votada da seguinte pergunta no Stack Overflow:  
👉 [https://stackoverflow.com/questions/1879395/how-do-i-generate-a-stream-from-a-string](https://stackoverflow.com/questions/1879395/how-do-i-generate-a-stream-from-a-string)

## 👩‍💻 Desenvolvido para a disciplina de Teste de Software
