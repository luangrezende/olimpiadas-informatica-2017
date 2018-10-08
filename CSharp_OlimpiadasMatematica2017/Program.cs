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
            Game10Models pos = new Game10Models
            {
                QtdPosicoes = Convert.ToInt32(Console.ReadLine()),
                Aviao = Convert.ToInt32(Console.ReadLine()),
                Disco = Convert.ToInt32(Console.ReadLine())
            };

            string resultado = game10.Game(pos);
            Console.WriteLine(resultado);

            //=======================================================//
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
