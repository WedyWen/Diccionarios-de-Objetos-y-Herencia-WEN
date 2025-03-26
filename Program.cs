using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios_de_Objetos_y_Herencia_WEN
{
    internal class Program
    {
        public enum Menu
        {
            AgregarCOCHE = 1, AgregarCAMION, MostrarCOCHE, MostrarCAMION, ContarCOCHES, ContarCAMIONES, EliminarCOCHE, EliminarCAMION, ActualizarCOCHE, ActualizarCAMION, SALIR
        }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();

            while (true)
            {

                switch (menu())
                { 
                    case Menu.AgregarCOCHE:
                        acciones.AddCoche();
                        break;
                    case Menu.AgregarCAMION:
                        acciones.AddCamion();
                        break;
                    case Menu.MostrarCOCHE:
                        acciones.MostrarCoches();
                        break;
                    case Menu.MostrarCAMION:
                        acciones.MostrarCamiones();
                        break;
                    case Menu.ContarCOCHES:
                        acciones.ContarCoches();
                        break;
                    case Menu.ContarCAMIONES:
                        acciones.ContarCamiones();
                        break;
                    case Menu.EliminarCOCHE:
                        acciones.EliminarCoche();
                        break;
                    case Menu.EliminarCAMION:
                        acciones.EliminarCamion();
                        break;
                    case Menu.ActualizarCOCHE:
                        break;
                    case Menu.ActualizarCAMION:
                        break;
                    case Menu.SALIR:
                        break;
                    default:
                        break;
                }



            }


        }

        static Menu menu ()
        {
            Console.WriteLine("1) Agregar COCHE");
            Console.WriteLine("2) Agregar CAMION");
            Console.WriteLine("3) Mostrar COCHE");
            Console.WriteLine("4) Mostrar CAMION");
            Console.WriteLine("5) Contar COCHE");
            Console.WriteLine("6) Contar CAMION");
            Console.WriteLine("7) Eliminar COCHE");
            Console.WriteLine("8) Eliminar CAMION");
            Console.WriteLine("9) Actualizar COCHE");
            Console.WriteLine("10) AAtualizar CAMION");
            Menu opc =(Menu) Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
