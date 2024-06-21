using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8_Exercício_11
{
    internal class Program
    {
        static string[,] FazerMatriz(string csv)
        {
            string[] vetor = csv.Split('\n');
            int linhas = vetor.Length;
            int colunas = vetor[0].Split(',').Length;

            string[,] matriz = new string[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                string[] dividido = vetor[i].Split(',');
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = dividido[j];
                }
            }
            




            return matriz;
        }
        
        static void Main(string[] args)
        {
            string csv = "nome,idade,sexo\nAna,25,F\nJoão,30,M\nMaria,22,F";
            string[,] matriz = FazerMatriz(csv);
            bool se = true;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz.GetLength(0) - 1 == i && matriz.GetLength(1) - 1 == j) Console.Write($"{matriz[i, j]} ");

                    else Console.Write($"{matriz[i, j]}, ");

                }
                Console.WriteLine();

            }

            
            Console.ReadLine();
        }
    }
}
