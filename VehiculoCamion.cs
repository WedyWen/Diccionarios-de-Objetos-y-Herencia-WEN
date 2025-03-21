using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_de_Objetos_y_Herencia_WEN
{
    internal class VehiculoCamion : BaseVehículo
    {
        public VehiculoCamion() {}

        public VehiculoCamion(int iD, string marca, string modelo, int año, int capacidadCarga)
            : base(iD, marca, modelo, año)
        {
            CapacidadCarga = capacidadCarga;
        }

        public int CapacidadCarga { get; set; }

    }
}
