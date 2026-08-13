# Teste de Lógica — C# 🚀

Esse repositório tem as minhas resoluções do teste técnico de lógica de programação.  
Fiz todas as questões em **C#** (Console Application) no **.NET**.

Tentei deixar o código limpo, tratar os casos estranhos e pensar um pouco na performance de cada solução.

---

## 📌 Sumário

1. [Como testar meu código](#1-como-testar-meu-código)
2. [Como organizei as pastas](#2-como-organizei-as-pastas)
3. [Resumo das Questões](#3-resumo-das-questões)
4. [Tecnologias](#4-tecnologias)
5. [Observações](#5-observações)

---

## 1. Como testar meu código

Pra facilitar a correção, criei um menu interativo com o arquivo `menu.bat`.

### Jeito mais fácil

Dê dois cliques no `menu.bat` ou rode no terminal:

```bash
.\menu.bat
Ele abre um menu e já executa a questão que você escolher.
Jeito manual
Bashcd questao1
dotnet run

2. Como organizei as pastas
Cada questão ficou no seu próprio projeto:
text📁 Teste-logica/
 ├── 📁 questao1/          # Soma de pares
 ├── 📁 questao2/          # Segundo maior número
 ├── 📁 questao3/          # Parênteses válidos
 ├── 📁 questao4/          # Two Sum
 ├── 📁 questao5/          # Contagem de caracteres
 ├── 📁 questao6/          # Número desaparecido
 ├── 📁 bonus/             # Palíndromo
 ├── 📄 menu.bat
 └── 📄 README.md

3. Resumo das Questões
Questão 1 — Soma de pares
Soma só os números pares. Se só tiver ímpar, retorna 0.
Questão 2 — Segundo maior número
Acha o segundo maior número (sem repetir). Se não tiver, mostra erro.
Questão 3 — Parênteses válidos
Verifica se (), {} e [] estão balanceados (usei Stack).
Questão 4 — Two Sum
Acha as posições de dois números que somam o target (versão otimizada).
Questão 5 — Contagem de caracteres
Conta quantas vezes cada letra aparece na string.
Questão 6 — Número desaparecido
Descobre o número que está faltando de 0 até n (usei Gauss).
Questão Bônus — Palíndromo
Verifica se a palavra/frase é um palíndromo (ignorando espaços, pontuação e maiúscula/minúscula).

4. Tecnologias

C# / .NET
Batch Script (menu.bat)


5. Observações

Cada questão está isolada no seu projeto
Tentei tratar os casos de borda
O menu.bat é só pra facilitar a correção no Windows
