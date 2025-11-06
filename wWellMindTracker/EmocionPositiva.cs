using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wWellMindTracker
{
    public class EmocionPositiva : Emocion
    {

        public EmocionPositiva() 
        {

            Nombre = "Positiva";
        
        }

        public override string Mensaje()
        {

            return "¡Excelente! Sigue cuidando tu bienestar emocional.";


        }

    }
}
