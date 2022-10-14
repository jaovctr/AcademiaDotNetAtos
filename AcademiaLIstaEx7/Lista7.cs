namespace AcademiaListaEx7
{
    internal class Lista7
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
        }

        public static void questao1()
        {
            Console.WriteLine("Digite os dados do livro: Código, Nome, Autor, Gênero, Editora e Edição");
            int codigo = int.Parse(Console.ReadLine());
            string nome = Console.ReadLine();
            string autor = Console.ReadLine();
            string genero = Console.ReadLine();
            string editora = Console.ReadLine();
            int edicao = int.Parse(Console.ReadLine());

            Livro livro = new Livro(codigo,nome,autor,genero,editora,edicao);
            livro.dadosLivros();
        }
        public static void questao2()
        {
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o gênero:");
            string genero = Console.ReadLine();
            Console.WriteLine("Digite o CPF:");
            string cpf = Console.ReadLine();
            Pessoa pessoa = new Pessoa(nome, idade, genero, cpf);
            pessoa.apresentaPessoa();

        }
        public static void questao3()
        {
            Console.WriteLine("Digite o nome do Cliente:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            int idade = int.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(nome, idade);
            Console.WriteLine("Digite os parâmetros do carro: (modelo,fabricante, cor, placa, velocidade máxima)");
            string modelo = Console.ReadLine();
            string fabricante = Console.ReadLine();
            string cor = Console.ReadLine();
            string placa = Console.ReadLine();
            double velocidadeMax = double.Parse(Console.ReadLine());
            Carro carro = new Carro(modelo, fabricante, cor, placa, velocidadeMax, false);
            
            Console.WriteLine("Digite o valor da diária:");
            double valorDiaria = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a data inicial do aluguel:");
            DateOnly dataAluguel = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Digite as diárias:");
            int diarias = int.Parse(Console.ReadLine());

            Aluguel aluguel = new Aluguel(cliente, carro, valorDiaria, dataAluguel, diarias);

            Console.WriteLine("Cliente: " + aluguel.getCliente() +
                "\nCarro: " + aluguel.getCarro() +
                "\nValor total: " + aluguel.getValorAluguel() +
                "\nData devolução: " + aluguel.getDataDevolucao());
        }
        public static void questao4()
        {
            //eu
            Console.WriteLine("Digite nome, idade, genero e cpf da pessoa:");
            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());
            string genero = Console.ReadLine();
            string cpf = Console.ReadLine();
            Pessoa eu = new Pessoa(nome,idade,genero,cpf);

            //pais
            Console.WriteLine("Digite nome, idade, genero e cpf do pai:");
            nome = Console.ReadLine();
            idade = int.Parse(Console.ReadLine());
            genero = Console.ReadLine();
            cpf = Console.ReadLine();
            Pessoa pai = new Pessoa(nome, idade, genero, cpf);
            eu.setPai(pai);

            Console.WriteLine("Digite nome, idade, genero e cpf da mãe:");
            nome = Console.ReadLine();
            idade = int.Parse(Console.ReadLine());
            genero = Console.ReadLine();
            cpf = Console.ReadLine();
            Pessoa mae = new Pessoa(nome, idade, genero, cpf);
            eu.setPai(mae);

            //avos
            Console.WriteLine("Digite nome, idade, genero e cpf do avô paterno:");
            nome = Console.ReadLine();
            idade = int.Parse(Console.ReadLine());
            genero = Console.ReadLine();
            cpf = Console.ReadLine();
            Pessoa avoPaterno = new Pessoa(nome, idade, genero, cpf);
            pai.setPai(avoPaterno);

            Console.WriteLine("Digite nome, idade, genero e cpf da avó paterna:");
            nome = Console.ReadLine();
            idade = int.Parse(Console.ReadLine());
            genero = Console.ReadLine();
            cpf = Console.ReadLine();
            Pessoa voPaterno = new Pessoa(nome, idade, genero, cpf);
            pai.setMae(voPaterno);

            Console.WriteLine("Digite nome, idade, genero e cpf do avô materno:");
            nome = Console.ReadLine();
            idade = int.Parse(Console.ReadLine());
            genero = Console.ReadLine();
            cpf = Console.ReadLine();
            Pessoa avoMaterno = new Pessoa(nome, idade, genero, cpf);
            mae.setPai(avoMaterno);

            Console.WriteLine("Digite nome, idade, genero e cpf da avó materna:");
            nome = Console.ReadLine();
            idade = int.Parse(Console.ReadLine());
            genero = Console.ReadLine();
            cpf = Console.ReadLine();
            Pessoa voMaterno = new Pessoa(nome, idade, genero, cpf);
            mae.setMae(voMaterno);

            Console.WriteLine(eu.getNome() +
                "\n Pais: " + eu.arvore() +
                "\n Avós: " + pai.arvore() + ", " + mae.arvore());
        }   
        public static void questao5()
        {
            Supermercado quitanda = new Supermercado();
            while (true)
            {
                Console.WriteLine("1 - Cadastrar produto\n2 - Fazer pedido\n 3 - Sair");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Digite a descrição, preço e quantidade do produto:");
                        string desc = Console.ReadLine();
                        double preco = double.Parse(Console.ReadLine());
                        int quant = int.Parse(Console.ReadLine());
                        quitanda.CadastraProduto(new Produto(desc, preco, quant));
                        Console.WriteLine("Cadastrado");
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do cliente:");
                        string nome = Console.ReadLine();
                        Cliente cliente = new Cliente(nome);
                        bool comprando = true;
                        List<Produto> itens = new List<Produto>();
                        while (comprando)
                        {
                            quitanda.listarProdutos();
                            Console.WriteLine("-1 para fechar lista");
                            int opcPedido = int.Parse(Console.ReadLine());
                            if(opcPedido.Equals(-1))
                            {
                                break;
                            }
                            else
                            {
                                itens.Add(quitanda.produtos.ElementAt(opcPedido));
                            }
                        }
                        Console.WriteLine("Tipo de pagamento?");
                        string tipoPagamento = Console.ReadLine();
                        Pedido pedido = new Pedido(cliente,itens,tipoPagamento);
                        quitanda.Vendeu(pedido);
                        break;
                    case 3:
                        return;
                }
            }
        }
        public static void questao6()
        {
            Agenda agenda = new Agenda();
            while (true)
            {
                Console.WriteLine("1 - Adicionar contato, 2 - Apagar contato, 3 - Buscar contato, 4 - Exibir agenda, 5 - Sair");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Nome:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Idade:");
                        int idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Altura (metros):");
                        float altura = float.Parse(Console.ReadLine());
                        agenda.armazenaPessoa(nome, idade, altura);
                        break;

                    case 2:
                        Console.WriteLine("Digite o nome do contato:");
                        nome = Console.ReadLine();
                        agenda.removePessoa(nome);
                        break;
                    case 3:
                        Console.WriteLine("Digite o nome do contato:");
                        nome = Console.ReadLine();
                        agenda.buscaPessoa(nome);
                        break;
                    case 4:
                        agenda.imprimeAgenda();
                        break;
                    case 5:
                        return;
                }
            }
        }
        public static void questao7()
        {
            Elevador elevador = new Elevador();
            while (true)
            {
                Console.WriteLine("1 - Inicializa elevador\n2 - Entrar no elevador\n3 - Sair do elevador\n4 - Subir um andar\n5 - Descer um andar" +
                    "\n6 - Sair");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Qual a lotação máxima?");
                        int lotacao = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o total de andares?");
                        int capacidade = int.Parse(Console.ReadLine());
                        elevador.Inicializa(lotacao,capacidade);
                        break;
                    case 2:
                        elevador.Entra();
                        break;
                    case 3:
                        elevador.Sai();
                        break;
                    case 4:
                        elevador.Sobe();
                        break;
                    case 5:
                        elevador.Desce();
                        break;
                    case 6:
                        return;
                }
                Console.WriteLine("Elevador no andar: "+elevador.Andar+"\nLotação: "+elevador.Lotacao+" pessoas");
            }
        } 
        public static void questao8()
        {
            ControleRemoto controle = new ControleRemoto();
            while (true)
            {
                Console.WriteLine("1 - liga/desliga\n2 - aumenta canal\n3 - diminui canal\n4 - troca canal\n 5 - aumenta volume\n6 - diminui volume" +
                    "\n7 - mostra canal\n 8 - mostra volume\n9 - sair");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        controle.BotaoLigar();
                        break;
                    case 2:
                        controle.SubirCanal();
                        break;
                    case 3:
                        controle.DiminuirCanal();
                        break;
                    case 4:
                        Console.WriteLine("Digite o canal desejado:");
                        int canal = int.Parse(Console.ReadLine());
                        controle.EscolherCanal(canal);
                        break;
                    case 5:
                        controle.AumentarVolume();
                        break;
                    case 6:
                        controle.DiminuirVolume();
                        break;
                    case 7:
                        controle.CanalAtual();
                        break;
                    case 8:
                        controle.VolumeAtual();
                        break;
                    case 9:
                        return;

                }
            }
        }
    }
}