using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wWellMindTracker
{
    public class EmocionNeutra : Emocion
    {

        public EmocionNeutra() 
        {

            Nombre = "Neutra";

        }


        public override string Mensaje()
        {
            return "Mantén la calma, estás en equilibrio emocional.";
        }

    }
}
