using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_de_Objetos_y_Herencia_WEN
{
    internal class Acciones
    {
        Dictionary<int, VehiculoCoche> diccionariocoche = new Dictionary<int, VehiculoCoche> ();
        Dictionary<int, VehiculoCamion> diccionariocamion = new Dictionary<int, VehiculoCamion>();

        VehiculoCoche vcam = new VehiculoCoche ();
        VehiculoCamion vche = new VehiculoCamion ();

       

        public void AddCoche()
        {
            Console.WriteLine("Dame el Id del vehiculo");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame la marca del vehiculo");
            string marca = Console.ReadLine();

            Console.WriteLine("Dame el modelo del vehiculo");
            string modelo = Console.ReadLine(); 

            Console.WriteLine("Dame el anio del vehiculo");
            int anio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame el numero de puertas del vehiculo");
            int numPuertas = Convert.ToInt32(Console.ReadLine());

            diccionariocoche.Add(id, new VehiculoCoche(vche.ID, vche.Marca, vche.Modelo, vche.Año, numPuertas));

        }

        public void AddCamion()
        {
            Console.WriteLine("Dame el Id del vehiculo");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame la marca del vehiculo");
            string marca = Console.ReadLine();

            Console.WriteLine("Dame el modelo del vehiculo");
            string modelo = Console.ReadLine();

            Console.WriteLine("Dame el anio del vehiculo");
            int anio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame la capacidad de carga del vehiculo");
            int capacidadCarga = Convert.ToInt32(Console.ReadLine());

            diccionariocamion.Add(id, new VehiculoCamion(vcam.ID,vcam.Marca,vcam.Modelo,vcam.Año, capacidadCarga));

        }

        public void MostrarCoches()
        {
            foreach (var vche in diccionariocoche)
            {
                Console.WriteLine(vche.Value.ID);
                Console.WriteLine(vche.Value.Marca);
                Console.WriteLine(vche.Value.Modelo);
                Console.WriteLine(vche.Value.Año);
                Console.WriteLine(vche.Value.NumPuertas);
                Console.WriteLine("--------------------");
            }
        }

        public void MostrarCamiones()
        {
            foreach (var vcam in diccionariocamion)
            {
                Console.WriteLine(vcam.Value.ID);
                Console.WriteLine(vcam.Value.Marca);
                Console.WriteLine(vcam.Value.Modelo);
                Console.WriteLine(vcam.Value.Año);
                Console.WriteLine(vcam.Value.CapacidadCarga);
                Console.WriteLine("--------------------");
            }
        }

        public int ContarCoches()
        {
            return diccionariocoche.Count;

        }

        public int ContarCamiones()
        {
            return diccionariocamion.Count;

        }


    }
}
