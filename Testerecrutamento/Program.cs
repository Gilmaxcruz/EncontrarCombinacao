using System;
using System.Linq;

namespace Testerecrutamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //Alvo 10
            int[] array1 = { 3, 8, 9, 6, 8, 5 }; //Alvo 10
            int[] array2 = { 4, 8, 6, 1, 3, 7 }; //Alvo 7

            Console.WriteLine("Primeiro Array");
            EncontrarCombinacao(array, 10);
            Console.WriteLine("Segundo Array");
            EncontrarCombinacao(array1, 10);
            Console.WriteLine("Terceiro Array");
            EncontrarCombinacao(array2, 7);
        }

        public static void EncontrarCombinacao(int[] input, int alvo)
        {
            int[] valor = input;

            for (int v = 0; v < valor.Length; v++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != valor[v])
                    {
                        int primeiroValor = input[i];
                        int segundoValor = valor[v];

                        if (primeiroValor + segundoValor == alvo)
                        {
                            Console.WriteLine($"A soma de { input[i] } na posição {i} e {valor[v]} na posição {v} = {alvo}");
                            valor = valor.Where(x => x != valor[v]).ToArray();
                        }
                    }

                }
            }

        }
    }


}
