using System.Runtime.CompilerServices;

namespace AcademiaListaEx6
{
    internal class ListaEx6
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

        }

        public static void questao1()
        {
            List<String> nomes = new List<String>();
            String nome = "";
            do
            {
                Console.WriteLine("Digite um nome completo para adicionar a lista ou -1 para cancelar o cadastro:");
                nome = Console.ReadLine();
                string[] checaNome = nome.Split(" ");
                if (nome.Equals("-1"))
                    break;
                if (checaNome.Length < 2)
                    Console.WriteLine(nome+" é um nome inválido, digite novamente");
                else if (nomes.Contains(nome.ToUpper()))
                    Console.WriteLine("O nome já está na lista, digite novamente");
                else
                    nomes.Add(nome.ToUpper());
            } while (!nome.Equals("-1"));
            foreach (string n in nomes)
            {
                Console.WriteLine(n);
            }
        }
        public static void questao2()
        {
            Random random = new Random();
            List<int> numeros = new List<int>();
            Console.WriteLine("Digite a quantidade de elementos da lista:");
            int quant = int.Parse(Console.ReadLine());
            for (int i = 0; i < quant; i++)
            {
                numeros.Add(random.Next(1,1000));
            }
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }       
        public static void questao3()
        {
            List<string> emails = new List<string>();
            List<string> dominios = new List<string>();

            int menu;
            while (true)
            {
                Console.WriteLine("Digite a opção desejada\n1-cadastrar e-mail\n2-listar e-mails cadastrados\n3-sair");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Digite o e-mail:");
                        String email = Console.ReadLine();
                        if(emails.Contains(email))
                            Console.WriteLine("O e-mail já existe na lista!");
                        else
                            emails.Add(email);
                        break;
                    case 2:
                        Console.WriteLine("Lista de e-mails:");
                        foreach(string e in emails)
                        {
                            string[] dom = e.Split("@");
                            if (!emails.Contains(dom[1]))
                                dominios.Add(dom[1]);

                            Console.WriteLine(e);
                        }
                        Console.WriteLine("Domínios:");
                        foreach(string d in dominios)
                        {
                            Console.WriteLine(d);
                        }
                        break;
                    case 3:
                        return;
                    default:
                        break;
                }
            }
            
        }     
        public static void questao4()
        {
            List<String> criptomoedas = new List<string>();
            while (true)
            {
                int opc;
                Console.WriteLine("1 - Cadastrar criptomoeda\n2 - listar criptomoedas\n3 - remover criptomoedas\n4 - sair");
                opc = int.Parse(Console.ReadLine());
                switch (opc){
                    case 1:
                        Console.WriteLine("Digite o nome da moeda:");
                        string moeda = Console.ReadLine().ToUpper();
                        if (!criptomoedas.Contains(moeda))
                            criptomoedas.Add(moeda);
                        else
                            Console.WriteLine(moeda +" já existe na lista!");
                        break;
                    case 2:
                        criptomoedas.Sort();
                        Console.WriteLine("Moedas cadastradas:");
                        foreach(string e in criptomoedas)
                        {
                            Console.Write(e+" ");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Digite a moeda a ser removida:");
                        moeda = Console.ReadLine().ToUpper();
                        if (criptomoedas.Contains(moeda))
                        {
                            criptomoedas.Remove(moeda);
                            Console.WriteLine("Removida.");
                        }
                        else
                        {
                            Console.WriteLine(moeda + "não existe na lista.");
                        }
                        break;
                    case 4:
                        return;
                };
            }
        }
        public static void questao5()
        {
            Console.WriteLine("Digite a quantidade de números a serem cadastrados: ");
            int quantidade = int.Parse(Console.ReadLine());
            Random random = new Random();
            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();
            for (int i = 0; i < quantidade; i++)
            {
                lista1.Add(random.Next(100,200));
                lista2.Add(random.Next(100, 200));
            }
            List<int> comuns = new List<int>();
            Console.WriteLine("Lista 1:");
            foreach (int l in lista1)
            {
                Console.Write(l + " ");
                if ((lista2.Contains(l)) && !(comuns.Contains(l)))
                    comuns.Add(l);
            }
            Console.WriteLine();
            Console.WriteLine("Lista 2:");
            foreach (int l in lista2)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Números presentes nas duas listas:");
            foreach(int c in comuns)
                Console.Write(c + " ");
        }
            
        public static void questao6()
        {
            List<String> nomes = new List<String>();
            String nome = "";
            do
            {
                Console.WriteLine("Digite um nome completo para adicionar a lista ou -1 para cancelar o cadastro:");
                nome = Console.ReadLine();
                string[] checaNome = nome.Split(" ");
                if (nome.Equals("-1"))
                    break;
                if (checaNome.Length < 2)
                    Console.WriteLine(nome + " é um nome inválido, digite novamente");
                else if (nomes.Contains(nome.ToUpper()))
                    Console.WriteLine("O nome já está na lista, digite novamente");
                else
                    nomes.Add(nome.ToUpper());
            } while (!nome.Equals("-1"));
            List<string> sobrenome = new List<string>();
            List<string> parentes = new List<string>();

            foreach (string n in nomes)
            {
                
                String[] sob = n.Split(" ");
                if(!sobrenome.Contains(sob.Last()))
                    sobrenome.Add(sob.Last());               
            }

            Console.WriteLine("Sobrenomes");
            foreach (string s in sobrenome)
            {

                Console.WriteLine(s);
                foreach(string n in nomes)
                {
                    string[] nAtual = n.Split(" ");

                    if (nAtual.Last().Equals(s) && !parentes.Contains(n))
                    {
                        parentes.Add(n);
                    }
                }
            }

            Console.WriteLine("Parentes: ");
            foreach (string p in parentes)
            {
                Console.WriteLine(p);
            }
        }

    }
}