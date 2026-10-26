# TED Faculdade: coletânea de exercícios em C#

Aplicação de console em **C# (.NET 10)** que reúne, em um único menu, vários exercícios de lógica de programação feitos como trabalho da faculdade.

## Para que serve

Praticar os fundamentos de C#: entrada e saída no console, condicionais, laços, validação de dados, organização do código em classes/arquivos e leitura/gravação de arquivos de texto.

## O que o programa faz

Menu principal (`TED.cs`):

| Opção | Exercício | O que faz |
|---|---|---|
| 1 | **Calcular média** | Lê o nome do aluno e 3 notas (0 a 10). Calcula a média e informa: **Aprovado** (≥ 7), **Recuperação** (≥ 6) ou **Reprovado**. |
| 2 | **Classificador de IMC** | Lê peso e altura, calcula o IMC e classifica: abaixo do peso, normal, sobrepeso ou obesidade. |
| 3 | **Calculadora** | Soma, subtração, multiplicação e divisão (com proteção contra divisão por zero). |
| 4 | **Tabuada personalizada** | Gera a tabuada de 1 a 10 do número escolhido. |
| 5 | **Somador com condição de parada** | Soma os números digitados até aparecer `0` ou um número negativo. |
| 6 | **Validação de senha** | Pede a senha repetidamente até o usuário acertar. |
| 7 | **Conversor de temperaturas** | Celsius ↔ Fahrenheit e Celsius ↔ Kelvin. O menu já lista Fahrenheit ↔ Kelvin, que ainda não foi implementado. Faz uma conversão e volta ao menu. |
| 8 | **Mini caixa eletrônico (BankGui)** | Criar conta, entrar, ver saldo, depositar e sacar, com dados salvos em arquivos de texto. |
| 0 | Sair | |

## Estrutura

```
├── TED.cs                    # menu principal
├── TEDFACULDADE.csproj / .sln
└── Bibliotecas/
    ├── CalcularMedia.cs
    ├── ClassificarCorporalIMC.cs
    ├── CalculadoraMenu.cs
    ├── TabuadaPersonalizada.cs
    ├── CondicaodeParada.cs
    ├── ValidarSenha.cs
    ├── ConversorTemperaturasUniversais.cs
    └── BankGui/              # caixa eletrônico: BankGui.cs, Contas.cs, contas.txt, saldos.txt
```

Cada exercício fica em seu próprio arquivo e `namespace`, chamado pelo menu.

## Como executar

Pré-requisito: [.NET SDK 10](https://dotnet.microsoft.com/download).

```bash
git clone https://github.com/guilherf/TedTrabalho.git
cd TedTrabalho
dotnet run
```

## Observações

- O BankGui é um simulador **didático**: contas e saldos ficam em arquivos `.txt` e as senhas são gravadas em texto puro. Não use dados reais.
- O projeto também existe de forma independente em [BankGui](https://github.com/guilherf/BankGui).

## Autor

Guilherme Ferreira — [@guilherf](https://github.com/guilherf)
