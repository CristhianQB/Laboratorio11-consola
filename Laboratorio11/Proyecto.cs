using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio11
{
    internal class Proyecto
    {
        public static void Main(string[] args)
        {
            int opcion = pantallas.menuPrincipal();
            do { 
                switch (opcion)
                {
                    case 0:
                        opcion = pantallas.menuPrincipal();
                        break;
                    case 1:
                        opcion = pantallas.RegistrarNota();
                        break;
                    case 2:
                        opcion = pantallas.NotaMayor();
                        break;
                    case 3:
                        opcion = pantallas.NotaMenor();
                        break;
                    case 4:
                        opcion = pantallas.BuscarNota();
                        break;
                    case 5:
                        opcion = pantallas.ModificarNota();
                        break;
                    case 6:
                        opcion = pantallas.NotasRegistradas();
                        break;
                    
                }
            }while (opcion != 7);
            

        }


    }
}
