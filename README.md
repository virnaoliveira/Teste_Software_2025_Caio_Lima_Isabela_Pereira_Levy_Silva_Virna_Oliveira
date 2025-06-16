
# StreamFromString - Teste de Software

Este projeto foi desenvolvido para a disciplina de **Teste de Software**, simulando o cenário da pergunta do Stack Overflow:

> [How do I generate a stream from a string?](https://stackoverflow.com/questions/1879395/how-do-i-generate-a-stream-from-a-string)

O objetivo foi implementar a função sugerida na resposta mais votada e aplicar testes unitários que garantam sua funcionalidade.

## 🚀 Tecnologias utilizadas

- [.NET 8 SDK ou superior](https://dotnet.microsoft.com/en-us/download)
- Linguagem C#
- Framework de testes [xUnit](https://xunit.net/)

## 📂 Estrutura do Projeto

```
/StreamFromString
├── StreamHelper.cs             # Função para gerar um Stream a partir de uma string
└── StreamHelperTests.cs        # Testes unitários usando xUnit
```

## ⚙️ Como executar

1. Clone o repositório:

```bash
git clone https://github.com/virnaoliveira/Teste_Software_2025_Caio_Lima_Isabela_Pereira_Levy_Silva_Virna_Oliveira
cd StreamFromString
```

2. Compile o projeto:

```bash
dotnet build
```

3. Execute os testes:

```bash
dotnet test
```

## 🧪 Cenários de Teste

- ✅ Leitura simples de string
- ✅ String vazia
- ✅ String com caracteres especiais e unicode
- ✅ Validação de múltiplas chamadas produzindo resultados equivalentes

## 📜 Fonte da Solução

Implementação baseada na resposta mais votada desta pergunta no Stack Overflow:  
👉 [https://stackoverflow.com/questions/1879395/how-do-i-generate-a-stream-from-a-string](https://stackoverflow.com/questions/1879395/how-do-i-generate-a-stream-from-a-string)

## 👩‍💻 Desenvolvido para a disciplina de Teste de Software.
