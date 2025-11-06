using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wWellMindTracker
{
    public static class EmocionFactory
    {

        public static Emocion CrearEmocion(string tipo) 
        {

            if (tipo == "Positiva")
            {
                return new EmocionPositiva();
            }
            else if (tipo == "Negativa")
            {
                return new EmocionNegativa();
            }
            else if (tipo == "Neutra")
            {
                return new EmocionNeutra();
            }
            else
            {
                return null;
            }


        }


    }
}
