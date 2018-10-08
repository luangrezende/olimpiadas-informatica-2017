using OlimpiadasInformatica2017.Metodos;
using OlimpiadasInformatica2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpiadasInformatica2017
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game10 - disco voador
            MetodosGame10 game10 = new MetodosGame10();
            Console.WriteLine("Digite as posicoes: ");
            Console.WriteLine("Aviao: ");
            Console.WriteLine("Disco voador: ");

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
