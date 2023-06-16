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
            int quantidadeMinima = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade máxima peças: ");
            int quantidadeMaxima = int.Parse(Console.ReadLine());
            int estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2;
            Console.WriteLine("O estoque médio de peças é: " + estoqueMedio);
        }

        static void ex2()
        {
            Console.WriteLine("\nDigite a cotação do dólar: ");
            double cotacaoDolar = double.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite o valor em dólares: ");
            double valorDolar = double.Parse(System.Console.ReadLine());
            double valorReal = cotacaoDolar * valorDolar;
            Console.WriteLine("O valor em reais é: R$" + valorReal);
        }

        static void ex3()
        {
            Console.WriteLine("\nDigite o código do vendedor: ");
            int codigoVendedor = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite o código da peça: ");
            int codigoPeca = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite o preço unitário da peça: ");
            double precoUnitario = double.Parse(System.Console.ReadLine());
            Console.WriteLine("Digite a quantidade vendida: ");
            int quantidadeVendida = int.Parse(System.Console.ReadLine());
            double valorTotal = precoUnitario * quantidadeVendida;
            double comissao = valorTotal * 0.05;
            Console.WriteLine("O valor total da venda é: R$" + valorTotal);
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

            Console.WriteLine("A soma de " + valor1 + " com " + valor2 + " é: " + (valor1 + valor2));
            Console.WriteLine("A soma de " + valor1 + " com " + valor3 + " é: " + (valor1 + valor3));
            Console.WriteLine("A soma de " + valor1 + " com " + valor4 + " é: " + (valor1 + valor4));
            Console.WriteLine("A soma de " + valor2 + " com " + valor3 + " é: " + (valor2 + valor3));
            Console.WriteLine("A soma de " + valor2 + " com " + valor4 + " é: " + (valor2 + valor4));
            Console.WriteLine("A soma de " + valor3 + " com " + valor4 + " é: " + (valor3 + valor4));
            
            Console.WriteLine("A multiplicação de " + valor1 + " com " + valor2 + " é: " + (valor1 * valor2));
            Console.WriteLine("A multiplicação de " + valor1 + " com " + valor3 + " é: " + (valor1 * valor3));
            Console.WriteLine("A multiplicação de " + valor1 + " com " + valor4 + " é: " + (valor1 * valor4));
            Console.WriteLine("A multiplicação de " + valor2 + " com " + valor3 + " é: " + (valor2 * valor3));
            Console.WriteLine("A multiplicação de " + valor2 + " com " + valor4 + " é: " + (valor2 * valor4));
            Console.WriteLine("A multiplicação de " + valor3 + " com " + valor4 + " é: " + (valor3 * valor4));
        }

        static void ex5()
        {
            Console.WriteLine("\nDigite o tempo gasto na viagem: ");
            double tempo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média: ");
            double velocidade = double.Parse(Console.ReadLine());

            double distancia = tempo * velocidade;
            double litrosUsados = distancia / 12;

            Console.WriteLine("A velocidade média é: " + velocidade + "km/h");
            Console.WriteLine("O tempo gasto na viagem é: " + tempo + "h");
            Console.WriteLine("A distância percorrida é: " + distancia + "km");
            Console.WriteLine("A quantidade de litros utilizada na viagem é: " + litrosUsados + "L");
        }

        static void ex6()
        {
            Console.WriteLine("\nDigite a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine("A temperatura em graus Fahrenheit é: " + fahrenheit + "°F");
        }

        static void ex7()
        {
            Console.WriteLine("\nDigite a temperatura em graus Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("A temperatura em graus Celsius é: " + celsius + "°C");
        }

        static void ex8()
        {
            Console.WriteLine("\nDigite o raio da lata de óleo: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da lata de óleo: ");
            double altura = double.Parse(Console.ReadLine());

            double volume = 3.14159 * raio * raio * altura;

            Console.WriteLine("O volume da lata de óleo é: " + volume);
        }

        static void ex9()
        {
            Console.WriteLine("\nDigite a idade em anos: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade em meses: ");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade em dias: ");
            int dias = int.Parse(Console.ReadLine());

            int idadeDias = anos * 365 + meses * 30 + dias;

            Console.WriteLine("A idade em dias é: " + idadeDias);
        }

        static void ex10()
        {
            Console.WriteLine("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("Os números são iguais");
            }
            else if (numero1 != numero2)
            {
                Console.WriteLine("Os números são diferentes");
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("O primeiro número é maior que o segundo");
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("O primeiro número é menor que o segundo");
            }
            else if (numero1 >= numero2)
            {
                Console.WriteLine("O primeiro número é maior ou igual ao segundo");
            }
            else if (numero1 <= numero2)
            {
                Console.WriteLine("O primeiro número é menor ou igual ao segundo");
            }
        }

        static void ex11()
        {
            Console.WriteLine("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            (numero1, numero2) = (numero2, numero1);

            Console.WriteLine("O primeiro número é: " + numero1);
            Console.WriteLine("O segundo número é: " + numero2);
        }

        static void ex12()
        {
            Console.WriteLine("\nDigite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("O módulo do número é: " + numero);
            }
            else
            {
                Console.WriteLine("O módulo do número é: " + numero * (-1));
            }
        }

        static void ex13()
        {
            Console.WriteLine("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                if (numero2 > numero3)
                {
                    Console.WriteLine("A ordem decrescente é: " + numero1 + ", " + numero2 + ", " + numero3);
                }
                else
                {
                    Console.WriteLine("A ordem decrescente é: " + numero1 + ", " + numero3 + ", " + numero2);
                }
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                if (numero1 > numero3)
                {
                    Console.WriteLine("A ordem decrescente é: " + numero2 + ", " + numero1 + ", " + numero3);
                }
                else
                {
                    Console.WriteLine("A ordem decrescente é: " + numero2 + ", " + numero3 + ", " + numero1);
                }
            }
            else if (numero3 > numero1 && numero3 > numero2)
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine("A ordem decrescente é: " + numero3 + ", " + numero1 + ", " + numero2);
                }
                else
                {
                    Console.WriteLine("A ordem decrescente é: " + numero3 + ", " + numero2 + ", " + numero1);
                }
            }
        }

        static void ex14()
        {
            Console.WriteLine("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("A diferença do maior para o menor é: " + (numero1 - numero2));
            }
            else
            {
                Console.WriteLine("A diferença do maior para o menor é: " + (numero2 - numero1));
            }
        }

        static void ex15()
        {
            Console.WriteLine("\nDigite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("O aluno foi aprovado com média: " + media);
            }
            else
            {
                Console.WriteLine("Digite a nota da recuperação: ");
                double notaRecuperacao = double.Parse(Console.ReadLine());

                double novaMedia = (media + notaRecuperacao) / 2;

                if (novaMedia >= 7)
                {
                    Console.WriteLine("O aluno foi aprovado na recuperação com média: " + novaMedia);
                }
                else
                {
                    Console.WriteLine("O aluno foi reprovado com média: " + novaMedia);
                }
            }
        }

        static void ex16()
        {
            Console.WriteLine("\nDigite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O maior número é: " + numero1);
                Console.WriteLine("O menor número é: " + numero2);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("O maior número é: " + numero2);
                Console.WriteLine("O menor número é: " + numero1);
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }

        static void ex17()
        {
            Console.WriteLine("\nDigite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 9)
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
            int codigo = int.Parse(Console.ReadLine());

            switch (codigo)
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
                int numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
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
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
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
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());

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
                    Console.WriteLine("A soma dos números é: " + (numero1 + numero2));
                    break;
                case 2:
                    Console.WriteLine("A subtração dos números é: " + (numero1 - numero2));
                    break;
                case 3:
                    Console.WriteLine("A multiplicação dos números é: " + (numero1 * numero2));
                    break;
                case 4:
                    Console.WriteLine("A divisão dos números é: " + (numero1 / numero2));
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

            Console.WriteLine("Digite o sexo da pessoa (M/F): ");
            string sexo = Console.ReadLine();

            while (sexo != "M" || sexo != "m" || sexo != "F" || sexo != "f")
            {
                Console.WriteLine("Sexo inválido. Digite novamente:");
                sexo = Console.ReadLine();
            }

            if (sexo == "M" || sexo == "m")
            {
                Console.WriteLine("O peso ideal é: " + ((72.7 * altura) - 58));
            }
            else
            {
                Console.WriteLine("O peso ideal é: " + ((62.1 * altura) - 44.7));
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
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite o número que deverá processar: ");
                int numero = int.Parse(Console.ReadLine());

                int fatorial = 1;
                for (int j = 1; j <= numero; j++)
                {
                    fatorial *= j;
                }

                Console.WriteLine("O fatorial do número " + numero + " é: " + fatorial);
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
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
        }

        static void ex31()
        {
            int numero = 0;
            int somaPares = 0;
            int somaImpares = 0;

            while (numero >= 0)
            {
                Console.WriteLine("Digite um número inteiro (digite um negativo para parar): ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    if (numero % 2 == 0)
                    {
                        somaPares += numero;
                    }
                    else
                    {
                        somaImpares += numero;
                    }
                }
            }

            Console.WriteLine("A soma dos números pares é: " + somaPares);
            Console.WriteLine("A soma dos números ímpares é: " + somaImpares);
        }

        static void ex32()
        {
            Console.WriteLine("\nDigite um número inteiro entre 0 e 10: ");
            int numero = int.Parse(Console.ReadLine());

            while (numero <= 0 || numero >= 10)
            {
                Console.WriteLine("Número inválido. Digite novamente: ");
                numero = int.Parse(Console.ReadLine());
            }

            int soma = 0;
            for (int i = 1; i <= 20; i++)
            {
                soma += (numero * numero);
                numero += 2;
            }

            Console.WriteLine("A soma dos quadrados dos 20 primeiros números ímpares a partir do número digitado é: " +
                              soma);
        }

        static void ex33()
        {
            int matricula, cont = 0;
            double nota, media = 0;

            Console.WriteLine("Digite a matricula do aluno: ");
            matricula = int.Parse(Console.ReadLine());

            while (matricula != 0)
            {
                Console.WriteLine("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                media += nota;
                cont++;
                Console.WriteLine("Digite a matricula do aluno: ");
                matricula = int.Parse(Console.ReadLine());
            }

            media = media / cont;
            Console.WriteLine("A media da turma é: " + media);
        }

        static void ex34()
        {
            int num, menor = 0, maior = 0;

            Console.WriteLine("Digite um numero: ");
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

                Console.WriteLine("Digite um numero: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("O menor numero é: " + menor);
            Console.WriteLine("O maior numero é: " + maior);
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
            int num, maior = 0, menor = 0, media = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero: ");
                num = int.Parse(Console.ReadLine());

                if (num > maior)
                {
                    maior = num;
                }
                else if (num < menor)
                {
                    menor = num;
                }

                media += num;
            }

            media = media / 10;
            Console.WriteLine("O maior numero é: " + maior);
            Console.WriteLine("O menor numero é: " + menor);
            Console.WriteLine("A media dos numeros é: " + media);
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

                Console.WriteLine("Digite o primeiro numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                num2 = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("O resultado da soma é: " + resultado);
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
            int codigo, horasTrabalhadas, salario, salarioExcedente;
            char resposta;

            do
            {
                Console.WriteLine("Digite o codigo do operario: ");
                codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero de horas trabalhadas: ");
                horasTrabalhadas = int.Parse(Console.ReadLine());

                if (horasTrabalhadas > 50)
                {
                    salario = horasTrabalhadas * 10;
                    salarioExcedente = (horasTrabalhadas - 50) * 20;
                }
                else
                {
                    salario = horasTrabalhadas * 10;
                    salarioExcedente = 0;
                }

                Console.WriteLine("O salario total é: " + salario);
                Console.WriteLine("O salario excedente é: " + salarioExcedente);
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
                Console.WriteLine("Digite um numero: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("O numero é par");
                }
                else
                {
                    Console.WriteLine("O numero é impar");
                }

                if (num > 0)
                {
                    Console.WriteLine("O numero é positivo");
                }
                else
                {
                    Console.WriteLine("O numero é negativo");
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
                Console.WriteLine("Digite um numero: ");
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

            Console.WriteLine("O maior numero é: " + maior);
            Console.WriteLine("O menor numero é: " + menor);
        }

        static void ex43()
        {
            int numeroQuadros = 64; // Número total de quadros no tabuleiro de xadrez
            ulong graos = 1;
            ulong graosTotais = 1;

            for (int quadro = 2; quadro <= numeroQuadros; quadro++)
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
                Console.WriteLine("Digite um numero: ");
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
                Console.WriteLine("Digite um numero para o vetor X: ");
                vetorX[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorY.Length; i++)
            {
                Console.WriteLine("Digite um numero para o vetor Y: ");
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
            int numeroX, maior = 0, menor = 0, igual = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite um numero X: ");
            numeroX = int.Parse(Console.ReadLine());

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > numeroX)
                {
                    maior++;
                }
                else if (vetor[i] < numeroX)
                {
                    menor++;
                }
                else
                {
                    igual++;
                }
            }

            Console.WriteLine("Quantidade de numeros maiores que X: " + maior);
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
                Console.WriteLine("Digite um numero para o vetor 1: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Digite um numero para o vetor 2: ");
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
            int numeroSorteado = random.Next(0, 100);
            int numeroTentativa, contador = 0;

            do
            {
                Console.WriteLine("Digite um numero: ");
                numeroTentativa = int.Parse(Console.ReadLine());
                contador++;

                if (numeroTentativa > numeroSorteado)
                {
                    Console.WriteLine("O numero sorteado é menor");
                }
                else if (numeroTentativa < numeroSorteado)
                {
                    Console.WriteLine("O numero sorteado é maior");
                }
            } while (numeroTentativa != numeroSorteado);

            Console.WriteLine("Quantidade de tentativas: " + contador);
            if (contador < 5)
            {
                Console.WriteLine("Tu é pit.");
            }
        }

        static void pinga()
        {
            int quantidadeAlunos, contador = 0;
            double nota, media, soma = 0;

            Console.WriteLine("Digite a quantidade de alunos: ");
            quantidadeAlunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.WriteLine("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());
                soma += nota;

                if (nota > 7)
                {
                    contador++;
                }
            }

            media = soma / quantidadeAlunos;

            if (contador == 0)
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 7.");
            }
            else
            {
                Console.WriteLine("Quantidade de alunos com nota acima de 7: " + contador);
            }

            Console.WriteLine("Media das notas: " + media);
        }

        static void ex52()
        {
            int[] vetor = new int[100];
            int contador1 = 0, contador3 = 0, contador4 = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
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

            Console.WriteLine("Quantidade de 1: " + contador1);
            Console.WriteLine("Quantidade de 3: " + contador3);
            Console.WriteLine("Quantidade de 4: " + contador4);
        }

        static void ex53()
        {
            int quantidadeVoltas, melhorTempo = 0, voltaMelhorTempo = 0;
            double tempoMedio, soma = 0;

            Console.WriteLine("Digite a quantidade de voltas: ");
            quantidadeVoltas = int.Parse(Console.ReadLine());

            int[] vetor = new int[quantidadeVoltas];

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

                soma += vetor[i];
            }

            tempoMedio = soma / quantidadeVoltas;

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
                Console.WriteLine("Digite um numero: ");
                vetorA[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetorB[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetorA.Length; i++)
            {
                for (int j = 0; j < vetorB.Length; j++)
                {
                    if (vetorA[i] == vetorB[j])
                    {
                        Console.WriteLine("Numero comum: " + vetorA[i]);
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
            Console.WriteLine("Quantidade de espacos: " + contador);
        }

        static void ex56()
        {
            int[] vetor = new int[50];
            int contadorPar = 0, contadorMultiplo5 = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
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

            Console.WriteLine("Quantidade de numeros pares: " + contadorPar);
            Console.WriteLine("Quantidade de multiplos de 5: " + contadorMultiplo5);
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
            int quantidadeNumeros, maior = 0, soma = 0;
            double media;

            Console.WriteLine("Digite a quantidade de numeros: ");
            quantidadeNumeros = int.Parse(Console.ReadLine());

            int[] vetor = new int[quantidadeNumeros];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maior = vetor[i];
                }
                else if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }

                soma += vetor[i];
            }

            media = soma / quantidadeNumeros;

            Console.WriteLine("Maior numero: " + maior);
            Console.WriteLine("Media: " + media);
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

                Console.WriteLine("Numero de caracteres entre eles: " + contador);
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
            int numero;

            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine(verifica(numero));
        }

        static string verifica(int numero)
        {
            if (numero % 2 == 0)
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
            int opcao, quantidadeNumeros;

            Console.WriteLine("Digite a quantidade de numeros: ");
            quantidadeNumeros = int.Parse(Console.ReadLine());

            int[] vetor = new int[quantidadeNumeros];

            do
            {
                Console.WriteLine("1 - Carregar Vetor");
                Console.WriteLine("2 - Listar Vetor");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                Console.WriteLine("5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor");
                Console.WriteLine("6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor");
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
                Console.WriteLine("Digite um numero: ");
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
            int quantidadePares = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (vetor[i] % 2 == 0)
                    {
                        quantidadePares++;
                    }
                }
            }

            Console.WriteLine("Quantidade de pares nas posicoes impares: " + quantidadePares);
        }

        static void exibeImparesPares(int[] vetor)
        {
            int quantidadeImpares = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (vetor[i] % 2 != 0)
                    {
                        quantidadeImpares++;
                    }
                }
            }

            Console.WriteLine("Quantidade de impares nas posicoes pares: " + quantidadeImpares);
        }
    }
}