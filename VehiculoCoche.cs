using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_de_Objetos_y_Herencia_WEN
{
    class VehiculoCoche : BaseVehículo
    {
        public VehiculoCoche() { }

        public VehiculoCoche(int iD, string marca, string modelo, int año, int numPuertas)
          : base(iD, marca, modelo, año)
        {
            NumPuertas = numPuertas;
        }

        public int NumPuertas { get; set; }

    }
}
