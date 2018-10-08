using OlimpiadasInformatica2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpiadasInformatica2017.Metodos
{
    class Metodos
    {
        //METODO INICIAL
        public int MetodoIndex()
        {
            Console.WriteLine("Olimpiadas de Informatica 2017 - Teste de funções em C#");
            Console.WriteLine("Digite a opcao desejada: \n1 - Game10 \n2 - teste \n0 - Sair");
            int select = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            Metodos mtd = new Metodos();
            string resultado = String.Empty;
            switch (select)
            {
                case 1:
                    //Game10 - disco voador
                    Console.WriteLine("Game 10");
                    Console.WriteLine("Digite: Quantidade posições, posição do disco e posição do aviao");

                    Game10 pos = new Game10
                    {
                        QtdPosicoes = Convert.ToInt32(Console.ReadLine()),
                        Disco = Convert.ToInt32(Console.ReadLine()),
                        Aviao = Convert.ToInt32(Console.ReadLine()),
                    };

                    resultado = mtd.Game(pos);
                    Console.WriteLine(resultado);
                    break;
                case 2:
                    //Botas Trocadas
                    Console.WriteLine("Botas Trocadas");
                    Console.WriteLine("");

                    Botas botas = new Botas
                    {
                        QtdPosicoes = Convert.ToInt32(Console.ReadLine()),
                        Disco = Convert.ToInt32(Console.ReadLine()),
                        Aviao = Convert.ToInt32(Console.ReadLine()),
                    };

                    resultado = mtd.TrocandoBotas(botas);
                    Console.WriteLine(resultado);
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    Environment.Exit(0);
                    break;
            }
            //=======================================================//
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Selecione: \n1 - Ir para menu \n0 - Sair");
            return Convert.ToInt32(Console.ReadLine());
        }

        //METODOS GAME10
        private string Game(Game10 position)
        {
            string qndVezes = String.Empty;
            if (position.QtdPosicoes > position.Aviao || position.Disco < position.QtdPosicoes)
            {
                if (position.QtdPosicoes > 3 || position.QtdPosicoes < 100)
                {
                    //se o disco estuver na frente
                    if (position.Aviao < position.Disco)
                    {
                        qndVezes = Convert.ToString(position.Disco - position.Aviao);
                    }
                    //se o aviao estiver na frente
                    else if (position.Aviao > position.Disco)
                    {
                        int result = position.QtdPosicoes - position.Aviao;
                        qndVezes = Convert.ToString(result + position.Disco);
                    }
                    //se forem iguais
                    else if (position.Aviao.Equals(position.Disco))
                    {
                        qndVezes = "0";
                    }
                    else
                    {
                        return "erro na aplicacao";
                    }
                }
            }
            else
            {
                return "erro na aplicacao";
            }
            return ("A quantidade de vezes necessaria para atingir o disco viador é: " + qndVezes);
        }

        //METODO TROCANDO BOTAS
        private string TrocandoBotas(Botas botas)
        {
            return "";
        }

    }
}
