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
                        qndVezes =  "0";
                    }
                    else{
                        return "erro na aplicacao";
                    }     
	            }
	        }
            else{
                return "erro na aplicacao";
            }               
            return ("A quantidade de vezes necessaria para atingir o disco viador é: "+qndVezes);
        }







    }
}
