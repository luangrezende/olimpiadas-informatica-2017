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
            Console.WriteLine("Olimpiadas de Informatica 2017 - Teste de funções em C#");
            Console.WriteLine("Digite a opcao desejada: \n1 - Game10 \n0 - Sair");
            int select = Convert.ToInt16(Console.ReadLine());

            switch (select)
            {
                case 1:
                    //Game10 - disco voador
                    Metodos.Metodos game10 = new Metodos.Metodos();
                    Console.WriteLine("Game 10");
                    Console.WriteLine("Digite: Quantidade posições, posição do disco e posição do aviao");

                    AppModels pos = new AppModels
                    {
                        QtdPosicoes = Convert.ToInt32(Console.ReadLine()),
                        Disco = Convert.ToInt32(Console.ReadLine()),
                        Aviao = Convert.ToInt32(Console.ReadLine()),
                    };

                    string resultado = game10.Game(pos);
                    Console.WriteLine(resultado);
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
            }
            //=======================================================//
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
