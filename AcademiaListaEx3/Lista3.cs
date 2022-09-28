namespace AcademiaListaEx3
{
    internal class Lista3
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
            int numero;
            do
            {
                Console.WriteLine("Digite um número inteiro positivo:");
                numero=int.Parse(Console.ReadLine());
                if (numero <= 0)
                {
                    Console.WriteLine("Numero inválido, digite novamente");
                }
            } while (numero <= 0);
            Console.Write("Números pares entre 1 e "+numero+": ");
            for (int i = 1; i < numero; i++)
            {             
                if (i % 2 == 0)
                {
                    Console.Write(i+" ");
                }
            }
        }
        public static void questao2()
        {
            String repetir = "S";
            do
            {
                int numero;
                do
                {
                    Console.WriteLine("Digite um número inteiro positivo:");
                    numero = int.Parse(Console.ReadLine());
                    if (numero <= 0)
                    {
                        Console.WriteLine("Numero inválido, digite novamente");
                    }
                } while (numero <= 0);
                Console.Write("Números pares entre 1 e " + numero + ": ");
                for (int i = 1; i < numero; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Deseja informar outro número?(S/N)");
                repetir = Console.ReadLine().ToUpper();
            } while (repetir == "S");
        }
        public static void questao3()
        {
            int numero=0;
            do
            {
                Console.WriteLine("Digite um número qualquer ou 0 para finalizar:");
                numero=int.Parse(Console.ReadLine());
                if (numero == 0)
                    break;
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " é par!");
                }
                else
                {
                    Console.WriteLine(numero + " é impar!");

                }
                bool primo=true;
                for (int i = 3; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                    }
                }
                if (primo)
                {
                    Console.WriteLine(numero + " é primo!");
                }
                else
                {
                   Console.WriteLine(numero + " não é primo!");

                }

            } while (numero > 0 || numero < 0);

        }
        public static void questao4()
        {
            String voto = "";
            int votoJoao = 0,votoZeca=0,votoBranco=0;
            while (!voto.Equals("FIM"))
            {
                Console.WriteLine("Digite o voto:");
                voto = Console.ReadLine().ToUpper();
                if (voto.Equals("JOAO"))
                {
                    votoJoao++;

                }
                else if (voto.Equals("ZECA"))
                {
                    votoZeca++;
                }else if (voto.Equals("BRANCO"))
                {
                    votoBranco++;
                }
            }
            Console.WriteLine(votoJoao + " votos no João, "+votoZeca+" Votos no Zeca e "+votoBranco+" votos brancos.");

        }
        public static void questao5()
        {
            String voto = "";
            int votoJoao = 0, votoZeca = 0, votoBranco = 0,votoNulo=0;
            while (!voto.Equals("FIM"))
            {
                Console.WriteLine("Digite o voto:");
                voto = Console.ReadLine().ToUpper();
                if (voto.Equals("JOAO"))
                {
                    votoJoao++;

                }
                else if (voto.Equals("ZECA"))
                {
                    votoZeca++;
                }
                else if (voto.Equals("BRANCO"))
                {
                    votoBranco++;
                }else if (!voto.Equals("FIM"))
                {
                    votoNulo++;
                }
            }
            Console.WriteLine(votoJoao + " votos no João, " + votoZeca + " Votos no Zeca, " + votoBranco + " votos brancos e "+votoNulo+" votos nulos");

        }
        public static void questao6()
        {
            int idade = 0;
            do
            {
                Console.WriteLine("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade < 0)
                    Console.WriteLine("Idade inválida, digite novamente!");
            } while (idade < 0);
            Console.WriteLine("A idade digitada foi: " + idade);
        }
        public static void questao7()
        {
            Console.WriteLine("Digite um nome:");
            String nome = Console.ReadLine();
            if(nome.Equals("") || nome.Equals(" ") || nome.Any(char.IsDigit))
            {
                Console.WriteLine("nome inválido, encerrando...");
                return;
            }
          
            Console.WriteLine("Digite a idade:");
            int idade = int.Parse(Console.ReadLine());
            if (idade <= 0)
            {
                Console.WriteLine("idade inválida, encerrando...");
                return;
            }
            Console.WriteLine("Digite o salário:");
            double salario=double.Parse(Console.ReadLine());
            if (salario <= 0)
            {
                Console.WriteLine("salário inválido, encerrando...");
                return;
            }
            Console.WriteLine("Nome: "+nome+
                "\nIdade: "+idade+
                "\nSalário: "+salario);
             
        }
        public static void questao8()
        {
            String continua = "";
            do
            {
                Console.WriteLine("Digite um inteiro:");
                int numero=int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par!");
                }
                else
                {
                    Console.WriteLine("O número é impar!");
                }
                Console.WriteLine("Verificar novo número?(S/N)");
                continua = Console.ReadLine().ToUpper();

            } while (continua=="S");
            Console.WriteLine("Encerrando...");
        }
        public static void questao9()
        {
            int entre1e3 = 0, entre4e7 = 0, maisDe8 = 0, semFilhos = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Digite a quantidade de filhos da família "+(i+1)+":");
                int filhos = int.Parse(Console.ReadLine());
                if (filhos >= 1 && filhos <= 3)
                    entre1e3++;
                else if(filhos>=4 && filhos <= 7)
                    entre4e7++;
                else if (filhos>=8)
                    maisDe8++;
                else
                    semFilhos++;


            }
            Console.WriteLine(semFilhos+" Famílias não tem filhos\n"+
                entre1e3+" Famílias tem entre 1 e 3 filhos\n"+
                entre4e7+" Famílias tem entre 4 e 7 filhos\n" +
                maisDe8+" Famílias tem 8 ou mais filhos");
        }
        public static void questao10()
        {
            int numMasculino = 0, numFeminino = 0, menorDe30 = 0, maiorDe60=0;
            int mediaIdadeMulheres = 0;
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Digite nome, sexo(M/F) e idade:");
                string nome = Console.ReadLine();
                string sexo = Console.ReadLine().ToUpper();
                int idade = int.Parse(Console.ReadLine());
                if (sexo.Equals("F"))
                {
                    mediaIdadeMulheres += idade;
                    numFeminino++;
                }
                else if (sexo.Equals("M"))
                {
                    numMasculino++;
                }
                if (idade < 30)
                    menorDe30++;
                else if(idade>60)
                    maiorDe60++;
            }
            mediaIdadeMulheres = mediaIdadeMulheres / numFeminino;
            Console.WriteLine(numMasculino+" homens\n"+
                numFeminino+" mulheres\n"+
                menorDe30+" menor que 30 anos\n"+
                maiorDe60+" maior de 60 anos\n"+
                mediaIdadeMulheres+" é a média de idade das mulheres!");
        }
        public static void questao11()
        {
            double nota = 0, alunos = 0, somanotas = 0, media=0,maisAlta=0,maisBaixa=99999;
            while (true)
            {
                Console.WriteLine("Digite a nota:");
                nota = int.Parse(Console.ReadLine());
                if (nota == -1)
                    break;
                alunos++;
                somanotas += nota;
                media = somanotas / alunos;
                if (nota > maisAlta)
                    maisAlta=nota;
                if (nota < maisBaixa)
                    maisBaixa = nota;
                Console.WriteLine("Nota: "+nota+
                    "\nMédia: "+media+
                    "\nMais Alta: "+maisAlta+
                    "\nMais Baixa: "+maisBaixa);
            }
        }
        public static void questao12()
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine("Soma dos 100 primeiros inteiros: "+soma);
        }
        public static void questao13()
        {
            int soma = 0;
            for (int i = 1; i < 500; i++) 
            {
                if(i%2 == 0)
                    soma += i;
            }
            Console.WriteLine("Soma dos números pares entre 1 e 500: " + soma);

        }
        public static void questao14()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("2^"+i+"="+Math.Pow(2,i));
            }
        }
        public static void questao15()
        {
            int[] pesos = { 2, 1, 2, 4 };
            int somaPesos = 0;
            double media = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite a nota "+(i+1)+":");
                double nota=double.Parse(Console.ReadLine());
                somaPesos+=pesos[i];
                media += (nota * pesos[i]);

            }
            media = media / somaPesos;
            if(media>=7)
                Console.WriteLine("Aprovação obtida com média "+media);
            else
                Console.WriteLine("Reprovação com média "+media);

        }
        public static void questao16()
        {
            int numero = 0;
            do
            {
                Console.WriteLine("Digite um número entre 1 e 50:");
                numero = int.Parse(Console.ReadLine());
                if (numero > 50 || numero < 1)
                    Console.WriteLine("Número inválido, digite novamente");
            } while (numero > 50 || numero<1);
            int multExcessiva = numero;
            int multiplicador = 3;
            while ((numero*multiplicador) < 250)
            {
                multExcessiva = numero * multiplicador;
                multiplicador = multiplicador* 3;
            }
            Console.WriteLine("Resultado: "+multExcessiva);
        }
        public static void questao17()
        {
            for (int i = 15; i <= 200; i++)
            {
                Console.WriteLine(i+"^2 = "+Math.Pow(i,2));
            }
        }
        public static void questao18()
        {
            Console.WriteLine("digite um número e a potência desejada:");
            int numero = int.Parse(Console.ReadLine());
            int potencia = int.Parse(Console.ReadLine());
            double resultado = Math.Pow(numero, potencia);
            Console.WriteLine(numero+"^"+potencia+" = "+resultado);
        }
        public static void questao19()
        {
            double salario = 0, mediaSalario = 0, mediaFilhos = 0, maiorSalario = 0;
            double salMenorQue100=0,porcentSalAte100 = 0;
            int pesquisados = 0;
            while (true) { 
                Console.WriteLine("Digite o salário:");
                salario = double.Parse(Console.ReadLine());
                if (salario < 0)
                    break;
                pesquisados++;
                Console.WriteLine("Digite o número de filhos: ");
                int numFilhos=int.Parse(Console.ReadLine());
                mediaSalario = (mediaSalario+salario) / pesquisados;
                mediaFilhos = (mediaFilhos+numFilhos)/ pesquisados;
                if (salario > maiorSalario)
                    maiorSalario = salario;
                if (salario <= 100)
                {
                    salMenorQue100++;
                    porcentSalAte100 = (salMenorQue100 * 100) / pesquisados;
                }
                Console.WriteLine(
                    "Média de salário da população: "+mediaSalario
                    + "\nMédia do número de filhos: "+mediaFilhos
                    + "\nMaior Salário: "+maiorSalario
                    + "\nPercentual com salário menor que R$:100,00: "+porcentSalAte100+"%");
            }
            Console.WriteLine("Encerrando...");

        }
        public static void questao20()
        {
            String sexo = "",corOlhos="",corCabelos="";
            int idade = 0, habitantes = 0;
            int maiorIdade = 0;
            int quantFem = 0;//sexo feminino cuja idade está entre 18 e 35 anos e que tenham olhos verdes e cabelos loiros


            while (true)
            {
                Console.WriteLine("Digite a idade de tal habitante:");
                idade = int.Parse(Console.ReadLine());
                if (idade ==-1)
                    break;
                habitantes++;
                Console.WriteLine("Digite o sexo (M/F): ");
                sexo=Console.ReadLine().ToUpper();
                Console.WriteLine("Digite a cor dos olhos (azul/verde/castanho):");
                corOlhos=Console.ReadLine().ToLower();
                Console.WriteLine("Digite a cor do cabelo (loiro/castanho/preto):");
                corCabelos = Console.ReadLine().ToLower();

                if (idade > maiorIdade)
                    maiorIdade = idade;

                if (sexo.Equals("F") && corOlhos.Equals("verde") && corCabelos.Equals("loiro") && idade >= 18 && idade <= 35)
                    quantFem++;        
                }

            Console.WriteLine("Maior idade: " + maiorIdade
                + "\nMulheres com cabelo loiro e olhos verdes: " + quantFem);
        }
            
    }
    
}