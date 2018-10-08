using CSharp_OlimpiadasMatematica2017.Metodos;
using CSharp_OlimpiadasMatematica2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OlimpiadasMatematica2017
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game10 - disco voador
            Game10 game10 = new Game10();
            Game10Models pos = new Game10Models();

            pos.qtdPosicoes = Console.Read();
            pos.aviao = Console.Read();
            pos.disco = Console.Read();

            string resultado = game10.Game(pos);
            Console.WriteLine(resultado);

            //=======================================================//
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
