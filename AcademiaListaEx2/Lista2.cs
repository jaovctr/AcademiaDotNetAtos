namespace AcademiaListaEx2
{
    internal class Lista2
    {
        static void Main(string[] args)
        {
            /* QUESTÃO 1*/
            questao1();
            /*QUESTÃO 2*/
            questao2();
            /*QUESTÃO 3*/
            questao3();
            /*QUESTÃO 4*/
            questao4();
            /*QUESTÃO 5*/
            questao5();
            /*QUESTÃO 6*/
            questao6();
            /*QUESTÃO 7*/
            questao7();
            /*QUESTÃO 8*/
            questao8();
            /*QUESTÃO 9*/
            questao9();
            /*QUESTÃO 10*/
            questao10();
            /*QUESTÃO 11*/
            questao11();
            /*QUESTÃO 12*/
            questao12();
            /*QUESTÃO 13*/
            questao13();
            /*QUESTÃO 14*/
            questao14();
            /*QUESTÃO 15*/
            questao15();
            /*QUESTÃO 16*/
            questao16();
            /*QUESTÃO 17*/
            questao17();
            /*QUESTÃO 18*/
            questao18();
            /*QUESTÃO 19*/
            questao19();
            /*QUESTÃO 20*/
            questao20();


        }
        public static void questao1()
        {
            Console.WriteLine("Digite a base do triângulo:");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do triângulo:");
            double alturaTriangulo = double.Parse(Console.ReadLine());
            if (baseTriangulo == 0 || alturaTriangulo == 0)
            {
                Console.WriteLine("Valores inválidos!");
            }
            else
            {
                Console.WriteLine("Área: " + (baseTriangulo * alturaTriangulo) / 2);
            }


        }
        public static void questao2()
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }
        }
        public static void questao3()
        {

            Console.WriteLine("Digite 4 números");
            int[] notas = new int[4];
            double media = 0;
            for (int i = 0; i < 4; i++)
            {
                notas[i] = int.Parse(Console.ReadLine());
                media = media + notas[i];
            }
            media = media / 4;
            Console.WriteLine("Média: " + media);
            for (int i = 0; i < 4; i++)
            {
                if (notas[i] > media)
                {
                    Console.WriteLine(notas[i] + " é maior que a média!");
                }
            }
        }
        public static void questao4()
        {
            int[] horaAula = new int[2];
            double[] valorHora = new double[2];
            double[] salario = new double[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite a quantidade de horas do professor " + (i + 1) + ":");
                horaAula[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor pago por hora ao professor " + (1 + i) + ":");
                valorHora[i] = double.Parse(Console.ReadLine());
                salario[i] = horaAula[i] * valorHora[i];
            }
            if (salario[0] > salario[1])
            {
                Console.WriteLine("O professor 1 com salário de R$:" + salario[0] + " ganha mais!");
            }
            else
            {
                Console.WriteLine("O professor 2 com salário de R$:" + salario[1] + " ganha mais!");
            }

        }
        public static void questao5()
        {
            double n1, n2;
            Console.WriteLine("Digite as 2 notas do aluno:");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            if (((n1 + n2) / 2) >= 7)
            {
                Console.WriteLine("Aprovado!");
            }

        }
        public static void questao6()
        {
            Console.WriteLine("Digite o nome:");
            String nome = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a altura em metros:");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso em kg:");
            double peso = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);
            if (imc < 18)
            {
                Console.WriteLine(nome + " possui IMC de " + imc + ", com baixo peso!");
            }
            else if (imc >= 18 && imc < 25)
            {
                Console.WriteLine(nome + " possui IMC de " + imc + ", com peso normal!");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine(nome + " possui IMC de " + imc + ", com sobrepeso!");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine(nome + " possui IMC de " + imc + ", com obesidade!");
            }
            else
            {
                Console.WriteLine(nome + " possui IMC de " + imc + ", com obesidade com grau sério!");
            }

        }
        public static void questao7()
        {
            Console.WriteLine("Digite uma frase:");
            String frase = Console.ReadLine();
            Console.WriteLine("Digite a palavra de busca:");
            String palavra = Console.ReadLine();
            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra está na frase!");
            }
            else
            {
                Console.WriteLine("A palavra não está na frase!");
            }
        }
        public static void questao8()
        {
            Console.WriteLine("Digite o código:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome:");
            String nome = Console.ReadLine();
            Console.WriteLine("Digite o salário base:");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas:");
            double totalVendas = double.Parse(Console.ReadLine());
            double salarioFinal;
            if (totalVendas >= 500 && totalVendas < 1000)
            {
                salarioFinal = salario + (salario * 0.05);
            }
            else if (totalVendas >= 1000 && totalVendas < 5000)
            {
                salarioFinal = salario + (salario * 0.07);
            }
            else
            {
                salarioFinal = salario + (salario * 0.10);
            }
            Console.WriteLine("Salário final: R$: " + salarioFinal);
        }
        public static void questao9()
        {
            double[] glicemia = new double[3];
            Console.WriteLine("Digite os 3 valores de glicemia");
            for (int i = 0; i < 3; i++)
            {
                glicemia[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                if (glicemia[i] < 65)
                {
                    Console.WriteLine("Hipoglicemia no dia " + (i + 1));
                }
                else if (glicemia[i] > 250)
                {
                    Console.WriteLine("Hiperglicemia no dia " + (i + 1));
                }
                else
                {
                    Console.WriteLine("Valor ok no dia " + (i + 1));
                }
            }
        }
        public static void questao10()
        {
            String[] nome = new string[2];
            int[] idade = new int[2];
            double[] altura = new double[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o nome do atleta " + (i + 1) + ":");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite a idade do atleta " + (i + 1) + ":");
                idade[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do atleta " + (i + 1) + ":");
                altura[i] = double.Parse(Console.ReadLine());

            }
            if (idade[0] < idade[1])
            {
                Console.WriteLine("Atleta 1 é mais novo: " + nome[0] + ", " + idade[0] + " anos e " + altura[0] + " de altura.");
            }
            else
            {
                Console.WriteLine("Atleta 2 é mais novo: " + nome[1] + ", " + idade[1] + " anos e " + altura[1] + " de altura.");
            }
            if (altura[0] > altura[1])
            {
                Console.WriteLine("Atleta 1 é mais alto: " + nome[0] + ", " + idade[0] + " anos e " + altura[0] + " de altura.");
            }
            else
            {
                Console.WriteLine("Atleta 2 é mais alto: " + nome[1] + ", " + idade[1] + " anos e " + altura[1] + " de altura.");
            }


        }
        public static void questao11()
        {
            int hora, minutos;
            Console.WriteLine("Digite a hora e os minutos:");
            hora = int.Parse(Console.ReadLine());
            minutos = int.Parse(Console.ReadLine());
            if (hora < 0 || hora > 23 || minutos < 0 || minutos > 59)
            {
                Console.WriteLine("Hora inválida");
            }
            else
            {
                Console.WriteLine(hora + ":" + minutos + " é uma hora válida");
            }
        }
        public static void questao12()
        {
            int codigo, numeroHoras;
            Console.WriteLine("Digite o código do funcionário e as horas trabalhadas:");
            codigo = int.Parse(Console.ReadLine());
            numeroHoras = int.Parse(Console.ReadLine());
            int salario = 0, extra = 0;
            if (numeroHoras > 50)
            {
                salario = 50 * 10;
                extra = (numeroHoras - 50) * 20;

            }
            else
            {
                salario = numeroHoras * 10;
            }
            Console.WriteLine("Salário: " + salario + ", excedente: " + extra);
        }
        public static void questao13()
        {
            Console.WriteLine("Digite a altura (metros):");
            double altura = double.Parse(Console.ReadLine());
            double pesoHomem = (72.7 * altura) - 58;
            double pesoMulher = (62.1 * altura) - 44.7;
            Console.WriteLine("Para homens, o peso ideal é de " + pesoHomem + " kg, já para mulheres é de " + pesoMulher + " kg");

        }
        public static void questao14()
        {
            double arquivo, velocidade;
            Console.WriteLine("Digite o tamanho do arquivo (mb) e a velocidade (mbps):");
            arquivo = double.Parse(Console.ReadLine());
            velocidade = double.Parse(Console.ReadLine());
            double tempoMin = (arquivo / velocidade);
            double tempoSeg = tempoMin % 60;
            tempoMin = (tempoMin - tempoSeg) / 60;



            Console.WriteLine("O arquivo será baixado em " + tempoMin + ":" + tempoSeg + " minutos");
        }
        public static void questao15()
        {
            Console.WriteLine("Digite a área do local a ser pintado:");
            double area = double.Parse(Console.ReadLine());
            double latas = (area / 3) / 18;
            if (area % 18 != 0)
            {
                latas = (int)latas + 1;
            }
            double custo = latas * 80.0;
            Console.WriteLine("Serão utilizadas " + latas + " latas de tinta, com custo de R$:" + custo);
        }
        public static void questao16()
        {
            int time1, time2;
            Console.WriteLine("Digite o placar do jogo de ida (casa/visitante):");
            time1 = int.Parse(Console.ReadLine());
            time2 = int.Parse(Console.ReadLine());
            if ((time2 - time1) >= 2)
            {
                Console.WriteLine("O visitante já está classificado!");
            }
            else
            {
                Console.WriteLine("Haverá jogo de volta!");
                Console.WriteLine("Digite o placar do jogo de volta (casa/visitante):");
                time2 = time2 + int.Parse(Console.ReadLine());
                time1 = time1 + int.Parse(Console.ReadLine());
                if (time1 > time2)
                {
                    Console.WriteLine("Time 1 se classificou com placar de " + time1 + "x" + time2);
                }
                else
                {
                    Console.WriteLine("Time 2 se classificou com placar de " + time1 + "x" + time2);
                }
            }
        }
        public static void questao17()
        {
            double a, b, c;
            Console.WriteLine("Digite os lados do triângulo: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if ((a > b + c) || (b > a + c) || (c > a + b))
            {
                Console.WriteLine("Os lados não formam um triângulo");
            }
            else
            {
                if ((a == b) && (a == c))
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else if ((a == b && a != c) || (b == c && b != a) || (c == a && c != b))
                {
                    Console.WriteLine("Triângulo isóceles");

                }
                else
                {
                    Console.WriteLine("Triângulo escaleno");
                }

            }
        }
        public static void questao18()
        {
            int a, b, c;
            Console.WriteLine("Digite os 3 valores");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int maior;
            if (a >= b && a >= c)
            {
                maior = a;
            }
            else if (b >= a && b >= c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }
            Console.WriteLine(maior + " é o maior");
        }
        public static void questao19()
        {

            int[] numero = new int[3];
            Console.WriteLine("Digite os 3 valores");
            numero[0] = int.Parse(Console.ReadLine());
            numero[1] = int.Parse(Console.ReadLine());
            numero[2] = int.Parse(Console.ReadLine());
            int[] ordenado = numero.OrderBy(i => i).ToArray();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ordenado[i]);
            }

        }
        public static void questao20()
        {
            Random rdm = new Random();
            int numero = rdm.Next(0, 10);
            Console.WriteLine("Adivinhe qual o número entre 0 e 10:");
            bool acertou = false;
            for (int i = 1; i <= 3; i++)
            {
                int tentativa = int.Parse(Console.ReadLine());
                if (tentativa == numero)
                {
                    Console.WriteLine("Acertou na tentativa " + i);
                    acertou = true;
                }
                else if (tentativa > numero)
                {
                    Console.WriteLine("Tentativa " + i + ": maior, restam " + (3 - i) + " tentativas");
                }
                else
                {
                    Console.WriteLine("Tentativa " + i + ": menor, restam " + (3 - i) + " tentativas");
                }
            }
            if (!acertou)
            {
                Console.WriteLine("Infelizmente errou, o número era " + numero);
            }
        }
    }
}