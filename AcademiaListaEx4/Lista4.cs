using System.Globalization;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;

namespace AcademiaListaEx4
{
    internal class Lista4
    {
        static void Main(string[] args)
        {
            /*QUESTÃO 1*/
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
        }
        public static void questao1()
        {
            int[] numeros = new int[10];
            int pares=0, impares=0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o número "+(i+1)+":");
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] % 2 == 0)
                    pares++;
                else
                    impares++;
            }
            Console.WriteLine("Quantidade de pares: "+pares+
                "\nQuantidade de ímpares: "+impares);

        }
        public static void questao2()
        {
            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];
            int[] vetor3 = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite o elemento "+(i+1)+" do vetor 1:");
                vetor1[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor 2:");
                vetor2[i] = int.Parse(Console.ReadLine());
                vetor3[i] = vetor1[i] + vetor2[i];

            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(vetor1[i] + " + " + vetor2[i] + " = " + vetor3[i]);
            }
        }
        public static void questao3()
        {
            int tamVetor = 20;
            int[] vetor = new int[tamVetor];
            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tamVetor; i++)
            {
                if (checarPrimo(vetor[i]))
                    Console.WriteLine(vetor[i]+" é primo!");
            }

            bool checarPrimo(int numero)
            {
                bool primo=true;
                for (int i = 2; i < numero; i++)
                {
                    if(numero%i == 0)
                        primo=false;
                }
                return primo;
            }
        }
        public static void questao4()
        {
            int tamVetor = 10;
            int[] vetor1 = new int[tamVetor];
            int[] vetor2 = new int[tamVetor];
            int[] vetor3 = new int[tamVetor];

            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor 1:");
                vetor1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor 2:");
                vetor2[i] = int.Parse(Console.ReadLine());
                vetor3[i] = vetor1[i] * vetor2[i];

            }
            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine(vetor1[i] + " * " + vetor2[i] + " = " + vetor3[i]);
            }
        }
        public static void questao5()
        {
            int tamVetor = 80;
            int [] vetor = new int[tamVetor];
            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            int posicao = 0, menor = vetor[0];
            for (int i = 1; i < tamVetor; i++)
            {
                if (vetor[i] < menor)
                {
                    posicao = i+1;
                    menor=vetor[i];

                }
            }
            Console.WriteLine("Menor valor é "+menor+" na posição "+posicao);
        }
        public static void questao6()
        {
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o elemento "+(i+1)+" do vetor:");
                vetor[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vetor na ordem contrária: ");
            for(int i = 9; i >=0; i--)
            {
                Console.Write(vetor[i]+" ");
            }
        }
        public static void questao7()
        {
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            int[] vetor2 = new int[10];
            int pos = 0;
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    vetor2[pos] = vetor[i];
                    pos++;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i]%2 != 0)
                {
                    vetor2[pos]= vetor[i];
                    pos++;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetor2[i]+" ");
            }

        }
        public static void questao8()
        {
            int tamVetor = 5;
            double[] vetor = new double[tamVetor];            
            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor:");
                vetor[i] = double.Parse(Console.ReadLine());

            }
            for (int i = 0; i < tamVetor; i++)
            {
                if(vetor[i] <0)
                    Console.WriteLine(vetor[i]+ " encontrado na posição "+(i+1));
            }
        }
        public static void questao9()
        {
           int[] vetor = new int[10];
         
           for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            int[] ordenado = vetor;
            for (int i = 9; i >0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if (ordenado[j] > ordenado[j + 1]){
                        int temp = ordenado[j];
                        ordenado[j] = ordenado[j+1];
                        ordenado[j+1] = temp;

                    }

                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(ordenado[i]+" ");
            }
            
        }     
        public static void questao10()
        {
            int tamVetor = 20;
            int[] vetor = new int[tamVetor];

            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            int[] vetorSemNulos = new int[tamVetor];
            for (int i = 0; i < tamVetor; i++)
            {
                if (vetor[i] == 0)
                    vetorSemNulos[i] = 2;
                else
                    vetorSemNulos[i] = vetor[i];
            }
            for (int i = 0; i < tamVetor; i++)
            {
                Console.Write(vetorSemNulos[i] + " ");
            }
        }
        public static void questao11()
        {
            int[] vetor = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Na ordem de inserção:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Na ordem invertida:");
            for (int i = 4; i >=0; i--)
            {
                Console.Write(vetor[i] + " ");
            }

        }
        public static void questao12()
        {
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor:");
                vetor[i] = int.Parse(Console.ReadLine());           
            }
            Console.WriteLine("Digite o número pra fazer a busca:");
            int numero=int.Parse(Console.ReadLine());
            bool existe = false;
            for (int i = 0; i < 10; i++)
            {
                if (numero == vetor[i])
                {
                    Console.WriteLine(numero+" encontrado na posição "+(i+1)+" do vetor");
                    existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine(numero+" não existe no vetor");
            }
        }      
        public static void questao13()
        {

            int tamVetor = 100;
            int[] vetor = new int[tamVetor];
            int cont2 = 0, cont4=0, cont8 = 0;
            
            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor, sendo um inteiro positivo:");
                int elemento=int.Parse(Console.ReadLine());
                if (elemento == -1)
                    return;
                else if (elemento == 2)
                    cont2++;
                else if (elemento == 4)
                    cont4++;
                else if (elemento == 8)
                    cont8++;
                Console.WriteLine("2 apareceu "+cont2+" vezes, 4 apareceu "+cont4+" vezes, 8 apaceceu "+cont8+" vezes");
                vetor[i] = elemento;
            }
            Console.WriteLine("Vetor lotado com 100 elementos");
            
        }

        public static void questao14()
        {
            Console.WriteLine("Digite o código numérico:");
            int codigo = int.Parse(Console.ReadLine());
            int tamVetor=5;
            int[] vetor = new int[tamVetor];

            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            switch (codigo)
            {
                case 0:
                    return;


            }
            if (codigo == 0)
            {
                return;
            }else if (codigo == 1)
            {
                for (int i = 0; i < tamVetor; i++)
                {
                    Console.Write(vetor[i]+" ");
                }
            }else if(codigo == 2)
            {
                for(int i = tamVetor - 1; i >= 0; i--)
                {
                    Console.WriteLine(vetor[i]+" ");
                }
            }


        }

        public static void questao15()
        {
            int tamVetor = 20;
            int[] vetor = new int[tamVetor];
            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            int[] vetorCopia= new int[tamVetor];
            for (int i = 0,j=tamVetor-1; i < tamVetor; i++,j--)
            {
                vetorCopia[i] = vetor[j];
            }
            for (int i = 0; i < tamVetor; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < tamVetor; i++)
            {
                Console.Write(vetorCopia[i]+" ");
            }
        }

        public static void questao16()
        {
            int tamVetor = 5;
            int[] x = new int[tamVetor];
            int[] y = new int[tamVetor];
            int tamDiferenca = tamVetor;
            int tamInterseccao = 0;

            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine("Digite o elemento "+(i + 1)+" do vetor X:");
                x[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tamVetor; i++)
            {
                Console.WriteLine("Digite o elemento " + (i + 1) + " do vetor Y:");
                y[i] = int.Parse(Console.ReadLine());
                if (x[i] == y[i])
                {
                    tamDiferenca--;
                    tamInterseccao++;
                }

            }
            int[] uniao=new int[tamVetor*2];
            for (int i = 0; i < tamVetor; i++)
            {
                uniao[i] = x[i];
            }           
            for (int i = tamVetor,j=0; i < tamVetor*2; i++,j++)
            {
                uniao[i] = y[j];
            }

            int[] diferenca = new int[tamDiferenca*2];
            for (int i = 0,j=0; i < tamVetor; i++)
            {
                if(x[i] != y[i])
                {
                    diferenca[j] = x[i];
                    j++;
                    diferenca[j] = y[i];
                    j++;
                }
            }

            int[] interseccao = new int[tamInterseccao];
            for (int i = 0,j=0; i <tamVetor; i++)
            {
                if (x[i] == y[i])
                {
                    interseccao[j] = x[i];
                    j++;
                }
            }

            Console.WriteLine("União:");
            for (int i = 0; i < tamVetor*2; i++)
            {
                Console.Write(uniao[i]+" ");
            }
            Console.WriteLine("\nDiferença:");
            for (int i = 0; i < tamDiferenca*2; i++)
            {
                Console.Write(diferenca[i]+ " ");
            }
            Console.WriteLine("\nIntersecção: ");
            for (int i = 0; i < tamInterseccao; i++)
            {
                Console.Write(interseccao[i] +" ");
            }
             
        }
        
    }

}