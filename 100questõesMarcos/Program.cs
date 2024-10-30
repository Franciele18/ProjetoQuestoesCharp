using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace QuestoesCSharp
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }

    class FilaAtendimento<T>
    {
        private List<T> elementos;

        public FilaAtendimento()
        {
            elementos = new List<T>();
        }

        public void Enfileirar(T elemento)
        {
            elementos.Add(elemento);
        }

        public T Desenfileirar()
        {
            if (elementos.Count == 0)
            {
                throw new InvalidOperationException("Fila vazia.");
            }
            T elemento = elementos[0];
            elementos.RemoveAt(0);
            return elemento;
        }

        public T Primeiro()
        {
            if (elementos.Count == 0)
            {
                throw new InvalidOperationException("Fila vazia.");
            }
            return elementos[0];
        }

        public int Tamanho()
        {
            return elementos.Count;
        }

        public bool EstaVazia()
        {
            return elementos.Count == 0;
        }
    }
     class ContaBancaria
    {
        public decimal Saldo { get; private set; }

        public ContaBancaria(decimal saldoInicial = 0)
        {
            Saldo = saldoInicial;
            Console.WriteLine($"Conta criada com saldo inicial de R$ {Saldo:F2}");
        }
        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso.");
                ExibirSaldo();
            }
            else
            {
                Console.WriteLine("Valor do depósito inválido!");
            }
        }
        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
                ExibirSaldo();
            }
            else if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                Console.WriteLine("Valor de saque inválido!");
            }
        }
        private void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual é: R$ {Saldo:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu de Questões:");
                Console.WriteLine("1 - Criar Produto e exibir valores");
                Console.WriteLine("3 - Somar dois números inteiros");
                Console.WriteLine("4 - Verificar se um número é par ou ímpar");
                Console.WriteLine("5 - Converter metros para centímetros");
                Console.WriteLine("6 - Verificar se é maior de idade");
                Console.WriteLine("7 - Calcular a área de um círculo");
                Console.WriteLine("8 - Exibir tabuada de um número");
                Console.WriteLine("9 - Somar números de 1 a N");
                Console.WriteLine("10 - Converter Celsius para Fahrenheit");
                Console.WriteLine("11 - Verificar se uma string é nula ou vazia");
                Console.WriteLine("12 - Exibir todos os números pares entre 1 e 50");
                Console.WriteLine("13 - Retornar o maior de três números");
                Console.WriteLine("14 - Inverter uma string");
                Console.WriteLine("15 - Verificar se pode votar (ano de nascimento)");
                Console.WriteLine("16 - Verificar se um número é positivo ou negativo");
                Console.WriteLine("17 - Calcular a média de três notas");
                Console.WriteLine("18 - Contar letras 'a' em uma string");
                Console.WriteLine("19 - Imprimir números de 1 a 10 em ordem decrescente");
                Console.WriteLine("20 - Calcular soma dos quadrados de 1 a N");
                Console.WriteLine("21 - Exibir boas-vindas com nome e idade");
                Console.WriteLine("22 - Exibir o dobro e o triplo de um número");
                Console.WriteLine("23 - Retornar o último caractere de uma string");
                Console.WriteLine("24 - Converter horas em segundos");
                Console.WriteLine("25 - Verificar se um número é divisível por 3 e 5");
                Console.WriteLine("26 - Ordenar três números");
                Console.WriteLine("27 - Calcular Fatorial");
                Console.WriteLine("28 - Exibir Nome e Nota do Aluno");
                Console.WriteLine("29 - Calcular média de uma lista de números");
                Console.WriteLine("30 - Verificar se uma palavra é um palíndromo");
                Console.WriteLine("31 - Encontrar o menor número em um array");
                Console.WriteLine("32 - Multiplicar elementos de um array por um valor");
                Console.WriteLine("33 - Somar números ímpares em um array");
                Console.WriteLine("34 - Criar e exibir informações de carros");
                Console.WriteLine("35 - Verificar se um ano é bissexto");
                Console.WriteLine("36 - Exibir os 10 primeiros números da sequência de Fibonacci");
                Console.WriteLine("37 - Substituir espaços em uma string por '_'");
                Console.WriteLine("38 - Retornar o índice do maior elemento de um array");
                Console.WriteLine("39 - Calcular o MDC (Máximo Divisor Comum)");
                Console.WriteLine("40 - Contar vogais em uma string");
                Console.WriteLine("41 - Converter decimal para binário");
                Console.WriteLine("42 - Exibir número em palavras");
                Console.WriteLine("43 - Simular lançamento de dado");
                Console.WriteLine("44 - Calcular IMC");
                Console.WriteLine("45 - Encontrar o segundo maior número em um array");
                Console.WriteLine("46 - Inverter elementos de um array");
                Console.WriteLine("47 - Somar duas matrizes 2x2");
                Console.WriteLine("48 - Exibir dia da semana");
                Console.WriteLine("49 - Verificar se uma string contém apenas letras e números");
                Console.WriteLine("50 - Calcular potência sem usar Math.Pow()");
                Console.WriteLine("51 - Verificar se uma matriz é simétrica");
                Console.WriteLine("52 - Nomes em ordem alfabetica");
                Console.WriteLine("53 - Encontrar elemento mais frequente em um array");
                Console.WriteLine("54 - Calcular valor absoluto sem Math.Abs()");
                Console.WriteLine("55 - Implementar busca linear");
                Console.WriteLine("56 - Simular cronômetro simples");
                Console.WriteLine("57 - Contar número de palavras em uma string");
                Console.WriteLine("58 - Criar classe Pessoa com método Falar()");
                Console.WriteLine("59 - Interseção entre dois arrays");
                Console.WriteLine("60 - Converter string para maiúsculas e minúsculas alternadas");
                Console.WriteLine("61 - Função que retorna o número de caracteres únicos em uma string");
                Console.WriteLine("62 - Numeros primos");
                Console.WriteLine("63 - Numero perfeito");
                Console.WriteLine("64 - Exibir os divisores de um numero");
                Console.WriteLine("65 - Calcular transposta de uma matriz");
                Console.WriteLine("66 - Exibir horário atual continuamente");
                Console.WriteLine("67 - Simular calculadora simples");
                Console.WriteLine("68 - Converter valor monetário para extenso");
                Console.WriteLine("69 - Calcular média ponderada de notas");
                Console.WriteLine("70 - Simular caixa eletrônico para saques");
                Console.WriteLine("71 - Arrays sao iguais");
                Console.WriteLine("72 - Senha aleatoria");
                Console.WriteLine("73 - Gerar tabela de multiplicação");
                Console.WriteLine("74 - Calcula a área de um triângulo com base em três lados");
                Console.WriteLine("75 - Numeros aleatorios entre 1 e N");
                Console.WriteLine("76 - Adivinhe o número");
                Console.WriteLine("77 - Verificar dois arrays");
                Console.WriteLine("78 - Fila de Atendimento");
                Console.WriteLine("80 - Soma dos Dígitos de um Número");
                Console.WriteLine("81 - Números Pares");
                Console.WriteLine("82 - Média e Maior Valor");
                Console.WriteLine("83 - Ordenação de Nomes");
                Console.WriteLine("84 - Verificar se é um Palindromo");
                Console.WriteLine("85 - Menor e Maior número entre 1 e 50");
                Console.WriteLine("86 - Conta Bancária");
                Console.WriteLine("87 - Cálculo do Salário líquido");
                Console.WriteLine("88 - Conversão de Decimal para Binário");
                Console.WriteLine("89 - Média e Aprovação de Aluno");
                Console.WriteLine("90 - Soma de Elementos de uma Matriz");
                Console.WriteLine("91 - Votação");
                Console.WriteLine("92 - Múltiplos de 3 e 7");
                Console.WriteLine("94 - Ordenação de Números");
                Console.WriteLine("95 - Agenda de Contatos Simples");
                Console.WriteLine("96 - Exibir Números Primos entre 1 e 100");
                Console.WriteLine("97 - Tabuada de Multiplicação até 10");
                Console.WriteLine("98 - Retornar o Maior Número em uma Matriz 3x3");
                Console.WriteLine("99 - Soma dos Quadrados dos Números de 1 a N");
                Console.WriteLine("100 - Jogo da Forca");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ExibirQuestao(Questao1e2);
                        break;
                    case 2:
                        ExibirQuestao(Questao1e2);
                        break;
                    case 3:
                        ExibirQuestao(Questao3);
                        break;
                    case 4:
                        ExibirQuestao(Questao4);
                        break;
                    case 5:
                        ExibirQuestao(Questao5);
                        break;
                    case 6:
                        ExibirQuestao(Questao6);
                        break;
                    case 7:
                        ExibirQuestao(Questao7);
                        break;
                    case 8:
                        ExibirQuestao(Questao8);
                        break;
                    case 9:
                        ExibirQuestao(Questao9);
                        break;
                    case 10:
                        ExibirQuestao(Questao10);
                        break;
                    case 11:
                        ExibirQuestao(Questao11);
                        break;
                    case 12:
                        ExibirQuestao(Questao12);
                        break;
                    case 13:
                        ExibirQuestao(Questao13);
                        break;
                    case 14:
                        ExibirQuestao(Questao14);
                        break;
                    case 15:
                        ExibirQuestao(Questao15);
                        break;
                    case 16:
                        ExibirQuestao(Questao16);
                        break;
                    case 17:
                        ExibirQuestao(Questao17);
                        break;
                    case 18:
                        ExibirQuestao(Questao18);
                        break;
                    case 19:
                        ExibirQuestao(Questao19);
                        break;
                    case 20:
                        ExibirQuestao(Questao20);
                        break;
                    case 21:
                        ExibirQuestao(Questao21);
                        break;
                    case 22:
                        ExibirQuestao(Questao22);
                        break;
                    case 23:
                        ExibirQuestao(Questao23);
                        break;
                    case 24:
                        ExibirQuestao(Questao24);
                        break;
                    case 25:
                        ExibirQuestao(Questao25);
                        break;
                    case 26:
                        ExibirQuestao(Questao26);
                        break;
                    case 27:
                        ExibirQuestao(Questao27);
                        break;
                    case 28:
                        ExibirQuestao(Questao28);
                        break;
                    case 29:
                        ExibirQuestao(Questao29);
                        break;
                    case 30:
                        ExibirQuestao(Questao30);
                        break;
                    case 31:
                        ExibirQuestao(Questao31);
                        break;
                    case 32:
                        ExibirQuestao(Questao32);
                        break;
                    case 33:
                        ExibirQuestao(Questao33);
                        break;
                    case 34:
                        ExibirQuestao(Questao34);
                        break;
                    case 35:
                        ExibirQuestao(Questao35);
                        break;
                    case 36:
                        ExibirQuestao(Questao36);
                        break;
                    case 37:
                        ExibirQuestao(Questao37);
                        break;
                    case 38:
                        ExibirQuestao(Questao38);
                        break;
                    case 39:
                        ExibirQuestao(Questao39);
                        break;
                    case 40:
                        ExibirQuestao(Questao40);
                        break;
                    case 41:
                        ExibirQuestao(Questao41);
                        break;
                    case 42:
                        ExibirQuestao(Questao42);
                        break;
                    case 43:
                        ExibirQuestao(Questao43);
                        break;
                    case 44:
                        ExibirQuestao(Questao44);
                        break;
                    case 45:
                        ExibirQuestao(Questao45);
                        break;
                    case 46:
                        ExibirQuestao(Questao46);
                        break;
                    case 47:
                        ExibirQuestao(Questao47);
                        break;
                    case 48:
                        ExibirQuestao(Questao48);
                        break;
                    case 49:
                        ExibirQuestao(Questao49);
                        break;
                    case 50:
                        ExibirQuestao(Questao50);
                        break;
                    case 51:
                        ExibirQuestao(Questao51);
                        break;
                    case 52:
                        ExibirQuestao(Questao52);
                        break;
                    case 53:
                        ExibirQuestao(Questao53);
                        break;
                    case 54:
                        ExibirQuestao(Questao54);
                        break;
                    case 55:
                        ExibirQuestao(Questao55);
                        break;
                    case 56:
                        ExibirQuestao(Questao56);
                        break;
                    case 57:
                        ExibirQuestao(Questao57);
                        break;
                    case 58:
                        ExibirQuestao(Questao58);
                        break;
                    case 59:
                        ExibirQuestao(Questao59);
                        break;
                    case 60:
                        ExibirQuestao(Questao60);
                        break;
                    case 61:
                        ExibirQuestao(Questao61);
                        break;
                    case 62:
                        ExibirQuestao(Questao62);
                        break;
                    case 63:
                        ExibirQuestao(Questao63);
                        break;
                    case 64:
                        ExibirQuestao(Questao64);
                        break;
                    case 65:
                        ExibirQuestao(Questao65);
                        break;
                    case 66:
                        ExibirQuestao(Questao66);
                        break;
                   /* case 67:
                        ExibirQuestao(Questao67);
                        break;
                    case 68:
                        ExibirQuestao(Questao68);
                        break;*/
                    case 69:
                        ExibirQuestao(Questao69);
                        break;
                    case 70:
                        ExibirQuestao(Questao70);
                        break;
                    case 71:
                        ExibirQuestao(Questao71);
                        break;
                    case 72:
                        ExibirQuestao(Questao72);
                        break;
                    case 73:
                        ExibirQuestao(Questao73);
                        break;
                    case 74:
                        ExibirQuestao(Questao74);
                        break;
                    case 75:
                        ExibirQuestao(Questao75);
                        break;
                    case 76:
                        ExibirQuestao(Questao76);
                        break;
                    case 77:
                        ExibirQuestao(Questao77);
                        break;
                    case 78:
                        ExibirQuestao(Questao78);
                        break;
                    /*case 79:
                        ExibirQuestao(Questao79);
                        break;*/
                    case 80:
                        ExibirQuestao(Questao80);
                        break;
                    case 81:
                        ExibirQuestao(Questao81);
                        break;
                    case 82:
                        ExibirQuestao(Questao82);
                        break;
                    case 83:
                        ExibirQuestao(Questao83);
                        break;
                    case 84:
                        ExibirQuestao(Questao84);
                        break;
                    case 85:
                        ExibirQuestao(Questao85);
                        break;
                    case 86:
                        ExibirQuestao(Questao86);
                        break;
                    case 87:
                        ExibirQuestao(Questao87);
                        break;
                    case 88:
                        ExibirQuestao(Questao88);
                        break;
                    case 89:
                        ExibirQuestao(Questao89);
                        break;
                    case 90:
                        ExibirQuestao(Questao90);
                        break;
                    case 91:
                        ExibirQuestao(Questao91);
                        break;
                    case 92:
                        ExibirQuestao(Questao92);
                        break;
                    /*case 93:
                        ExibirQuestao(Questao93);
                        break;*/
                    case 94:
                        ExibirQuestao(Questao94);
                        break;
                    case 95:
                        ExibirQuestao(Questao95);
                        break;
                    case 96:
                        ExibirQuestao(Questao96);
                        break;
                    case 97:
                        ExibirQuestao(Questao97);
                        break;
                    case 98:
                        ExibirQuestao(Questao98);
                        break;
                    case 99:
                        ExibirQuestao(Questao99);
                        break;
                    case 100:
                        ExibirQuestao(Questao100);
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
        }

        // Método para exibir uma questão e voltar ao menu
        static void ExibirQuestao(Action questao)
        {
            Console.Clear();
            questao();
            Console.WriteLine("\nPressione 'enter' para voltar ao menu");
            Console.ReadKey();
        }
        // Questão 1: Crie uma classe Produto com propriedades Nome e Preco.
        // Questão 2: Instancie um objeto da classe Produto e exiba seus valores.
        static void Questao1e2()
        {
            Produto produto = new Produto { Nome = "Teclado", Preco = 50.90 };
            Console.WriteLine($"Produto: {produto.Nome}, Preço: R$ {produto.Preco}");
        }

        // Questão 3: Crie um método que soma dois números inteiros e exibe o resultado.
        static void Questao3()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int soma = a + b;
            Console.WriteLine($"A soma de {a} e {b} é: {soma}");
        }

        // Questão 4: Escreva uma função que verifica se um número é par ou ímpar.
        static void Questao4()
        {
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} é par.");
            }
            else
            {
                Console.WriteLine($"{num} é ímpar.");
            }
        }

        // Questão 5: Implemente um método que converte um valor em metros para centímetros.
        static void Questao5()
        {
            Console.WriteLine("Digite o valor em metros: ");
            double metros = double.Parse(Console.ReadLine());
            double centimetros = metros * 100;
            Console.WriteLine($"{metros} metros é igual a {centimetros} centímetros.");
        }

        // Questão 6: Crie um programa que recebe a idade e verifica se a pessoa é maior de idade.
        static void Questao6()
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade!");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }
        }

        // Questão 7: Escreva um método que calcula a área de um círculo com base no raio fornecido.
        static void Questao7()
        {
            Console.WriteLine("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"A área do círculo é: {area}");
        }

        // Questão 8: Crie um programa que exibe a tabuada de um número fornecido.
        static void Questao8()
        {
            Console.WriteLine("Digite um número para exibir sua tabuada: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        // Questão 9: Desenvolva um método que soma todos os números de 1 a N.
        static void Questao9()
        {
            Console.WriteLine("Digite um número N: ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                soma += i;
            }
            Console.WriteLine($"A soma dos números de 1 até {N} é: {soma}");
        }

        // Questão 10: Implemente uma função que converte temperatura de Celsius para Fahrenheit.
        static void Questao10()
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C é igual a {fahrenheit}°F");
        }

        // Questão 11: Crie uma função que verifica se uma string é vazia ou nula.
        static void Questao11()
        {
            Console.WriteLine("Digite uma string: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("String vazia ou nula.");
            }
            else
            {
                Console.WriteLine("A string não é nula nem vazia.");
            }
        }

        // Questão 12: Crie uma função que exibe todos os números pares entre 1 e 50.
        static void Questao12()
        {
            Console.WriteLine("Números pares entre 1 e 50:");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Questão 13: Implemente uma função que recebe três números e retorna o maior deles
        static void Questao13()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            int maior = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine($"O maior número é: {maior}");
        }

        //  Questão 14: Crie um programa que inverte uma string.
        static void Questao14()
        {
            Console.WriteLine("Digite uma string para inverter: ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine($"String invertida: {new string(arr)}");
        }

        // Questão 15:  Desenvolva uma função que verifica se uma pessoa pode votar, dado o ano de nascimento.
        static void Questao15()
        {
            Console.WriteLine("Digite o ano de nascimento: (dia.mês.ano)");
            int ano = int.Parse(Console.ReadLine());
            int idade = DateTime.Now.Year - ano;
            if (idade >= 16)
                Console.WriteLine("Você pode votar!");
            else
                Console.WriteLine("Você não pode votar.");
        }

        // Questão 16: Crie uma função que verifica se um número é positivo ou negativo
        static void Questao16()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 0)
                Console.WriteLine($"{numero} é positivo.");
            else
                Console.WriteLine($"{numero} é negativo.");
        }

        // Questão 17:  Implemente um programa que calcula a média de três notas e exibe a situação (Aprovado/Reprovado)
         static void Questao17()
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;
            if (media >= 7.0)
                Console.WriteLine($"Aprovado com média: {media}!");
            else
                Console.WriteLine($"Reprovado com média: {media}");
        }

        // Questão 18:  Escreva uma função que conta quantas letras 'a' existem em uma string.
         static void Questao18()
        {
            Console.WriteLine("Digite uma string: ");
            string str = Console.ReadLine();
            int contador = 0;
            foreach (char c in str.ToLower())
            {
                if (c == 'a')
                    contador++;
            }
            Console.WriteLine($"A letra 'a' aparece {contador} vezes.");
        }

        // Questão 19: Crie um programa que imprime números de 1 a 10 em ordem decrescente.
        static void Questao19()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Questão 20:  Implemente uma função que calcula a soma dos quadrados dos números de 1 a N.
        static void Questao20()
        {
            Console.WriteLine("Digite um número N: ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                soma += i * i;
            }
            Console.WriteLine($"A soma dos quadrados de 1 até {N} é: {soma}");
        }

        // Questão 21: . Crie uma função que recebe o nome e a idade de uma pessoa e exibe uma mensagem de boas-vindas
        static void Questao21()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bem-vindo(a), {nome}! Você tem {idade} anos de idade.");
        }

        // Questão 22: Escreva um programa que recebe um número e exibe seu dobro e triplo.
        static void Questao22()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dobro: {numero * 2}, Triplo: {numero * 3}");
        }

        // Questão 23:  Crie uma função que retorna o último caractere de uma string fornecida
        static void Questao23()
        {
            Console.WriteLine("Digite uma string: ");
            string str = Console.ReadLine();
            if (!string.IsNullOrEmpty(str))
                Console.WriteLine($"Último caractere: {str[str.Length - 1]}");
            else
                Console.WriteLine("String vazia.");
        }

        // Questão 24: Implemente uma função que converte horas em segundos.
        static void Questao24()
        {
            Console.WriteLine("Digite a quantidade de horas: ");
            int horas = int.Parse(Console.ReadLine());
            int segundos = horas * 3600;
            Console.WriteLine($"{horas} horas é igual a {segundos} segundos.");
        }

        // Questão 25:  Crie uma função que verifica se um número é divisível por 3 e por 5.
        static void Questao25()
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 3 == 0 && numero % 5 == 0)
                Console.WriteLine($"{numero} é divisível por 3 e 5.");
            else
                Console.WriteLine($"{numero} não é divisível por 3 e 5.");
        }

        // Questão 26:  Crie uma função que ordena três números fornecidos.
        static void Questao26()
        {
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            int c = int.Parse(Console.ReadLine());

            int[] numeros = { a, b, c };
            Array.Sort(numeros);
            Console.WriteLine("Números em ordem: " + string.Join(", ", numeros));
        }

        // Questão 27:  Desenvolva um programa que calcula o fatorial de um número.
         static void Questao27()
        {
            Console.Write("Digite um número para calcular o fatorial: ");
            int numero = int.Parse(Console.ReadLine());
            long fatorial = Fatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }

        static long Fatorial(int numero)
        {
            if (numero <= 1)
                return 1;
            else
                return numero * Fatorial(numero - 1);
        }

        //  Questão 28: Crie uma classe Aluno com propriedades Nome e Nota. Implemente um método para exibir esses valores.
        static void Questao28()
        {
            Aluno aluno = new Aluno { Nome = "João", Nota = 8.5 };
            aluno.ExibirInformacoes();
        }

        class Aluno
        {
            public string Nome { get; set; }
            public double Nota { get; set; }

            public void ExibirInformacoes()
            {
                Console.WriteLine($"Nome do Aluno: {Nome}");
                Console.WriteLine($"Nota: {Nota}");
            }
        }

        // Questão 29: Implemente um método que calcula a média de uma lista de números.
        static void Questao29()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            double[] numeros = new double[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            double media = numeros.Average();
            Console.WriteLine($"A média é: {media}");
        }

        // Questão 30: Crie um programa que verifica se uma palavra é um palíndromo
        static void Questao30()
        {
            Console.Write("Digite uma palavra para verificar se é um palíndromo: ");
            string palavra = Console.ReadLine();
            string reverso = new string(palavra.Reverse().ToArray());

            if (palavra.Equals(reverso, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("A palavra é um palíndromo!");
            else
                Console.WriteLine("A palavra não é um palíndromo.");
        }

        //  Questão 31: Implemente uma função que encontra o menor número em um array
        static void Questao31()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int menor = numeros.Min();
            Console.WriteLine($"O menor número é: {menor}");
        }

        // Questão 32: Crie uma função que multiplica todos os elementos de um array por um valor fornecido*\
        static void Questao32()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            Console.WriteLine("Digite o valor pelo qual multiplicar os números:");
            int multiplicador = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int[] resultado = numeros.Select(n => n * multiplicador).ToArray();
            Console.WriteLine("Resultado da multiplicação: " + string.Join(", ", resultado));
        }

        // Questão 33:  Desenvolva uma função que retorna a soma dos números ímpares em array
        static void Questao33()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int somaImpares = numeros.Where(n => n % 2 != 0).Sum();
            Console.WriteLine($"A soma dos números ímpares é: {somaImpares}");
        }

        //Questão 34: Crie uma classe Carro com propriedades Marca e Ano
        static void Questao34()
        {
            Console.WriteLine("Digite o nome do carro:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o ano do carro:");
            int ano = int.Parse(Console.ReadLine());

            Carro carro = new Carro { Nome = nome, Ano = ano };
            carro.ExibirInformacoes();
        }

        class Carro
        {
            public string Nome { get; set; }
            public int Ano { get; set; }

            public void ExibirInformacoes()
            {
                Console.WriteLine($"Nome do Carro: {Nome}");
                Console.WriteLine($"Ano: {Ano}");
            }
        }

        //Questão 35: Implemente um método para verificar se um ano é bissexto
        static void Questao35()
        {
            Console.Write("Digite um ano para verificar se é bissexto: ");
            int ano = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(ano))
                Console.WriteLine($"{ano} é um ano bissexto!");
            else
                Console.WriteLine($"{ano} não é um ano bissexto.");
        }

        // Questão 36:Crie uma função que exibe os 10 primeiros números de Fibonacci
        static void Questao36()
        {
            int a = 0, b = 1, c;
            Console.Write("Sequência de Fibonacci: ");
            Console.Write(a + " " + b + " ");

            for (int i = 2; i < 10; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

        // Questão 37: Desenvolva um programa que recebe uma string e substitui todos os espaços por '_'.*/
        static void Questao37()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            string novaFrase = frase.Replace(' ', '_');
            Console.WriteLine("Frase modificada: " + novaFrase);
        }

        //Questão 38: Crie uma função que retorna o índice do maior elemento de um array.
        static void Questao38()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int indiceMaior = Array.IndexOf(numeros, numeros.Max());
            Console.WriteLine($"O índice do maior elemento é: {indiceMaior}");
        }

        // Questão 39:Implemente uma função que calcula o MDC (Máximo Divisor Comum) entre dois números
        static void Questao39()
        {
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int mdc = MDC(a, b);
            Console.WriteLine($"O MDC de {a} e {b} é: {mdc}");
        }

        static int MDC(int a, int b)
        {
            return (b == 0) ? a : MDC(b, a % b);
        }

        //Questão 40: Desenvolva uma função que retorna o número de vogais em uma string.
        static void Questao40()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            int vogais = frase.Count(c => "AEIOUaeiou".Contains(c));
            Console.WriteLine($"A frase possui {vogais} vogais.");
        }

        // Questão 41: Crie uma função que converte um número decimal para binário
        static void Questao41()
        {
            Console.Write("Digite um número decimal: ");
            int numero = int.Parse(Console.ReadLine());
            string binario = Convert.ToString(numero, 2);
            Console.WriteLine($"O número binário é: {binario}");
        }

        // Questão 42:Implemente uma função que recebe um número e exibe sua representação em palavras.
        static void Questao42()
        {
            Console.Write("Digite um número de 0 a 9: ");
            int numero = int.Parse(Console.ReadLine());

            string[] palavras = { "Zero", "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove" };
            if (numero >= 0 && numero <= 9)
                Console.WriteLine($"O número em palavras é: {palavras[numero]}");
            else
                Console.WriteLine("Número fora do intervalo.");
        }

        // Questão 43: Crie um programa que simula o lançamento de um dado 100 vezes e exibe a frequência de
        //cada valor
        static void Questao43()
        {
            Random rand = new Random();
            int[] frequencia = new int[6];

            for (int i = 0; i < 100; i++)
            {
                int valor = rand.Next(1, 7);
                frequencia[valor - 1]++;
            }

            Console.WriteLine("Frequência de cada face (em 100 lançamentos):");
            for (int i = 0; i < frequencia.Length; i++)
                Console.WriteLine($"Face {i + 1}: {frequencia[i]} vezes");
        }

        //Questão 44: Desenvolva uma função que calcula o IMC e determina a categoria (baixo peso, normal, etc.).
        static void Questao44()
        {
            Console.Write("Digite o peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");
        }

        // Questão 45: Crie uma função que encontra o segundo maior número em um array.
        static void Questao45()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int segundoMaior = numeros.OrderByDescending(n => n).Skip(1).FirstOrDefault();
            Console.WriteLine($"O segundo maior número é: {segundoMaior}");
        }

        //Questão 46: Implemente um programa que inverte os elementos de um array.
        static void Questao46()
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numeros);
            Console.WriteLine("Array invertido: " + string.Join(", ", numeros));
        }

        // Questão 47: Crie uma função que soma duas matrizes 2x2.
        static void Questao47()
        {
            int[,] matrizA = new int[2, 2];
            int[,] matrizB = new int[2, 2];
            int[,] soma = new int[2, 2];

            Console.WriteLine("Digite os valores da Matriz A:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite os valores da Matriz B:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    soma[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            Console.WriteLine("Resultado da soma das matrizes é:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(soma[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Questão 48: Desenvolva uma função que recebe uma data e exibe o dia da semana correspondente.
        static void Questao48()
        {
            Console.Write("Digite uma data (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Dia da semana: " + data.ToString("dddd"));
        }

        // Questão 49: Crie um programa que verifica se uma string contém apenas letras e números
        static void Questao49()
        {
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();
            bool isAlfanumerica = input.All(c => char.IsLetterOrDigit(c));
            Console.WriteLine($"A string contém apenas letras e números: {isAlfanumerica}");
        }

        // Questão 50: Implemente uma função que calcula o valor de uma potência sem usar Math.Pow().
        static void Questao50()
        {
            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());

            int resultado = 1;
            for (int i = 0; i < expoente; i++)
            {
                resultado *= baseNum;
            }
            Console.WriteLine($"O resultado é: {resultado}");
        }

        // Questão 51: Crie uma função que verifica se uma matriz é simétrica.
        static void Questao51()
        {
            int[,] matriz = {
                {1, 2, 3},
                {2, 1, 4},
                {3, 4, 1}
            };
            bool simetrica = true;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] != matriz[j, i])
                    {
                        simetrica = false;
                        break;
                    }
                }
            }
            Console.WriteLine(simetrica ? "A matriz é simétrica." : "A matriz não é simétrica.");
        }

        // Questão 52: Desenvolva um programa que ordena uma lista de nomes em ordem alfabética.
        static void Questao52()
        {
            List<string> nomes = new List<string> { "Franciele", "Francinete", "Raimundo", "Eduardo", "Tiago", "Lindomar" };
            nomes.Sort();
            Console.WriteLine("Nomes ordenados:");
            nomes.ForEach(Console.WriteLine);
        }

        // Questão 53: Crie uma função que encontra o elemento mais frequente em um array.
        static void Questao53()
        {
            int[] numeros = { 1, 3, 2, 3, 4, 3, 5 };
            var frequente = numeros.GroupBy(n => n).OrderByDescending(g => g.Count()).First().Key;
            Console.WriteLine($"Elemento frequente: {frequente}");
        }

        // Questão 54: . Implemente uma função que calcula o valor absoluto de um número sem usar Math.Abs().
        static void Questao54()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int absoluto = numero < 0 ? -numero : numero;
            Console.WriteLine($"Valor absoluto: {absoluto}");
        }

        // Questão 55: Crie um programa que implementa o algoritmo de busca linear.
        static void Questao55()
        {
            int[] array = { 10, 20, 30, 40, 50 };
            Console.Write("Digite o número para buscar: ");
            int numero = int.Parse(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == numero)
                {
                    encontrado = true;
                    Console.WriteLine($"Número encontrado na posição {i}!");
                    break;
                }
            }
            if (!encontrado)
                Console.WriteLine("Número não encontrado.");
        }

        // Questão 56: Desenvolva um programa que simula um cronômetro simples (usando Thread.Sleep)
        static void Questao56()
        {
            Console.WriteLine("Cronômetro iniciando... (Pressione Ctrl+C para parar)");
            int segundos = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Tempo: {segundos++} segundos");
                Thread.Sleep(1000);
            }
        }

        // Questão 57: Implemente uma função que calcula o número de palavras em uma string.
        static void Questao57()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            int palavras = frase.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"O número de palavras é: {palavras}");
        }

        // Questão 58: Crie uma classe Pessoa com método Falar() que exibe uma mensagem personalizada.
        public class Pessoa
        {
            public string Nome { get; set; }
            public void Falar()
            {
                Console.WriteLine($"{Nome} diz: Olá!");
            }
        }

        static void Questao58()
        {
            Pessoa pessoa = new Pessoa { Nome = "FranFran!" };
            pessoa.Falar();
        }

        // Questão 59: Crie uma função que retorna a interseção entre dois arrays.
        static void Questao59()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };

            int[] intersecao = array1.Intersect(array2).ToArray();

            Console.WriteLine("Interseção entre os dois arrays:");
            foreach (int num in intersecao)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Questão 60: Desenvolva uma função que converte uma string para maiúsculas e minúsculas alternadas.
        static void Questao60()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            char[] resultado = frase.ToCharArray();
            for (int i = 0; i < resultado.Length; i++)
            {
                resultado[i] = i % 2 == 0 ? char.ToUpper(resultado[i]) : char.ToLower(resultado[i]);
            }
            Console.WriteLine(new string(resultado));
        }

        // Questao 61: Implemente uma função que retorna o número de caracteres únicos em uma string.
        static void Questao61()
        {
            Console.WriteLine("Digite uma string:");
            string input = Console.ReadLine();

            int caracteresUnicos = input.Distinct().Count();
            Console.WriteLine($"Número de caracteres únicos: {caracteresUnicos}");
        }

        // Questão 62:  Crie um programa que exibe os números primos até um valor fornecido.
        static void Questao62()
        {
            Console.WriteLine("Digite um número:");
            if (int.TryParse(Console.ReadLine(), out int limite))
            {
                Console.WriteLine($"Números primos até {limite}: {string.Join(" ", Enumerable.Range(2, limite - 1).Where(n => n > 1 && !Enumerable.Range(2, (int)Math.Sqrt(n) - 1).Any(i => n % i == 0)))}");
            }
            else
            {
                Console.WriteLine("Numero inválido.");
            }
        }

        //Questão 63: Desenvolva uma função que verifica se um número é perfeito.
        static void Questao63()
        {
            Console.Write("Digite um número para verificar se é perfeito: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                bool resultado = EhNumeroPerfeito(numero);
                Console.WriteLine(resultado
                    ? $"{numero} é um número perfeito!"
                    : $"{numero} não é um número perfeito.");
            }
            else
            {
                Console.WriteLine(" Por favor, insira um número inteiro. Entrada inválida!");
            }
        }

        static bool EhNumeroPerfeito(int numero)
        {
            if (numero <= 1) return false;

            int soma = 0;
            for (int i = 1; i <= numero / 2; i++)
            {
                if (numero % i == 0)
                {
                    soma += i;
                }
            }

            return soma == numero;
        }

        // Questão 64: Crie uma função que exibe os divisores de um número.
        static void Questao64()
        {
            Console.WriteLine("Digite um número:");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine($"Divisores de {numero}: {string.Join(" ", Enumerable.Range(1, numero).Where(i => numero % i == 0))}");
            }
            else
            {
                Console.WriteLine("Digite um número inteiro, por favor!");
            }
        }

        //Questão 65: Implemente um método para calcular a transposta de uma matriz.
         static void Questao65()
        {
            int[,] matriz = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int[,] transposta = new int[colunas, linhas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    transposta[j, i] = matriz[i, j];
                }
            }

            Console.WriteLine("Matriz transposta:");
            for (int i = 0; i < colunas; i++)
            {
                for (int j = 0; j < linhas; j++)
                {
                    Console.Write($"{transposta[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        //Questão 66:  Crie um programa que exibe o horário atual continuamente (até ser encerrado).
         static void Questao66()
        {
            Console.WriteLine("Pressione Ctrl+C para encerrar."); 
            while (true)
            {
                Console.Clear(); 
                Console.WriteLine($"(Aperte Ctrl+C para parar)  Horário atual: {DateTime.Now:T}"); // Exibe o horário atual.
                Thread.Sleep(1000); 
            }
        }

        // Questão 67: Calcula uma operação matemática entre dois números

        //Questão 68: Crie um programa que converte valores monetários para extenso.

        // Questão 69:  Implemente um método que calcula a média ponderada de notas.
        static void Questao69()
        {
            Console.Write("Digite a quantidade de notas: "); 
            int quantidade = int.Parse(Console.ReadLine()); 
            double somaPonderada = 0, somaPesos = 0; 
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite a nota {i + 1}: "); 
                double nota = double.Parse(Console.ReadLine()); 
                Console.Write($"Digite o peso da nota {i + 1}: "); 
                double peso = double.Parse(Console.ReadLine()); 

                somaPonderada += nota * peso;
                somaPesos += peso;
            }

            double mediaPonderada = somaPesos != 0 ? somaPonderada / somaPesos : 0;
            Console.WriteLine($"Média ponderada: {mediaPonderada}"); 
        }
        // Questão 70: Crie um programa que simula um caixa eletrônico para saques
        static void Questao70()
        {
            Console.Write("Digite o valor do saque: "); 
            int valor = int.Parse(Console.ReadLine()); 
            int[] notas = { 100, 50, 20, 10, 5, 2 }; 
            Dictionary<int, int> distribuicao = new Dictionary<int, int>(); 
            foreach (int nota in notas)
            {
                int quantidadeNotas = valor / nota;
                if (quantidadeNotas > 0) 
                {
                    distribuicao[nota] = quantidadeNotas; 
                    valor %= nota; 
                }
            }
             if (valor > 0)
            {
                Console.WriteLine("O valor inserido não pode ser sacado com as notas disponíveis.");  
            }
            else
            {
                Console.WriteLine("Distribuição das notas:"); 
                foreach (var kvp in distribuicao) 
                {
                    Console.WriteLine($"{kvp.Value} nota(s) de R$ {kvp.Key}"); 
                }
            }
        }

        // Questão 71: . Desenvolva uma função que verifica se dois arrays são iguais (mesmos elementos e mesma
        //ordem).
        static void Questao71()
        {
            string[] array1 = { "fran", "franfran", "cielly" };
            string[] array2 = { "fran", "franfran", "cielly" };

            bool iguais = array1.Length == array2.Length && !array1.Where((t, i) => t != array2[i]).Any();
            Console.WriteLine(iguais ? "Os arrays são iguais." : "Os arrays não são iguais.");
        }

        // Questão 72: Implemente uma função que gera uma senha aleatória com letras e números
        static void Questao72()
        {
            Console.WriteLine("Digite o tamanho da senha (max 11):");
            if (int.TryParse(Console.ReadLine(), out int comprimento) && comprimento > 0 && comprimento <= 11)
            {
                string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var senha = new HashSet<char>();
                Random random = new Random();

                while (senha.Count < comprimento)
                    senha.Add(caracteres[random.Next(caracteres.Length)]);

                Console.WriteLine($"Senha gerada: {new string(senha.ToArray())}");
            }
        }

        //Questão 73: Crie um programa que gera uma tabela de multiplicação
        static void Questao73()
        {
            Console.Write("Digite um número para gerar sua tabela de multiplicação: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTabela de Multiplicação de {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        //Questão 74: Desenvolva uma função que calcula a área de um triângulo com base em três lados.
        static void Questao74()
        {
            Console.WriteLine("Digite os lados do triângulo:");
            double lado1 = double.Parse(Console.ReadLine());
            double lado2 = double.Parse(Console.ReadLine());
            double lado3 = double.Parse(Console.ReadLine());

            double s = (lado1 + lado2 + lado3) / 2; // Semiperímetro
            double area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));

            Console.WriteLine($"A área do triângulo é: {area}");
        }

        // Questão 75: Crie uma função que gera números aleatórios únicos entre 1 e N.
        static void Questao75()
        {
            Console.WriteLine("Digite o valor de N:");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                var numeros = Enumerable.Range(1, n).OrderBy(_ => Guid.NewGuid()).ToList();
                Console.WriteLine($"Números aleatórios únicos entre 1 e {n}: {string.Join(", ", numeros)}");
            }
        }

        //Questão 76: Crie um jogo de "Adivinhe o Número" entre 1 e 100, dando dicas se o valor é maior ou menor
        static void Questao76()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101); 
            int tentativa = 0;
            int numeroTentativa;
            bool acertou = false;

            Console.WriteLine("Tente adivinhar o número entre 1 e 100.\n");

            // Loop do jogo
            while (!acertou)
            {
                tentativa++;
                Console.Write("Digite sua tentativa: ");

                if (int.TryParse(Console.ReadLine(), out numeroTentativa))
                {
                    if (numeroTentativa < 1 || numeroTentativa > 100)
                    {
                        Console.WriteLine("Insira um número entre 1 e 100, por favor.");
                        continue;
                    }

                    if (numeroTentativa == numeroSecreto)
                    {
                        Console.WriteLine($"Você acertou o número em {tentativa} tentativas!");
                        acertou = true;
                    }
                    else if (numeroTentativa < numeroSecreto)
                    {
                        Console.WriteLine("O número é maior. Tente novamente.\n");
                    }
                    else
                    {
                        Console.WriteLine("O número é menor. Tente novamente.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número. Entrada inválida! ");
                }
            }
        }

        // Questão 77: Implemente uma função que verifica se dois arrays possuem os mesmos elementos,
        //independentemente da ordem.

        static void Questao77()
        {
            string[] array1 = { "maçã", "banana", "laranja", "5" };
            string[] array2 = { "laranja", "maçã", "banana" };

            bool iguais = array1.Length == array2.Length && !array1.Except(array2).Any();
            Console.WriteLine(iguais ? "Possui os mesmos elementos." : "Não possui os mesmos elementos.");
        }

        //Questão 78: Crie uma função que simula uma fila de atendimento (FIFO) usando List<T>.
        static void Questao78()
        {
            var fila = new FilaAtendimento<string>();
            Console.WriteLine("Digite os nomes de todos os clientes (digite 'parar' para encerrar):");

            while (true)
            {
                Console.Write("Cliente: ");
                string cliente = Console.ReadLine();

                if (cliente.ToLower() == "parar")
                {
                    break;
                }
                fila.Enfileirar(cliente);
            }

            Console.WriteLine($"\nTamanho da fila: {fila.Tamanho()}");

            while (!fila.EstaVazia())
            {
                Console.WriteLine($"Atendendo: {fila.Desenfileirar()}");
            }

            Console.WriteLine("Todos os clientes foram atendidos!");
        }

        //Questão 79: Desenvolva um jogo simples de "Pedra, Papel e Tesoura" que joga contra o computador.

       //Questão 80: Crie um programa que calcula a soma dos dígitos de um número fornecido pelo usuário.
        static void Questao80()
        {
            Console.Write("Digite um número (maior ou igual a 2 dígitos): ");
            string numero = Console.ReadLine();
            int soma = 0;

            foreach (char c in numero)
            {
                if (char.IsDigit(c))
                {
                    soma += int.Parse(c.ToString());
                }
            }

            Console.WriteLine($"A soma dos dígitos do número {numero} é: {soma}");
        }

        //Questão 81: Implemente uma função que encontra e exibe os números pares em uma lista.
        static void Questao81()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Digite a quantidade de números que você deseja adicionar à lista:");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());
                numeros.Add(numero);
            }

            ExibirNumerosPares(numeros);
        }

        static void ExibirNumerosPares(List<int> numeros)
        {
            Console.WriteLine("\nNúmeros pares na lista:");
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }

        //Questão 82: Desenvolva um programa que lê valores do usuário e exibe a média e o maior valor  informado.
        static void Questao82()
        {
            List<double> valores = new List<double>();
            string input;

            Console.WriteLine("Digite valores numéricos (digite 'sair' para encerrar):");
            while (true)
            {
                Console.Write("Digite um valor: ");
                input = Console.ReadLine();

                if (input.ToLower() == "sair")
                {
                    break;
                }

                if (double.TryParse(input, out double valor))
                {
                    valores.Add(valor);
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número. Entrada inválida!");
                }
            }

            if (valores.Count > 0)
            {
                double soma = 0;
                foreach (var valor in valores)
                {
                    soma += valor;
                }
                double media = soma / valores.Count;
                double maiorValor = double.MinValue;
                foreach (var valor in valores)
                {
                    if (valor > maiorValor)
                    {
                        maiorValor = valor;
                    }
                }

                Console.WriteLine($"\nMédia dos valores: {media:F2}");
                Console.WriteLine($"Maior valor informado: {maiorValor}");
            }
            else
            {
                Console.WriteLine("Nenhum valor foi informado.");
            }
        }

        //Questão 83: Crie um programa que armazena 10 nomes e os exibe em ordem alfabética.
        static void Questao83()
        {
            string[] nomes = new string[10];
            Console.WriteLine("Digite 10 nomes:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }

            Array.Sort(nomes);
            Console.WriteLine("\nNomes em ordem alfabética:");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        //Questão 84:  Implemente uma função que verifica se uma string é um palíndromo(lida da mesma forma ao
       //contrário).
        static void Questao84()
        {
            Console.Write("Digite uma palavra ou frase para verificar se é um palíndromo: ");
            string entrada = Console.ReadLine();

            bool resultado = EhPalindromo(entrada);
            Console.WriteLine(resultado
                ? "É um palíndromo."
                : "Não é um palíndromo.");
        }

        static bool EhPalindromo(string texto)
        {
            string textoFormatado = texto.Replace(" ", "").ToLower();

            int inicio = 0;
            int fim = textoFormatado.Length - 1;

            while (inicio < fim)
            {
                if (textoFormatado[inicio] != textoFormatado[fim])
                {
                    return false;
                }
                inicio++;
                fim--;
            }

            return true;
        }

       //Questão 85: Crie um programa que gere 10 números aleatórios entre 1 e 50 e exiba o menor e o maior.
        static void Questao85()
        {
            Random random = new Random();
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 51);
            }

            Console.WriteLine("Números gerados: " + string.Join(", ", numeros));

            int menor = numeros.Min();
            int maior = numeros.Max();

            Console.WriteLine($"Menor número: {menor}");
            Console.WriteLine($"Maior número: {maior}");
        }

        //Questão 86: Desenvolva uma classe ContaBancaria com métodos para depósito e saque e exiba o saldo
        //após cada operação.
        static void Questao86()
        {
            Console.Write("Digite o saldo inicial da conta: ");
            decimal saldoInicial = decimal.Parse(Console.ReadLine());

            ContaBancaria conta = new ContaBancaria(saldoInicial);

            while (true)
            {
                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1 - Depósito");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("Digite o valor do depósito: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                }
                else if (opcao == "2")
                {
                    Console.Write("Digite o valor do saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                }
                else if (opcao == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }
            }
        }

        //Questão 87:  Implemente um programa que calcula o salário líquido de um funcionário com base no salário
       //bruto e desconto de 10%.
        static void Questao87()
        {
            Console.Write("Digite o salário bruto do funcionário: R$ ");
            decimal salarioBruto = decimal.Parse(Console.ReadLine());

            decimal desconto = salarioBruto * 0.10m;

            decimal salarioLiquido = salarioBruto - desconto;

            Console.WriteLine($"\nSalário Bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"Desconto (10%): R$ {desconto:F2}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");
        }

        //Questão 88: Crie uma função que converte um número decimal para sua representação binária
        static void Questao88()
        {
            Console.Write("Digite um número decimal para converter para binário: ");
            int numeroDecimal = int.Parse(Console.ReadLine());

            string binario = DecimalParaBinario(numeroDecimal);
            Console.WriteLine($"O número {numeroDecimal} em binário é: {binario}");
        }

        static string DecimalParaBinario(int numeroDecimal)
        {
            string binario = "";
            if (numeroDecimal == 0) return "0";

            while (numeroDecimal > 0)
            {
                int resto = numeroDecimal % 2;
                binario = resto + binario;
                numeroDecimal /= 2;
            }

            return binario;
        }

       //Questão 89: Desenvolva um programa que recebe três notas e exibe se o aluno foi aprovado,
       //considerando média >= 7.
        static void Questao89()
        {
            Console.WriteLine("Digite as três notas do aluno:");
            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"\nMédia do aluno: {media:F2}");

            if (media >= 7)
            {
                Console.WriteLine("O aluno foi aprovado.");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado.");
            }
        }

        //Questão 90: Implemente uma função que soma todos os elementos de uma matriz 2x2.
        static void Questao90()
        {
            int[,] matriz = new int[2, 2];
            Console.WriteLine("Digite os elementos da matriz 2x2:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int soma = SomarElementosMatriz(matriz);
            Console.WriteLine($"\nA soma de todos os elementos da matriz é: {soma}");
        }

        static int SomarElementosMatriz(int[,] matriz)
        {
            int soma = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    soma += matriz[i, j];
                }
            }
            return soma;
        }

        //Questão 91:  Crie um programa que simula uma votação com três candidatos e exibe o vencedor ao final.
        static void Questao91()
        {
            int votosCandidato1 = 0;
            int votosCandidato2 = 0;
            int votosCandidato3 = 0;

            Console.Write("Digite o número de eleitores: ");
            int numeroEleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("\nVotação: Escolha 1, 2 ou 3 para os candidatos.");
            Console.WriteLine("1 - Candidato 1");
            Console.WriteLine("2 - Candidato 2");
            Console.WriteLine("3 - Candidato 3");

            for (int i = 1; i <= numeroEleitores; i++)
            {
                Console.Write($"\nVoto do eleitor {i}: ");
                int voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                        votosCandidato1++;
                        break;
                    case 2:
                        votosCandidato2++;
                        break;
                    case 3:
                        votosCandidato3++;
                        break;
                    default:
                        Console.WriteLine("Voto inválido! Escolha 1, 2 ou 3.");
                        i--; 
                        break;
                }
            }

            Console.WriteLine("\nResultado da votação:");
            Console.WriteLine($"Candidato 1: {votosCandidato1} votos");
            Console.WriteLine($"Candidato 2: {votosCandidato2} votos");
            Console.WriteLine($"Candidato 3: {votosCandidato3} votos");

            if (votosCandidato1 > votosCandidato2 && votosCandidato1 > votosCandidato3)
            {
                Console.WriteLine("O vencedor é o Candidato 1!");
            }
            else if (votosCandidato2 > votosCandidato1 && votosCandidato2 > votosCandidato3)
            {
                Console.WriteLine("O vencedor é o Candidato 2!");
            }
            else if (votosCandidato3 > votosCandidato1 && votosCandidato3 > votosCandidato2)
            {
                Console.WriteLine("O vencedor é o Candidato 3!");
            }
            else
            {
                Console.WriteLine("A votação terminou empatada!");
            }
        }

        //Questão 92:Desenvolva um programa que verifica se um número fornecido é múltiplo de 3 e 7 ao mesmo
        //tempo
        static void Questao92()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 3 == 0 && numero % 7 == 0)
            {
                Console.WriteLine($"O número {numero} é múltiplo de 3 e 7 ao mesmo tempo.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não é múltiplo de 3 e 7 ao mesmo tempo.");
            }
        }

        //Questão 93: Implemente um programa que calcula a distância entre dois pontos no plano cartesiano
        //(fórmula da distância).


        //Questão 94: Crie uma função que gera uma lista de 5 números aleatórios e os exibe em ordem crescente.
        static void Questao94()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Digite números para ordenar (digite 'sair' para encerrar):");

            while (true)
            {
                Console.Write("Número: ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "sair")
                {
                    break;
                }

                if (int.TryParse(entrada, out int numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                }
            }

            numeros.Sort();
            Console.WriteLine("\nNúmeros em ordem crescente:");
            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }
        }

        static List<Contato> agenda = new List<Contato>();

        //Questão 95: Desenvolva uma agenda de contatos simples que permite adicionar e listar nomes e números
        //de telefone.
        static void Questao95()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Agenda de Contatos:");
                Console.WriteLine("1 - Adicionar Contato");
                Console.WriteLine("2 - Listar Contatos");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarContato();
                        break;
                    case 2:
                        ListarContatos();
                        break;
                }
            } while (opcao != 0);
        }
        static void AdicionarContato()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o número de telefone: ");
            string telefone = Console.ReadLine();
            agenda.Add(new Contato { Nome = nome, Telefone = telefone });
            Console.WriteLine("Contato adicionado com sucesso!");
        }

        static void ListarContatos()
        {
            Console.WriteLine("Contatos:");
            foreach (var contato in agenda)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}");
            }
            Console.WriteLine("\nPressione 'enter' para voltar ao menu");
            Console.ReadKey();
        }

        //Questão 96:  Implemente uma função que exibe todos os números primos entre 1 e 100.
        static void Questao96()
        {
            Console.WriteLine("Números primos entre 1 e 100:");
            for (int i = 2; i <= 100; i++)
            {
                if (EhPrimo(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static bool EhPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        //Questão 97: Crie um programa que recebe um número e exibe sua tabuada de multiplicação até 10.
        static void Questao97()
        {
            Console.Write("Digite um número para exibir sua tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada de {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }

        //Questão 98: Desenvolva uma função que retorna o maior número em uma matriz 3x3.
         static void Questao98()
        {
            int[,] matriz = {
                { 1, 5, 3 },
                { 4, 9, 2 },
                { 7, 6, 8 }
            };

            int maior = MaiorNumero(matriz);
            Console.WriteLine($"O maior número na matriz é: {maior}");
        }

        static int MaiorNumero(int[,] matriz)
        {
            int maior = matriz[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }
            }
            return maior;
        }

        //Questão 99:  Implemente um programa que calcula a soma dos quadrados dos números de 1 a N
        static void Questao99()
        {
            Console.Write("Digite um número N: ");
            int N = int.Parse(Console.ReadLine());
            int soma = SomaDosQuadrados(N);
            Console.WriteLine($"A soma dos quadrados dos números de 1 a {N} é: {soma}");
        }

        static int SomaDosQuadrados(int N)
        {
            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                soma += i * i;
            }
            return soma;
        }

        class Contato
        {
            public string Nome { get; set; }
            public string Telefone { get; set; }
        }

        //Questão 100: Crie um jogo simples de "Forca" onde o usuário tenta adivinhar uma palavra em até 5
        //tentativas.
        static void Questao100()
        {
            string palavra = "FRANCIELE SANTOS DA SILVA MAIS MAIS";

            int tamanho = palavra.Length;

            char[] descobertas = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                descobertas[i] = '_';
            }

            int tentativas = 5;

            Console.WriteLine("Jogo de Forca!");

            while (tentativas > 0)
            {
                Console.WriteLine("\nPalavra: " + string.Join(" ", descobertas));
                Console.WriteLine($"Tentativas restantes: {tentativas}");

                Console.Write("Digite uma letra: ");
                string letra = Console.ReadLine().ToUpper();

                bool acertou = false;
                for (int i = 0; i < tamanho; i++)
                {
                    if (palavra[i] == letra[0])
                    {
                        descobertas[i] = letra[0];
                        acertou = true;
                    }
                }

                if (string.Join("", descobertas) == palavra)
                {
                    Console.WriteLine("/nVocê Ganhou. Parabéns!");
                    return;
                }

                if (!acertou)
                {
                    tentativas--;
                    Console.WriteLine("Letra não encontrada!");
                }
            }

            Console.WriteLine("\nGame Over! A palavra era: " + palavra);
        }
    }
}