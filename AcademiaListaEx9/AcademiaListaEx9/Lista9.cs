using System.Collections.Concurrent;

namespace AcademiaListaEx9
{
    internal class Lista9
    {
        static void Main(string[] args)
        {
            /* QUESTÃO 1*/
            Questao1();
            /*QUESTÃO 2*/
            Questao2();
            /*QUESTÃO 3*/
            Questao3();
        }

        public static void Questao1()
        {
            Nome listaNomes = new Nome();
            int quant = 0;
            Console.WriteLine("Digite quantos nomes deseja cadastrar: ");
            try
            {
                quant = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor inserido não é um número, encerrando!");
                return;
            }

            for (int i = 0; i < quant; i++)
            {
                bool cadastra = false;
                do
                {
                    Console.WriteLine("Digite o " + (i + 1) + "º nome Completo:");
                    string nome = Console.ReadLine().ToUpper();
                    cadastra = listaNomes.AdicionarNome(nome);

                } while (!cadastra);

            }

            listaNomes.ListarNomes();
        }

        public static void Questao2()
        {
            Emails listaEmails = new Emails();
            int opc = -1;
            while (true)
            {
                Console.WriteLine("1 - Cadastrar email, 2 - Listar emails, 0 - Sair");
                try
                {
                    opc = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("O valor inserido não é um número!");
                }

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Digite o e-mail: ");
                        string email = Console.ReadLine();
                        listaEmails.AdicionarEmail(email);
                        break;
                    case 2:
                        listaEmails.ListarEmails();
                        break;
                    case 0:
                        return;
                }
            }
        }
       
        public static void Questao3()
        {
            GerenciaFigurinhas gFigurinhas = new GerenciaFigurinhas();

            int opc = -1;
            while (true)
            {
                Console.WriteLine("1 - Cadastrar figurinha repetida\n" +
                    "2 - Cadastrar Figurinha Faltante\n" +
                    "3 - Listar Figurinhas Repetidas\n" +
                    "4 - Listar Figurinhas Faltantes\n" +
                    "0 - Sair");
                try
                {
                    opc = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("O valor inserido não é um número!");
                }
                switch (opc)
                {
                    case 1:
                        string codigo_figurinha, selecao, nome_jogador;
                        Console.WriteLine("Digite o código da figurinha:");
                        codigo_figurinha = Console.ReadLine();
                        Console.WriteLine("Digite a seleção da figurinha:");
                        selecao = Console.ReadLine();
                        Console.WriteLine("Digite o nome do jogador:");
                        nome_jogador = Console.ReadLine();
                        Figurinha f = new Figurinha(codigo_figurinha, selecao, nome_jogador);
                        gFigurinhas.AdicionarFigurinha(true, f);
                        break;
                    case 2:
                        Console.WriteLine("Digite o código da figurinha:");
                        codigo_figurinha = Console.ReadLine();
                        Console.WriteLine("Digite a seleção da figurinha:");
                        selecao = Console.ReadLine();
                        Console.WriteLine("Digite o nome do jogador:");
                        nome_jogador = Console.ReadLine();
                        f = new Figurinha(codigo_figurinha, selecao, nome_jogador);
                        gFigurinhas.AdicionarFigurinha(false, f);
                        break;
                    case 3:
                        gFigurinhas.ExibirFigurinhas(true);
                        break;
                    case 4:
                        gFigurinhas.ExibirFigurinhas(false);
                        break;
                    case 0:
                        return;

                }
            }

        }
    }
}