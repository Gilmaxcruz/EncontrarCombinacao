using System;

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
            bool mensagem = false;

            for (int v = 0; v < input.Length; v++)
            {
                for (int i = v+1; i < input.Length; i++)
                {
                    int soma = input[i] + input[v];

                    if (soma == alvo)
                    {
                        Console.WriteLine($"A soma de {input[v]}  na posição {v} e { input[i] } na posição {i} = {alvo}");
                        mensagem = true;
                    }
                }
            }
            if (!mensagem) Console.WriteLine("Valor alvo não encontrado para os valores informados."); 
        }
    }
}
