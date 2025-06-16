# 📦 String to Stream

Este projeto foi desenvolvido como parte da disciplina **Teste de Software**. O objetivo é implementar uma função que transforma uma **string comum em um Readable Stream** no Node.js, além de construir testes unitários para validar seu comportamento.

O projeto foi inspirado na pergunta do Stack Overflow:  
**“How do I generate a stream from a string?”**  
🔗 https://stackoverflow.com/questions/1879395

---

## 🚀 Tecnologias Utilizadas

- **Node.js** – Ambiente de execução JavaScript.
- **Jest** – Framework de testes unitários.
- **JavaScript (ES6+)** – Linguagem de programação.

---

## 📥 Instalação

1. Clone este repositório:

```bash
git clone https://github.com/virnaoliveira/Teste_Software_2025_Caio_Lima_Isabela_Pereira_Levy_Silva_Virna_Oliveira.git
```
2. Acesse a pasta do projeto:
   
```
bash
cd string-to-stream
```
3. Instale as dependências:

```
bash
npm install
```
---
## 🧠 Como Usar a Função
A função stringToStream transforma uma string em um Readable Stream.

Exemplo de uso:

```
const { stringToStream } = require('./src/stringToStream');

const stream = stringToStream('Olá, mundo!');

stream.on('data', (chunk) => {
  console.log(`Recebido: ${chunk}`);
});

stream.on('end', () => {
  console.log('Leitura concluída.');
});
```
Resultado esperado no console:

```
Recebido: Olá, mundo!
Leitura concluída.
```

---
## 🔬 Como Executar os Testes
Para rodar os testes unitários:

```
npm test
```
O Jest executará os testes localizados na pasta /tests e apresentará o resultado, além da cobertura de código.

## 🔎 Gerar Relatório de Cobertura
Execute:

```
npx jest --coverage
```
---

Será exibido um relatório no terminal e também gerado um diretório /coverage com arquivos HTML para visualização detalhada.

## 📂 Estrutura do Projeto
```
string-to-stream/
├── src/
│   └── stringToStream.js          # Implementação da função
├── tests/
│   └── stringToStream.test.js     # Testes com Jest
├── README.md                      # Documentação do projeto
├── relatorio.md                   # Relatório acadêmico
├── package.json                    # Configurações do projeto
└── jest.config.js                  # Configurações opcionais do Jest

```

## 👨‍🏫 Disciplina
Projeto desenvolvido para a disciplina de Teste de Software, com o objetivo de aplicar conceitos de:

- Criação de testes unitários.
- Manipulação de Streams no Node.js.
- Garantia de cobertura de código e validação de funcionalidades.


