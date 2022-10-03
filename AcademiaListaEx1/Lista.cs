using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace ExerciciosAcademia
{
    internal class Lista
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

        }
        public static void questao1()
        {
            Console.WriteLine("Digite o número A: ");
            double numA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número B: ");
            double numB = double.Parse(Console.ReadLine());

            double media = (numA + numB) / 2;
            Console.WriteLine("Média: " + media);
        }
        public static void questao2()
        {

            Console.WriteLine("Digite o número 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número 2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número 3: ");
            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número 4: ");
            double n4 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("Média: " + media);

        }
        public static void questao3()
        {

            Console.WriteLine("Digite o número A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número B: ");
            int b = int.Parse(Console.ReadLine());

            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Após a inversão: A = " + a + ", B = " + b);

        }
        public static void questao4()
        {
            Console.WriteLine("Digite o Dia do mês:");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o mês do ano:");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano:");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Data em AAAAMMDD: " + ano + "/" + mes + "/" + dia);

            Console.WriteLine("Data em AAMMDD: " + ano % 100 + "/" + mes + "/" + dia);

        }
        public static void questao5()
        {
            Console.WriteLine("Digite a distância percorrida (km):");
            double distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o consumo de combustível do veículo (litros):");
            double gastoLitros = double.Parse(Console.ReadLine());
            double consumo = distancia / gastoLitros;
            Console.WriteLine("O consumo do veículo na viagem foi de: " + consumo + " km/l");
        }
        public static void questao6()
        {

            //Parafuso A:
            Console.WriteLine("Parafuso A:");
            Console.WriteLine("Digite o código do parafuso:");
            string codigoA = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de peças:");
            int quantidadeA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário:");
            double valorUnitA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a alíquota do IPI: ");
            double ipiA = double.Parse(Console.ReadLine());

            //Parafuso B
            Console.WriteLine("Parafuso B:");
            Console.WriteLine("Digite o código do parafuso:");
            string codigoB = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de peças:");
            int quantidadeB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário:");
            double valorUnitB = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a alíquota do IPI: ");
            double ipiB = double.Parse(Console.ReadLine());

            double valorFinalA = (quantidadeA * valorUnitA) + (quantidadeA * valorUnitA) * (ipiA / 100);
            double valorFinalB = (quantidadeB * valorUnitB) + (quantidadeB * valorUnitB) * (ipiB / 100);

            Console.WriteLine("Parafuso A:\n" +
                "Código: " + codigoA + "\n" +
                "Quantidade: " + quantidadeA + "\n" +
                "Valor unitário: " + valorUnitA + "\n" +
                "Alíquota IPI: " + ipiA + "%\n" +
                "Valor total: R$:" + valorFinalA);

            Console.WriteLine("Parafuso B:\n" +
                "Código: " + codigoB + "\n" +
                "Quantidade: " + quantidadeB + "\n" +
                "Valor unitário: " + valorUnitB + "\n" +
                "Alíquota IPI: " + ipiB + "%\n" +
                "Valor total: R$:" + valorFinalB);
        }
        public static void questao7()
        {
            Console.WriteLine("Digite o número do vendedor:");
            int numeroVendedor = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salário fixo do vendedor:");
            double salFixo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas efetuadas:");
            int totalVendas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual ganho por venda:");
            double comissao = double.Parse(Console.ReadLine());
            double salarioTotal = salFixo + (totalVendas * (comissao / 100));
            Console.WriteLine("Número do vendedor: " + numeroVendedor + "\nSalário final: R$:" + salarioTotal);
        }
        public static void questao8()
        {
            Console.WriteLine("Digite a temperatura em ºC: ");
            double tempC = double.Parse(Console.ReadLine());
            double tempF = (9 * tempC + 160) / 5;
            Console.WriteLine("Temperatura em ºF: " + tempF);
        }
        public static void questao9()
        {

            Console.WriteLine("Digite o valor da mercadoria:");
            double valor = double.Parse(Console.ReadLine());
            double parcelas = Math.Floor(valor / 3);
            double entrada = valor - (2 * parcelas);

            Console.WriteLine("Entrada de R$: " + entrada + " e duas parcelas de R$: " + parcelas);

        }
        public static void questao10()
        {

            Console.WriteLine("Digite o valor solicitado:");
            int valor = int.Parse(Console.ReadLine());
            int nota50 = 0, nota10 = 0, nota5 = 0, nota1 = 0;
            int restante = valor;
            do
            {
                if (restante >= 50)
                {
                    restante = restante - 50;
                    nota50++;
                }
                else if (restante >= 10)
                {
                    restante = restante - 10;
                    nota10++;
                }
                else if (restante >= 5)
                {
                    restante = restante - 5;
                    nota5++;
                }
                else if (restante >= 1)
                {
                    restante = restante - 1;
                    nota1++;

                }

            } while (restante > 0);
            Console.WriteLine(nota50 + " notas de 50 reais, " + nota10 + " notas de 10 reais, " + nota5 + " notas de 5 reais, " + nota1 + " notas de 1 real.");

        }
        public static void questao11()
        {

            Console.WriteLine("Digite o número total de eleitores:");
            int eleitores = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de votos válidos:");
            int validos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de votos brancos:");
            int brancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de votos nulos:");
            int nulos = int.Parse(Console.ReadLine());

            double porcentagemValidos = (validos * 100) / eleitores;
            double porcentagemBrancos = (brancos * 100) / eleitores;
            double porcentagemNulos = (nulos * 100) / eleitores;
            Console.WriteLine("Válidos: " + porcentagemValidos + "%, Brancos: " + porcentagemBrancos + "%, Nulos: " + porcentagemNulos + "%");

        }
        public static void questao12()
        {

            double litrosConsumidos, valorRecebido, odometroInicio, odometroFinal;
            Console.WriteLine("Digite o valor do odômetro no inicio do dia: ");
            odometroInicio = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do odômetro no fim do dia: ");
            odometroFinal = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de combustível consumida: ");
            litrosConsumidos = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor total arrecadado: ");
            valorRecebido = double.Parse(Console.ReadLine());

            double kmRodados = odometroFinal - odometroInicio;
            double mediaConsumo = kmRodados / litrosConsumidos;
            double lucro = valorRecebido - (litrosConsumidos * 6.90);

            Console.WriteLine("Média de consumo (km/l): " + mediaConsumo + ", lucro líquido: " + lucro);
        }
        public static void questao13()
        {
            double salarioMinimo, custoBicicleta;
            int vendidas;
            Console.WriteLine("Digite o salário mínimo atual:");
            salarioMinimo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço de custo da bicicleta:");
            custoBicicleta = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de bicicletas vendidas:");
            vendidas = int.Parse(Console.ReadLine());
            double comissao = ((custoBicicleta ) * 0.15) * vendidas;
            double salarioFinal = (2 * salarioMinimo) + comissao;
            Console.WriteLine("Salário final: R$:" + salarioFinal);
        }
    }
}