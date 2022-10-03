using System;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

namespace AcademiaListaEx5
{
    internal class Lista5
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
            /*QUESTÃO 9*/
            questao9();
            /*QUESTÃO 10*/
            questao10();
            /*QUESTÃO 11*/
            questao11();
            /*QUESTÃO 12*/
            questao12();
        }
      
        public static void questao1()
        {
            int[,] matriz = new int[5, 3];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine("Digite o elemento ["+(i+1)+",1] da matriz:");
                matriz[i, 0] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i, 1] = matriz[i, 0] + 10;
                matriz[i, 2] = matriz[i, 0] * 2;
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
        public static void questao2()
        {
            int[,] matriz = new int[3, 3];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento ["+(i+1)+" "+ (j+1)+"] da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int somaLinha = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    somaLinha+=matriz[i,j];
                }
                Console.WriteLine("Linha "+(i+1)+": "+somaLinha);
            }

            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                int somaColuna = 0;
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    somaColuna += matriz[j,i];
                }
                Console.WriteLine("Coluna " + (i + 1) + ": " + somaColuna);
            }

        }
        public static void questao3()
        {          
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento [" + (i + 1) + " " + (j + 1) + "] da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine("["+(i+1)+" "+(i+1)+"] = " + matriz[i,i]);
            }
        }
        public static void questao4()
        {
            int[,] matriz = new int[5, 5];
            int pares = 0, impares = 0, positivos = 0, negativos=0, zeros = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento [" + (i + 1) + " " + (j + 1) + "] da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());                  
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j]%2==0)
                        pares++;
                    else
                        impares++;

                    if (matriz[i, j] > 0)
                        positivos++;
                    else if (matriz[i, j] < 0)
                        negativos++;
                    else
                        zeros++;
                }
            }
            Console.WriteLine("Pares: "+ pares+"\nÍmpares: "+impares+"\nPositivos: "+positivos+"\nNegativos: "+negativos+"\nZeros: "+zeros);
        }
        public static void questao5()
        {
            double[,] matriz1=new double[2,3];
            double[,] matriz2=new double[2,3];
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento [" + (i + 1) + " " + (j + 1) + "] da matriz 1:");
                    matriz1[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento [" + (i + 1) + " " + (j + 1) + "] da matriz 2:");
                    matriz2[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double[,] matrizSoma=new double[2,3];

            for (int i = 0; i < matrizSoma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSoma.GetLength(1); j++)
                {
                    matrizSoma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            for (int i = 0; i < matrizSoma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSoma.GetLength(1); j++)
                {
                    Console.Write(matrizSoma[i, j] + " ");
                }
                Console.WriteLine();
            }


        }     
        public static void questao6()
        {
            Random random = new Random();
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                }
            }
            int maior = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if(maior < matriz[i, j])
                        maior = matriz[i, j];
                }
            }
            Console.WriteLine("Maior valor da matriz: "+maior);
        }
        public static void questao7()
        {
            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento [" + (i + 1) + " " + (j + 1) + "] da matriz A:");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento [" + (i + 1) + " " + (j + 1) + "] da matriz B:");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] C = new int[3, 3];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {                   
                    C[i, j] = A[i, j] - B[i,j];
                }
            }
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void questao9()
        {
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento ["+(i+1)+","+(j+1)+"] da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Em ordem de inserção:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Na ordem invertida:");
            for (int i = matriz.GetLength(0)-1; i >=0; i--)
            {
                for (int j = matriz.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void questao10()
        {
            int[,] matriz = new int[3, 3];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento [" + (i + 1) + "," + (j + 1) + "] da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Digite um número qualquer:");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (numero == matriz[i, j])
                    {
                        Console.WriteLine(numero+" existe na matriz!");
                        return;
                    }       
                }
            }
            Console.WriteLine(numero + " não existe na matriz!");
        }              
        public static void questao11()
        {
            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            int somaA = 0, somaB = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento [" + (i + 1) + " " + (j + 1) + "] da matriz A:");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento [" + (i + 1) + " " + (j + 1) + "] da matriz B:");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int mediaA = somaA / 16;
            int mediaB = somaB / 16;
            int mediaGeral = (somaA + somaB) / 32;
            int acimaMediaA = 0, abaixoMediaA = 0, naMediaA = 0; 
            int acimaMediaB = 0, abaixoMediaB = 0, naMediaB=0;
            int acimaMediaGeral = 0, abaixoMediaGeral = 0, naMediaGeral = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] > mediaA)
                        acimaMediaA++;
                    else if(A[i, j] < mediaA)
                        abaixoMediaA++;
                    else if (A[i,j]==mediaA)
                        naMediaA++;

                    if (B[i, j] > mediaB)
                        acimaMediaB++;
                    else if (B[i, j] < mediaB)
                        abaixoMediaB++;
                    else if (B[i, j] == mediaB)
                        naMediaB++;

                    if (A[i, j] > mediaGeral)
                        acimaMediaGeral++;
                    else if (A[i, j] < mediaGeral)
                        abaixoMediaGeral++;
                    else if (A[i, j] == mediaGeral)
                        naMediaGeral++;

                    if (B[i, j] > mediaGeral)
                        acimaMediaGeral++;
                    else if (B[i, j] < mediaGeral)
                        abaixoMediaGeral++;
                    else if (B[i, j] == mediaGeral)
                        naMediaGeral++;

                }
            }
            Console.WriteLine("Matriz A:\nNa média: "+naMediaA+"\nAbaixo da média: "+abaixoMediaA+"\nAcima da média: "+acimaMediaA);
            Console.WriteLine("Matriz B:\nNa média: " + naMediaB + "\nAbaixo da média: " + abaixoMediaB + "\nAcima da média: " + acimaMediaB);
            Console.WriteLine("Geral:\nNa média: " + naMediaGeral + "\nAbaixo da média: " + abaixoMediaGeral + "\nAcima da média: " + acimaMediaGeral);

        }
        public static void questao12()
        {
            double[,] A = new double[3, 3];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine("Digite o elemento [" + (i + 1) + " " + (j + 1) + "] da matriz:");
                    A[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double[,] B = new double[3, 3];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    int somaIndices = i + j;
                    if (somaIndices != 0)
                    {
                        B[i,j]= A[i,j]/somaIndices;
                    }
                    else
                    {
                        Console.WriteLine("Não existe divisão quando a soma dos índices forem 0, então simbolicamente B["+i+","+j+"] = 0");
                        B[i, j] = 0;
                    }
                }
            }
            Console.WriteLine("Matriz resultante:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}