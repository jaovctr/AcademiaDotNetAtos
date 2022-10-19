using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace AcademiaListaEx8
{
    internal class Lista8
    {
        static void Main(string[] args)
        {
            /* QUESTÃO 1*/
            Questao1();
            /*QUESTÃO 2*/
            Questao2();
            /*QUESTÃO 3*/
            Questao3();
            /*QUESTÃO 4*/
            Questao4();
            /*QUESTÃO 5*/
            Questao5();
            /*QUESTÃO 6*/
            Questao6();
            /*QUESTÃO 7*/
            Questao7();
        }        
        public static void Questao1() 
        {
            List<Personagem> personagens = new List<Personagem>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Informe o nome do personagem "+(i+1)+":");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o nível de poder do personagem " + (i + 1) + " (0 a 10):");
                double nivel = double.Parse(Console.ReadLine());
                personagens.Add(new Personagem(nome, nivel));
            }
            Personagem maisForte=personagens.First(); 
            foreach (Personagem p in personagens)
            {
                if (p.Poder > maisForte.Poder) 
                    maisForte = p;
            }
            Console.WriteLine(maisForte.Nome+" é o mais forte!");
        }
        public static void Questao2()
        {
            List<Animal> animais = new List<Animal>(5);
            for (int i = 0; i < 5; i++)
            {
                Animal a = new Animal();
                String tipo;
                do
                {
                    Console.WriteLine("Digite o tipo do " + (i + 1) + "º animal  (Cachorro, Gato, Peixe): ");
                    tipo = Console.ReadLine().ToLower();
                    if (a.TipoAnimal.Contains(tipo))
                        break;
                    else
                        Console.WriteLine("Tipo inválido, digite novamente: ");
                } while (!a.TipoAnimal.Contains(tipo));
                a.Tipo = tipo;
                Console.WriteLine("Digite o nome do animal:");
                a.Nome = Console.ReadLine();
                Console.WriteLine("Digite a idade do animal:");
                a.Idade = int.Parse(Console.ReadLine());
                animais.Add(a);
            }
            int cachorro = 0, gato = 0, peixe = 0;
            foreach (var a in animais)
            {
                if (a.Tipo.Equals("gato"))
                    gato++;
                else if (a.Tipo.Equals("cachorro"))
                    cachorro++;
                else
                    peixe++;
            }
            Console.WriteLine(cachorro+" cachorros, "+gato+" gatos e "+peixe+" peixes.");
        }      
        public static void Questao3()
        {
            List<Asteroide> asteroides = new List<Asteroide>();
            Random rand = new Random();
            while (true)
            {
                Console.WriteLine("1 - Cadastrar asteróide, 2 - Listar asteróides, 0 - sair");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        
                        Console.WriteLine("Digite as coordenadas X e Y do asteróide:");
                        double pos_x = double.Parse(Console.ReadLine());
                        double pos_y = double.Parse(Console.ReadLine());
                        Asteroide a = new Asteroide(pos_x, pos_y);
                        Console.WriteLine("Digite o tamanho do asteroide (1 a 10): ");
                        a.Tamanho = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a velocidade do asteróide (1 a 5): ");
                        a.Velocidade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a energia do asteróide (1 a 5): ");
                        a.Energia = int.Parse(Console.ReadLine());
                        asteroides.Add(a);
                        break;
                    case 2:
                        ListarAsteroides(asteroides);
                        break;
                    case 0:
                        return;
                }
            }
            void ListarAsteroides(List<Asteroide> asteroides)
            {
                foreach(Asteroide a in asteroides)
                {
                    Console.WriteLine("Coordenadas: ("+a.Pos_x+","+a.Pos_y+")\n"+
                        "Tamanho: "+a.Tamanho+"\n"+
                        "Velocidade: "+a.Velocidade+"\n"+
                        "Energia: "+a.Energia+"\n");
                }
            }
            
        }
        public static void Questao4()
        {
            Console.WriteLine("Digite a descrição do item:");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite a data de criação do item:");
            DateTime dataCriacao = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do objeto:");
            float altura = float.Parse(Console.ReadLine());
            ItemCenario item = new ItemCenario(descricao, dataCriacao, altura);
            item.MostraItem();
            item.TempoCriacao();
        }      
        public static void Questao5()
        {
            List<ObjetoNoPlano> planoCartesiano = new List<ObjetoNoPlano>();
            Console.WriteLine("Digite a quantidade de objetos que você quer no plano: ");
            int quant = int.Parse(Console.ReadLine());
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Digite as coordenadas X e Y do objeto "+(i+1)+":");
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                planoCartesiano.Add(new ObjetoNoPlano(x, y));
            }
            imprimeObjetos(planoCartesiano);

            
            void imprimeObjetos(List<ObjetoNoPlano> planoCartesiano)
            {
                Console.WriteLine("Objetos no plano: ");
                foreach (var obj in planoCartesiano)
                {
                    Console.WriteLine("(" + obj.Pos_x + " , " + obj.Pos_y + ")");
                }
            }
        }     
        public static void Questao6()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            while (true)
            {
                Console.WriteLine("1 - Cadastrar Funcionario, 2 - Exibir Funcionarios, 0 - Sair");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        
                        
                        Console.WriteLine("Digite o nome do funcionario:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o departamento: ");
                        string departamento = Console.ReadLine();
                        Console.WriteLine("Digite o salário: ");
                        double salario = double.Parse(Console.ReadLine());
                        string dataCadastro = DateTime.Today.ToString();
                        Console.WriteLine("Digite o RG:");
                        string rg = Console.ReadLine();
                        Console.WriteLine("O funcionário está ativo na empresa? (1 - Sim/0 - Não)");
                        bool ativo = (int.Parse(Console.ReadLine()) == 1 ? true : false);
                        Console.WriteLine("Qual o tipo do funcionário? (1 - Gerente/2 - Operador)");
                        int tipo = int.Parse(Console.ReadLine());
                        Funcionario f;
                        if (tipo == 1)
                        {
                             f = new Gerente(nome, departamento, salario, dataCadastro, rg, ativo);
                        }
                        else
                        {
                            f = new Operador(nome, departamento, salario, dataCadastro, rg, ativo);
                        }
                        funcionarios.Add(f);
                        break;
                    case 2:
                        foreach(var funcionario in funcionarios)
                        {
                            Console.WriteLine("Nome: "+funcionario.Nome+"\nDepartamento: "+funcionario.Departamento);

                        }
                        break;
                    case 0:
                        return;
                }
            }
        }
        public static void Questao7()
        {
            Dictionary<string, int> livros = new Dictionary<string, int>();
            while (true)
            {
                Console.WriteLine("1 - Cadastrar livro, 2 - Listar livros cadastrados, 3 - Pesquisar livro específico, 0 - Sair");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do livro:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade de páginas:");
                        int paginas = int.Parse(Console.ReadLine());
                        livros.Add(nome, paginas);
                        Console.WriteLine("Cadastrado!");
                        break;
                    case 2:
                        Console.WriteLine("Lista: ");
                        foreach (var livro in livros)
                        {
                            Console.WriteLine("Título: "+livro.Key+", "+livro.Value+" páginas.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite o nome do livro:");
                        nome = Console.ReadLine();
                        if (livros.ContainsKey(nome))
                        {
                            foreach(var l in livros)
                            {
                                if(l.Key.Equals(nome))
                                    Console.WriteLine("Título: " + l.Key + ", " + l.Value + " páginas.");
                            }
                        }
                        else
                        {
                            Console.WriteLine(nome+" não encontrado na lista!");
                        }
                        break;
                    case 0:
                        return;
                }
            }

        }
    }
}