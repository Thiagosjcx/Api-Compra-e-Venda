Aqui está uma versão mais limpa e que deve renderizar direito no GitHub:

```markdown
# Teste de Lógica — C#

Esse repositório tem as minhas resoluções do teste técnico de lógica de programação.  
Fiz todas as questões em **C#** (Console Application) no **.NET**.

Tentei deixar o código limpo, tratar os casos estranhos e pensar um pouco na performance de cada solução.

---

## Sumário

1. [Como testar meu código](#1-como-testar-meu-código)
2. [Como organizei as pastas](#2-como-organizei-as-pastas)
3. [Resumo das Questões](#3-resumo-das-questões)
4. [Tecnologias](#4-tecnologias)
5. [Observações](#5-observações)

---

## 1. Como testar meu código

Pra facilitar a correção, criei um menu interativo com o arquivo `menu.bat`.

**Jeito mais fácil:**

```bash
.\menu.bat
```

Ele abre um menu e já executa a questão que você escolher.

**Jeito manual:**

```bash
cd questao1
dotnet run
```

---

## 2. Como organizei as pastas

Cada questão ficou no seu próprio projeto:

```
Teste-logica/
├── questao1/          # Soma de pares
├── questao2/          # Segundo maior número
├── questao3/          # Parênteses válidos
├── questao4/          # Two Sum
├── questao5/          # Contagem de caracteres
├── questao6/          # Número desaparecido
├── bonus/             # Palíndromo
├── menu.bat
└── README.md
```

---

## 3. Resumo das Questões

**Questão 1 — Soma de pares**  
Soma apenas os números pares. Se só tiver números ímpares, retorna 0.

**Questão 2 — Segundo maior número**  
Encontra o segundo maior número distinto. Caso não exista segundo maior, retorna mensagem de erro.

**Questão 3 — Parênteses válidos**  
Verifica se a string com `()`, `{}` e `[]` está corretamente balanceada. Utilizei a estrutura **Stack**.

**Questão 4 — Two Sum**  
Encontra as posições de dois números que somados resultam no target. Implementei uma versão otimizada.

**Questão 5 — Contagem de caracteres**  
Conta quantas vezes cada caractere aparece na string.

**Questão 6 — Número desaparecido**  
Descobre o número faltante em uma sequência de 0 até n. Utilizei a fórmula de Gauss.

**Questão Bônus — Palíndromo**  
Verifica se a palavra ou frase é um palíndromo. Ignora espaços, pontuação e diferença entre maiúsculas e minúsculas.

---

## 4. Tecnologias

- C# / .NET
- Batch Script (`menu.bat`)

---

## 5. Observações

- Cada questão está isolada no seu próprio projeto
- Tentei tratar os casos de borda
- O `menu.bat` facilita a correção no Windows
```
