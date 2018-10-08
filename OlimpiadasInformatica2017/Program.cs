using OlimpiadasInformatica2017.Models;
using System;

namespace OlimpiadasInformatica2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos.Metodos mtd = new Metodos.Metodos();
            int retorno = mtd.MetodoIndex();

            if (retorno.Equals(1))
            {
                mtd.MetodoIndex();
            }
            else
            {
                //fecha aplicacao
                Environment.Exit(0);
            }
        }
    }
}
