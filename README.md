
🧪 Teste de Software - Simulação de Cenário Stack Overflow

Este repositório tem como objetivo simular o cenário apresentado na pergunta do Stack Overflow:

👉 How do I create a unit test case to get maximum code coverage for my debounce and throttle functions?

Aqui iremos implementar a solução proposta pela resposta mais votada e desenvolver testes unitários focados na maximização da cobertura de código, utilizando práticas ensinadas na disciplina de Teste de Software.


---

🗂️ Estrutura do Repositório

📦 debounce-throttle-test
 ┣ 📂 src
 ┃ ┣ debounce.js
 ┃ ┗ throttle.js
 ┣ 📂 tests
 ┃ ┣ debounce.test.js
 ┃ ┗ throttle.test.js
 ┣ 📜 README.md
 ┣ 📜 package.json
 ┗ 📜 jest.config.js


---

🎯 Objetivo

Implementar as funções debounce e throttle conforme descrito na resposta mais votada da pergunta.

Criar testes unitários que cubram os principais fluxos de execução das funções, buscando máxima cobertura de código (code coverage).

Aplicar conceitos de:

Testes unitários

Análise de cobertura

Testes baseados em tempo (temporizadores)

Teste de funções assíncronas




---

🚀 Tecnologias Utilizadas

Node.js

Jest – Framework de testes

Sinon (opcional) – Mock de timers (caso necessário)

Babel (opcional) – Para suporte a ES6+



---

🔧 Instalação

1. Clone o repositório:



git clone https://github.com/seu-usuario/debounce-throttle-test.git
cd debounce-throttle-test

2. Instale as dependências:



npm install


---

🏗️ Scripts Disponíveis

Rodar os testes:


npm test

Gerar relatório de cobertura:


npm run coverage


---

🧠 Descrição da Solução

📌 Função debounce

> A função debounce garante que uma função só será executada após um certo período sem ser chamada novamente. Útil para reduzir o número de chamadas em eventos como digitação, redimensionamento de janela, etc.



📌 Função throttle

> A função throttle garante que uma função seja executada no máximo uma vez dentro de um intervalo de tempo específico, mesmo que seja chamada diversas vezes.




---

🧪 Cenário de Teste

Validação de execução após o tempo limite (debounce)

Garantir que múltiplas chamadas dentro do tempo sejam ignoradas (debounce)

Verificar que a função é executada no primeiro clique e bloqueada até o tempo passar (throttle)

Testes com timers simulados para controle preciso

Testes de borda (ex.: tempo exatamente igual ao limite)



---

📊 Cobertura de Código

Após rodar:

npm run coverage

Será gerado um relatório como este (exemplo):

File	% Stmts	% Branch	% Funcs	% Lines

debounce.js	100%	100%	100%	100%
throttle.js	100%	100%	100%	100%



---

📄 Referência

Stack Overflow: Pergunta Original

Resposta utilizada: Resposta mais votada da pergunta acima



---

👩‍💻 Desenvolvedores


