using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteEntrevista
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 20;
            int disco = 8;
            int aviao = 13;


            //GAME 10
            int game10 = Game10(numero, disco, aviao);
            Console.WriteLine("O minimo de vezes é: " + game10);
            Console.WriteLine("-------------------------------------------");
            Console.ReadLine();



            //TROCANDO AS BOTAS
            int[] botasEsquerda = { 22, 20, 23, 25 , 22, 22, 20 , 20 };
            int[] botasDireita = { 22, 20, 23, 25 , 22, 22, 22, 25 };
            
            TrocandoBotas(botasEsquerda, botasDireita);
            Console.WriteLine("-------------------------------------------");
            Console.ReadLine();
        }

        //METODO GAME10 - DISCO VOADOR
        public static int Game10(int numeroCampos, int disco, int aviao)
        {
            if (aviao < disco) //se o aviao estiver antes do disco
            {
                int resultado = disco - aviao;
                return resultado;
            }
            if (aviao > disco) //se o aviao estiver depois do disco
            {
                int resultado = numeroCampos - aviao;
                int final = disco + resultado;
                return final;
            }
            return 0; //se o aviao for igual ao disco
        }

        //METODO TROCANDO AS BOTAS
        public static void TrocandoBotas(int[] botasEsquerda, int[] botasDireita)
        {
            int totalDePares = 0;
            var test1 = botasEsquerda.OrderBy(s => s);
            var teste2 = botasDireita.OrderBy(s => s);

            foreach (int item in test1)
            {
                foreach (int item2 in teste2)
                {
                    if (item == item2 && item != 0)
                    {
                        totalDePares++;
                        continue;
                    }
                }
            }
            Console.WriteLine("Total de pares é: "+ totalDePares);
        }





    }
}
