using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wWellMindTracker
{
    public abstract class Emocion
    {
        public string Nombre { get; set; }

        public abstract string Mensaje();

    }
}
