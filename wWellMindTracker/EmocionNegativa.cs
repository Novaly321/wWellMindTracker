using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wWellMindTracker
{
    public class EmocionNegativa : Emocion
    {

        public EmocionNegativa() 
        {

            Nombre = "Negativa";

        }

        public override string Mensaje()
        {
            return "Ánimo, todos los días son una nueva oportunidad.";
        }


    }
}
