using CSharp_OlimpiadasMatematica2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OlimpiadasMatematica2017.Metodos
{
    //METODO GAME10 - DISCO VOADOR
    class Game10
    {
        public string Game(Game10Models position)
        {
            string qndVezes = String.Empty;

            if (position.Aviao < position.Disco)
            {
                qndVezes = Convert.ToString(position.Disco - position.Aviao);
            }
            else if (position.Aviao > position.Disco)
            {
                int result = position.QtdPosicoes - position.Aviao;
                qndVezes = Convert.ToString(result + position.Disco);
            }
            else if (position.Aviao.Equals(position.Disco))
            {
                qndVezes =  "0";
            }

            return ("A quantidade de vezes necessaria para atingir o disco viador é: "+qndVezes);
        }



    }
}
