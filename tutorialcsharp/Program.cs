using System;

namespace tutorialcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //roda aqui o exercicio que quiser!!!!!!!!!!!!!!!!!!!!!!!!!
        }

        static void ex1()
        {
            Console.WriteLine("Digite a quantidade mínima de peças: ");
            int qtdMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade máxima peças: ");
            int qtdMax = int.Parse(Console.ReadLine());
            int estoque = (qtdMin + qtdMax) / 2;
            Console.WriteLine("O estoque médio de peças é: " + estoque);
        }

        static void ex2()
        {
            Console.WriteLine("\nDigite a cotação do dólar: ");
            double dolae = double.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite o valor em dólares: ");
            double valor = double.Parse(System.Console.ReadLine());
            double reais = dolae * valor;
            Console.WriteLine("O valor em reais é: R$" + reais);
        }

        static void ex3()
        {
            Console.WriteLine("Digite o preço unitário da peça: ");
            double preco = double.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite a quantidade vendida: ");
            int qtd = int.Parse(System.Console.ReadLine());
            double valor = preco * qtd;
            double comissao = valor * 0.05;
            Console.WriteLine("O valor total da venda é: R$" + valor);
            Console.WriteLine("O valor da comissão é: R$" + comissao);
        }

        static void ex4()
        {
            Console.WriteLine("\nDigite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o quarto valor: ");
            int valor4 = int.Parse(Console.ReadLine());

            Console.WriteLine("A sm de " + valor1 + " com " + valor2 + " = " + (valor1 + valor2));
            Console.WriteLine("A sm de " + valor1 + " com " + valor3 + " = " + (valor1 + valor3));
            Console.WriteLine("A sm de " + valor1 + " com " + valor4 + " = " + (valor1 + valor4));
            Console.WriteLine("A sm de " + valor2 + " com " + valor3 + " = " + (valor2 + valor3));
            Console.WriteLine("A sm de " + valor2 + " com " + valor4 + " = " + (valor2 + valor4));
            Console.WriteLine("A sm de " + valor3 + " com " + valor4 + " = " + (valor3 + valor4));
            
            Console.WriteLine("A multi de " + valor1 + " com " + valor2 + " = " + (valor1 * valor2));
            Console.WriteLine("A multi de " + valor1 + " com " + valor3 + " = " + (valor1 * valor3));
            Console.WriteLine("A multi de " + valor1 + " com " + valor4 + " = " + (valor1 * valor4));
            Console.WriteLine("A multi de " + valor2 + " com " + valor3 + " = " + (valor2 * valor3));
            Console.WriteLine("A multi de " + valor2 + " com " + valor4 + " = " + (valor2 * valor4));
            Console.WriteLine("A multi de " + valor3 + " com " + valor4 + " = " + (valor3 * valor4));
        }

        static void ex5()
        {
            Console.WriteLine("\nDigite o tempo gasto na viagem: ");
            double tempo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média: ");
            double velocidade = double.Parse(Console.ReadLine());

            double distancia = tempo * velocidade;
            double litros = distancia / 12;

            Console.WriteLine("A velocidade média é: " + velocidade);
            Console.WriteLine("O tempo gasto na viagem é: " + tempo);
            Console.WriteLine("A distância percorrida é: " + distancia);
            Console.WriteLine("A quantidade de litros é: " + litros);
        }

        static void ex6()
        {
            Console.WriteLine("\nDigite a temperatura em °C: ");
            double c = double.Parse(Console.ReadLine());

            double fr = (9 * c + 160) / 5;

            Console.WriteLine("A temperatura em graus Fahrenheit é: " + fr + "°F");
        }

        static void ex7()
        {
            Console.WriteLine("\nDigite a temperatura em graus fr: ");
            double fr = double.Parse(Console.ReadLine());

            double c = (fr - 32) * 5 / 9;

            Console.WriteLine("A temperatura em graus celsius é: " + c + "°C");
        }

        static void ex8()
        {
            Console.WriteLine("\nDigite o raio da lata de oleo: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da lata de oleo: ");
            double h = double.Parse(Console.ReadLine());

            double v = 3.14159 * r * r * h;

            Console.WriteLine("O volume da lata de oleo é: " + v);
        }

        static void ex9()
        {
            Console.WriteLine("\nDigite a idade em anos: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade em meses: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade em dias: ");
            int d = int.Parse(Console.ReadLine());

            int id = a * 365 + m * 30 + d;

            Console.WriteLine("A idade em dias é: " + id);
        }

        static void ex10()
        {
            Console.WriteLine("\nDigite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Os números são iguais");
            }
            else if (n1 != n2)
            {
                Console.WriteLine("Os números são diferentes");
            }
            else if (n1 > n2)
            {
                Console.WriteLine("O primeiro número é maior que o segundo");
            }
            else if (n1 < n2)
            {
                Console.WriteLine("O primeiro número é menor que o segundo");
            }
            else if (n1 >= n2)
            {
                Console.WriteLine("O primeiro número é maior ou igual ao segundo");
            }
            else if (n1 <= n2)
            {
                Console.WriteLine("O primeiro número é menor ou igual ao segundo");
            }
        }

        static void ex11()
        {
            Console.WriteLine("\nDigite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            (n1, n2) = (n2, n1);

            Console.WriteLine("O primeiro número é: " + n1);
            Console.WriteLine("O segundo número é: " + n2);
        }

        static void ex12()
        {
            Console.WriteLine("\nDigite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("O módulo do número é: " + num);
            }
            else
            {
                Console.WriteLine("O módulo do número é: " + num * (-1));
            }
        }

        static void ex13()
        {
            Console.WriteLine("\nDigite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                if (n2 > n3)
                {
                    Console.WriteLine("A ordem decrescente é: " + n1 + " " + n2 + " " + n3);
                }
                else
                {
                    Console.WriteLine("A ordem decrescente é: " + n1 + " " + n3 + " " + n2);
                }
            }
            else if (n2 > n1 && n2 > n3)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("A ordem decrescente é: " + n2 + " " + n1 + " " + n3);
                }
                else
                {
                    Console.WriteLine("A ordem decrescente é: " + n2 + " " + n3 + " " + n1);
                }
            }
            else if (n3 > n1 && n3 > n2)
            {
                if (n1 > n2)
                {
                    Console.WriteLine("A ordem decrescente é: " + n3 + " " + n1 + " " + n2);
                }
                else
                {
                    Console.WriteLine("A ordem decrescente é: " + n3 + " " + n2 + " " + n1);
                }
            }
        }

        static void ex14()
        {
            Console.WriteLine("\nDigite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("A diferença do maior para o menor é: " + (n1 - n2));
            }
            else
            {
                Console.WriteLine("A diferença do maior para o menor é: " + (n2 - n1));
            }
        }

        static void ex15()
        {
            Console.WriteLine("\nDigite a primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            double n4 = double.Parse(Console.ReadLine());

            double med = (n1 + n2 + n3 + n4) / 4;

            if (med >= 7)
            {
                Console.WriteLine("O aluno foi aprovado com média: " + med);
            }
            else
            {
                Console.WriteLine("Digite a nota da recuperação: ");
                double nRecup = double.Parse(Console.ReadLine());

                double novamed = (med + nRecup) / 2;

                if (novamed >= 7)
                {
                    Console.WriteLine("O aluno foi aprovado na recuperação com média: " + novamed);
                }
                else
                {
                    Console.WriteLine("O aluno foi reprovado com média: " + novamed);
                }
            }
        }

        static void ex16()
        {
            Console.WriteLine("\nDigite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O maior número é: " + n1);
                Console.WriteLine("O menor número é: " + n2);
            }
            else if (n2 > n1)
            {
                Console.WriteLine("O maior número é: " + n2);
                Console.WriteLine("O menor número é: " + n1);
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }

        static void ex17()
        {
            Console.WriteLine("\nDigite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0 && num <= 9)
            {
                Console.WriteLine("Valor válido.");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }

        static void ex18()
        {
            Console.WriteLine("\nDigite um número inteiro: ");
            int cod = int.Parse(Console.ReadLine());

            switch (cod)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                default:
                    Console.WriteLine("Código inválido.");
                    break;
            }
        }

        static void ex19()
        {
            Console.WriteLine("\nDigite o primeiro lado do triângulo: ");
            int lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado do triângulo: ");
            int lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado do triângulo: ");
            int lado3 = int.Parse(Console.ReadLine());

            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os lados fornecidos não caracterizam um triângulo.");
            }
        }

        static void ex20()
        {
            Console.WriteLine("\nDigite o primeiro número inteiro: ");
            int a = int.Parse(Console.ReadLine());

            while (a <= 0)
            {
                Console.WriteLine("Número inválido. Digite novamente: ");
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o segundo número inteiro: ");
            int b = int.Parse(Console.ReadLine());

            while (b <= 0)
            {
                Console.WriteLine("Número inválido. Digite novamente: ");
                b = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o terceiro número inteiro: ");
            int c = int.Parse(Console.ReadLine());

            while (c <= 0)
            {
                Console.WriteLine("Número inválido. Digite novamente: ");
                c = int.Parse(Console.ReadLine());
            }

            if (a < b && a < c)
            {
                Console.WriteLine("O menor número é: " + a);
                Console.WriteLine("O maior número é: " + Math.Max(b, c));
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("O menor número é: " + b);
                Console.WriteLine("O maior número é: " + Math.Max(a, c));
            }
            else
            {
                Console.WriteLine("O menor número é: " + c);
                Console.WriteLine("O maior número é: " + Math.Max(a, b));
            }
        }

        static void ex21()
        {
            String resposta = "s";
            while (resposta == "s" || resposta == "S")
            {
                Console.WriteLine("\nDigite um número inteiro: ");
                int num = int.Parse(Console.ReadLine());

                if (num >= 0)
                {
                    Console.WriteLine("Número positivo.");
                }
                else
                {
                    Console.WriteLine("Número negativo.");
                }

                Console.WriteLine("Deseja continuar? (s/n)");
                resposta = Console.ReadLine();
            }
        }

        static void ex22()
        {
            Console.WriteLine("\nDigite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("Número positivo.");
            }
            else
            {
                Console.WriteLine("Número negativo.");
            }
        }

        static void ex23()
        {
            Console.WriteLine("\nDigite o primeiro número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a opção desejada: ");
            Console.WriteLine("1 – Adição" +
                              "\n2 – Subtração" +
                              "\n3 – Multiplicação" +
                              "\n4 – Divisão");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao > 4 || opcao < 1)
            {
                Console.WriteLine("Opção inválida. Digite novamente:");
                opcao = int.Parse(Console.ReadLine());
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("A sm dos números é: " + (n1 + n2));
                    break;
                case 2:
                    Console.WriteLine("A subtração dos números é: " + (n1 - n2));
                    break;
                case 3:
                    Console.WriteLine("A multiplicação dos números é: " + (n1 * n2));
                    break;
                case 4:
                    Console.WriteLine("A divisão dos números é: " + (n1 / n2));
                    break;
            }
        }

        static void ex24()
        {
            Console.WriteLine("\nDigite o primeiro número inteiro: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a opção desejada: " +
                              "\n1 – Verificar se um dos números lidos é ou não múltiplo do outro"
                              + "\n2 – Verificar se os dois números lidos são pares"
                              + "\n3 – Verificar se a média dos dois números é maior ou igual a 7."
                              + "\n4 – Sair");

            int opcao = int.Parse(Console.ReadLine());

            while (opcao > 4)
            {
                Console.WriteLine("Opção inválida. Digite novamente:");
                opcao = int.Parse(Console.ReadLine());
            }

            switch (opcao)
            {
                case 1:
                    if (a % b == 0 || b % a == 0)
                    {
                        Console.WriteLine("Um dos números é múltiplo do outro.");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                    }

                    break;
                case 2:
                    if (a % 2 == 0 && b % 2 == 0)
                    {
                        Console.WriteLine("Os dois números são pares.");
                    }
                    else
                    {
                        Console.WriteLine("Os dois números não são pares.");
                    }

                    break;
                case 3:
                    if ((a + b) / 2 >= 7)
                    {
                        Console.WriteLine("A média dos dois números é maior ou igual a 7.");
                    }
                    else
                    {
                        Console.WriteLine("A média dos dois números é menor que 7.");
                    }

                    break;
            }
        }

        static void ex25()
        {
            Console.WriteLine("\nDigite a altura da pessoa: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexo da pessoa: ");
            string sexo = Console.ReadLine();

            while (sexo != "m" || sexo != "f" || sexo != "F" || sexo != "M")
            {
                Console.WriteLine("Sexo inválido");
                sexo = Console.ReadLine();
            }

            if (sexo == "M" || sexo == "m")
            {
                Console.WriteLine("O peso ideal é: " + (72.7 * altura - 58));
            }
            else
            {
                Console.WriteLine("O peso ideal é: " + (62.1 * altura - 44.7));
            }
        }

        static void ex26()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void ex27()
        {
            Console.WriteLine("\nDigite a quantidade de números que deverá processar: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite o número que deverá processar: ");
                int num = int.Parse(Console.ReadLine());

                int ft = 1;
                for (int j = 1; j <= num; j++)
                {
                    ft *= j;
                }

                Console.WriteLine("O ft do número " + num + " é: " + ft);
            }
        }

        static void ex28()
        {
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ex29()
        {
            for (int i = 1; i <= 2000; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void ex30()
        {
            Console.WriteLine("\nDigite o número que deseja ver a tabuada: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
        }

        static void ex31()
        {
            int num = 0;
            int smPares = 0;
            int smImpares = 0;

            while (num >= 0)
            {
                Console.WriteLine("Digite um número inteiro (digite um negativo para parar): ");
                num = int.Parse(Console.ReadLine());

                if (num >= 0)
                {
                    if (num % 2 == 0)
                    {
                        smPares += num;
                    }
                    else
                    {
                        smImpares += num;
                    }
                }
            }

            Console.WriteLine("A sm dos números pares é: " + smPares);
            Console.WriteLine("A sm dos números ímpares é: " + smImpares);
        }

        static void ex32()
        {
            Console.WriteLine("\nDigite um número inteiro entre 0 e 10: ");
            int num = int.Parse(Console.ReadLine());

            while (num <= 0 || num >= 10)
            {
                Console.WriteLine("Número inválido. Digite novamente: ");
                num = int.Parse(Console.ReadLine());
            }

            int sm = 0;
            for (int i = 1; i <= 20; i++)
            {
                sm += (num * num);
                num += 2;
            }

            Console.WriteLine("A sm dos quadrados dos 20 primeiros números ímpares a partir do número digitado é: " +
                              sm);
        }

        static void ex33()
        {
            int matricula, cont = 0;
            double nota, med = 0;

            Console.WriteLine("Digite a matricula do aluno: ");
            matricula = int.Parse(Console.ReadLine());

            while (matricula != 0)
            {
                Console.WriteLine("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                med += nota;
                cont++;
                Console.WriteLine("Digite a matricula do aluno: ");
                matricula = int.Parse(Console.ReadLine());
            }

            med = med / cont;
            Console.WriteLine("A med da turma é: " + med);
        }

        static void ex34()
        {
            int num, menor = 0, maior = 0;

            Console.WriteLine("Digite um num: ");
            num = int.Parse(Console.ReadLine());

            while (num >= 0)
            {
                if (num < menor)
                {
                    menor = num;
                }
                else if (num > maior)
                {
                    maior = num;
                }

                Console.WriteLine("Digite um num: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O menor num é: " + menor);
            Console.WriteLine("O maior num é: " + maior);
        }

        static void ex35()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine("Múltiplo de 10");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ex36()
        {
            int num, maior = 0, menor = 0, med = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um num: ");
                num = int.Parse(Console.ReadLine());

                if (num > maior)
                {
                    maior = num;
                }
                else if (num < menor)
                {
                    menor = num;
                }

                med += num;
            }

            med = med / 10;
            Console.WriteLine("O maior num é: " + maior);
            Console.WriteLine("O menor num é: " + menor);
            Console.WriteLine("A med dos nums é: " + med);
        }

        static void ex37()
        {
            int opcao, num1, num2, resultado;
            char resposta;

            do
            {
                Console.WriteLine("1 – Adição");
                Console.WriteLine("2 – Subtração");
                Console.WriteLine("3 – Multiplicação");
                Console.WriteLine("4 – Divisão");
                Console.WriteLine("Informe a opção: ");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o primeiro num: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo num: ");
                num2 = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("O resultado da sm é: " + resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("O resultado da subtração é: " + resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("O resultado da multiplicação é: " + resultado);
                        break;
                    case 4:
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão é: " + resultado);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Deseja voltar ao menu principal? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'S' || resposta == 's');
        }

        static void ex38()
        {
            int cod, hrsTrab, salario, salarioEx;
            char resposta;

            do
            {
                Console.WriteLine("Digite o codigo do operario: ");
                cod = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o num de horas trabalhadas: ");
                hrsTrab = int.Parse(Console.ReadLine());

                if (hrsTrab > 50)
                {
                    salario = hrsTrab * 10;
                    salarioEx = (hrsTrab - 50) * 20;
                }
                else
                {
                    salario = hrsTrab * 10;
                    salarioEx = 0;
                }

                Console.WriteLine("O salario total é: " + salario);
                Console.WriteLine("O salario excedente é: " + salarioEx);
                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');
        }

        static void ex39()
        {
            int num;
            char resposta;

            do
            {
                Console.WriteLine("Digite um num: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("O num é par");
                }
                else
                {
                    Console.WriteLine("O num é impar");
                }

                if (num > 0)
                {
                    Console.WriteLine("O num é positivo");
                }
                else
                {
                    Console.WriteLine("O num é negativo");
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');
        }

        static void ex40()
        {
            double indice;
            char resposta;

            do
            {
                Console.WriteLine("Digite o indice de poluição: ");
                indice = double.Parse(Console.ReadLine());

                if (indice >= 0.05 && indice <= 0.25)
                {
                    Console.WriteLine("Indice aceitavel");
                }
                else if (indice >= 0.3 && indice < 0.4)
                {
                    Console.WriteLine("Industrias do 1o grupo devem suspender suas atividades");
                }
                else if (indice >= 0.4 && indice < 0.5)
                {
                    Console.WriteLine("Industrias do 1o e 2o grupo devem suspender suas atividades");
                }
                else if (indice >= 0.5)
                {
                    Console.WriteLine("Todos os grupos devem suspender suas atividades");
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');
        }

        static void ex41()
        {
            int idade;
            char resposta;

            do
            {
                Console.WriteLine("Digite a idade do nadador: ");
                idade = int.Parse(Console.ReadLine());

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Infantil A");
                }
                else if (idade >= 8 && idade <= 11)
                {
                    Console.WriteLine("Infantil B");
                }
                else if (idade >= 12 && idade <= 13)
                {
                    Console.WriteLine("Juvenil A");
                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Juvenil B");
                }
                else if (idade >= 18)
                {
                    Console.WriteLine("Adulto");
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');
        }

        static void ex42()
        {
            int num, maior = 0, menor = 0;
            char resposta;

            do
            {
                Console.WriteLine("Digite um num: ");
                num = int.Parse(Console.ReadLine());

                if (num > maior)
                {
                    maior = num;
                }
                else if (num < menor)
                {
                    menor = num;
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');

            Console.WriteLine("O maior num é: " + maior);
            Console.WriteLine("O menor num é: " + menor);
        }

        static void ex43()
        {
            int numQuadros = 64; // Número total de quadros no tabuleiro de xadrez
            ulong graos = 1;
            ulong graosTotais = 1;

            for (int quadro = 2; quadro <= numQuadros; quadro++)
            {
                graos *= 2;
                graosTotais += graos;
            }

            Console.WriteLine("O monge esperava receber um total de {0} grãos.", graosTotais);
        }

        static void ex44()
        {
            int opcao;
            char resposta;

            do
            {
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("1 – Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 – Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 – Peso ideal do homem");
                Console.WriteLine("4 – Peso ideal da mulher");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a temperatura em Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);
                        break;
                    case 2:
                        Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                        fahrenheit = double.Parse(Console.ReadLine());
                        celsius = (fahrenheit - 32) * 5 / 9;
                        Console.WriteLine("A temperatura em Celsius é: " + celsius);
                        break;
                    case 3:
                        Console.WriteLine("Digite a altura: ");
                        double altura = double.Parse(Console.ReadLine());
                        double pesoIdeal = (72.7 * altura) - 58;
                        Console.WriteLine("O peso ideal é: " + pesoIdeal);
                        break;
                    case 4:
                        Console.WriteLine("Digite a altura: ");
                        altura = double.Parse(Console.ReadLine());
                        pesoIdeal = (62.1 * altura) - 44.7;
                        Console.WriteLine("O peso ideal é: " + pesoIdeal);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                resposta = char.Parse(Console.ReadLine());
            } while (resposta == 'N' || resposta == 'n');
        }

        static void ex45()
        {
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um num: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        static void ex46()
        {
            int[] vetorX = new int[10];
            int[] vetorY = new int[10];
            int produtoEscalar = 0;

            for (int i = 0; i < vetorX.Length; i++)
            {
                Console.WriteLine("Digite um num para o vetor X: ");
                vetorX[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorY.Length; i++)
            {
                Console.WriteLine("Digite um num para o vetor Y: ");
                vetorY[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorX.Length; i++)
            {
                produtoEscalar += vetorX[i] * vetorY[i];
            }

            Console.WriteLine("O produto escalar é: " + produtoEscalar);
        }

        static void ex47()
        {
            int[] vetor = new int[10];
            int numX, maior = 0, menor = 0, igual = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um num: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite um num X: ");
            numX = int.Parse(Console.ReadLine());

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > numX)
                {
                    maior++;
                }
                else if (vetor[i] < numX)
                {
                    menor++;
                }
                else
                {
                    igual++;
                }
            }

            Console.WriteLine("qtd de nums maiores que X: " + maior);
        }

        static void ex48()
        {
            string[] nome = new string[20];
            int[] idade = new int[20];

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine("Digite o nome da candidata: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite a idade da candidata: ");
                idade[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nome.Length; i++)
            {
                if (idade[i] >= 18 && idade[i] <= 20)
                {
                    Console.WriteLine("Nome: " + nome[i]);
                }
            }
        }

        static void ex49()
        {
            int[] vetor1 = new int[50];
            int[] vetor2 = new int[50];
            int contador = 0;

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Digite um num para o vetor 1: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Digite um num para o vetor 2: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] == vetor2[i])
                {
                    contador++;
                }
            }

            Console.WriteLine("Quantidade de numeros iguais: " + contador);
        }

        static void ex50()
        {
            Random random = new Random();
            int numSorteado = random.Next(0, 100);
            int numTentativa, contador = 0;

            do
            {
                Console.WriteLine("Digite um num: ");
                numTentativa = int.Parse(Console.ReadLine());
                contador++;

                if (numTentativa > numSorteado)
                {
                    Console.WriteLine("O num sorteado é menor");
                }
                else if (numTentativa < numSorteado)
                {
                    Console.WriteLine("O num sorteado é maior");
                }
            } while (numTentativa != numSorteado);

            Console.WriteLine("qtd de tentativas: " + contador);
            if (contador < 5)
            {
                Console.WriteLine("Tu é pit.");
            }
        }

        static void pinga()
        {
            int qtdAlunos, contador = 0;
            double nota, med, sm = 0;

            Console.WriteLine("Digite a qtd de alunos: ");
            qtdAlunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.WriteLine("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                sm += nota;

                if (nota > 7)
                {
                    contador++;
                }
            }

            med = sm / qtdAlunos;

            if (contador == 0)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 7.");
            }
            else
            {
                Console.WriteLine("qtd de alunos com nota acima de 7: " + contador);
            }

            Console.WriteLine("med das notas: " + med);
        }

        static void ex52()
        {
            int[] vetor = new int[100];
            int contador1 = 0, contador3 = 0, contador4 = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um num: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] == 1)
                {
                    contador1++;
                }
                else if (vetor[i] == 3)
                {
                    contador3++;
                }
                else if (vetor[i] == 4)
                {
                    contador4++;
                }

                if (vetor[i] == -1)
                {
                    break;
                }
            }

            Console.WriteLine("qtd de 1: " + contador1);
            Console.WriteLine("qtd de 3: " + contador3);
            Console.WriteLine("qtd de 4: " + contador4);
        }

        static void ex53()
        {
            int qtdVoltas, melhorTempo = 0, voltaMelhorTempo = 0;
            double tempoMedio, sm = 0;

            Console.WriteLine("Digite a qtd de voltas: ");
            qtdVoltas = int.Parse(Console.ReadLine());

            int[] vetor = new int[qtdVoltas];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o tempo da volta: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    melhorTempo = vetor[i];
                    voltaMelhorTempo = i + 1;
                }
                else if (vetor[i] < melhorTempo)
                {
                    melhorTempo = vetor[i];
                    voltaMelhorTempo = i + 1;
                }

                sm += vetor[i];
            }

            tempoMedio = sm / qtdVoltas;

            Console.WriteLine("Melhor tempo: " + melhorTempo);
            Console.WriteLine("Volta do melhor tempo: " + voltaMelhorTempo);
            Console.WriteLine("Tempo medio: " + tempoMedio);
        }

        static void ex54()
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[8];

            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.WriteLine("Digite um num: ");
                vetorA[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.WriteLine("Digite um num: ");
                vetorB[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorA.Length; i++)
            {
                for (int j = 0; j < vetorB.Length; j++)
                {
                    if (vetorA[i] == vetorB[j])
                    {
                        Console.WriteLine("num comum: " + vetorA[i]);
                    }
                }
            }
        }

        static void ex55()
        {
            string frase;
            int contador = 0;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    contador++;
                }
            }

            Console.WriteLine("Frase sem espacos: " + frase.Replace(" ", ""));
            Console.WriteLine("qtd de espacos: " + contador);
        }

        static void ex56()
        {
            int[] vetor = new int[50];
            int contadorPar = 0, contadorMultiplo5 = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um num: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    contadorPar++;
                }

                if (vetor[i] % 5 == 0)
                {
                    contadorMultiplo5++;
                }
            }

            Console.WriteLine("qtd de nums pares: " + contadorPar);
            Console.WriteLine("qtd de multiplos de 5: " + contadorMultiplo5);
        }

        static void ex57()
        {
            string frase;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                {
                    Console.WriteLine("Vogal: " + frase[i]);
                }
            }
        }

        static void ex58()
        {
            int qtdnums, maior = 0, sm = 0;
            double med;

            Console.WriteLine("Digite a qtd de nums: ");
            qtdnums = int.Parse(Console.ReadLine());

            int[] vetor = new int[qtdnums];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um num: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maior = vetor[i];
                }
                else if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }

                sm += vetor[i];
            }

            med = sm / qtdnums;

            Console.WriteLine("Maior num: " + maior);
            Console.WriteLine("med: " + med);
        }

        static void ex59()
        {
            char letra1, letra2;
            int contador = 0;

            Console.WriteLine("Digite uma letra: ");
            letra1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite outra letra: ");
            letra2 = char.Parse(Console.ReadLine());

            if (letra1 < letra2)
            {
                for (int i = letra1 + 1; i < letra2; i++)
                {
                    contador++;
                }

                Console.WriteLine("num de caracteres entre eles: " + contador);
            }
            else
            {
                Console.WriteLine("Erro!");
            }
        }

        static void ex60()
        {
            int x, y;

            Console.WriteLine("Digite o valor de x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de y: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Quadrante: " + verificaQuadrante(x, y));
        }

        static int verificaQuadrante(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        static void ex61()
        {
            double salario, indiceReajuste;

            Console.WriteLine("Digite o salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o indice de reajuste: ");
            indiceReajuste = double.Parse(Console.ReadLine());

            Console.WriteLine("Salario reajustado: " + reajuste(salario, indiceReajuste));
        }

        static double reajuste(double salario, double indiceReajuste)
        {
            double salarioReajustado;

            salarioReajustado = salario + (salario * (indiceReajuste / 100));

            return salarioReajustado;
        }

        static void ex62()
        {
            double baseTriangulo, alturaTriangulo;

            Console.WriteLine("Digite a base do triangulo: ");
            baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do triangulo: ");
            alturaTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Hipotenusa: " + hipotenusa(baseTriangulo, alturaTriangulo));
        }

        static double hipotenusa(double baset, double alturat)
        {
            double hipo;

            hipo = Math.Sqrt(Math.Pow(baset, 2) + Math.Pow(alturat, 2));

            return hipo;
        }

        static void ex63()
        {
            int num;

            Console.WriteLine("Digite um num: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(verifica(num));
        }

        static string verifica(int num)
        {
            if (num % 2 == 0)
            {
                return "PAR";
            }
            else
            {
                return "IMPAR";
            }
        }

        static void ex64()
        {
            int opcao, qtdnums;

            Console.WriteLine("Digite a qtd de nums: ");
            qtdnums = int.Parse(Console.ReadLine());

            int[] vetor = new int[qtdnums];

            do
            {
                Console.WriteLine("1 - Carregar Vetor");
                Console.WriteLine("2 - Listar Vetor");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                Console.WriteLine("5 - Exibir a qtd de números pares existem nas posições ímpares do vetor");
                Console.WriteLine("6 - Exibir a qtd de números ímpares existem nas posições pares do vetor");
                Console.WriteLine("7 - Sair");
                Console.WriteLine("Digite uma opcao: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        carregaVetor(vetor);
                        break;
                    case 2:
                        listarVetor(vetor);
                        break;
                    case 3:
                        exibePares(vetor);
                        break;
                    case 4:
                        exibeImpares(vetor);
                        break;
                    case 5:
                        exibeParesImpares(vetor);
                        break;
                    case 6:
                        exibeImparesPares(vetor);
                        break;
                    case 7:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
            } while (opcao != 7);
        }

        static void carregaVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um num: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        static void listarVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }

        static void exibePares(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        static void exibeImpares(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        static void exibeParesImpares(int[] vetor)
        {
            int qtdPares = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (vetor[i] % 2 == 0)
                    {
                        qtdPares++;
                    }
                }
            }

            Console.WriteLine("Quantidade de pares nas posicoes impares: " + qtdPares);
        }

        static void exibeImparesPares(int[] vetor)
        {
            int qtdImpares = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (vetor[i] % 2 != 0)
                    {
                        qtdImpares++;
                    }
                }
            }

            Console.WriteLine("Quantidade de impares nas posicoes pares: " + qtdImpares);
        }
    }
}