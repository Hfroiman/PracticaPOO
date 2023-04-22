using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjmploAnimales
{
    class Perro: Animal
    {
        public string Nombre { get; set; }

        public override string comunicarse()
        {
            return "Guau guaau..";
        }
    }
}
