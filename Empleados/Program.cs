using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class Program
    {
       static List<Empleado> lista=new List<Empleado>(); 
       static void Main(string[] args)
        {
            
            int r = 0;
            do
            {
                Console.WriteLine("*************MENU*************");
                Console.WriteLine("1. Alta");
                Console.WriteLine("2. Listar");
                Console.WriteLine("3. Salir");
                Console.Write("Que quieres hacer:");
                r= Convert.ToInt32(Console.ReadLine());
                switch (r)
                {
                    case 1:
                        alta();
                        break;
                    case 2:
                        listar();
                        break;
                }
                
            } while (r != 3);


        }

        private static void listar()
        {
            foreach (var empleado in lista)
            {
                Console.WriteLine("{0} Estudios {1} Puesto {2}",
                    empleado.Nombre,empleado.Estudios,
                    empleado.Puesto);
            }
        }

        private static void alta()
        {
            try
            {
                var e=new Empleado();
                Console.WriteLine("Nombre");
                e.Nombre= Console.ReadLine();
                Console.WriteLine("Edad");
                e.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Estudios");

                var es = Console.ReadLine();
                var esN = 0;
                if (int.TryParse(es, out esN))
                {
                    if (Enum.IsDefined(typeof (Estudios), esN))
                        e.Estudios = (Estudios) esN;

                }
                else
                {
                    Estudios est;
                    Estudios.TryParse(es, out est);
                    e.Estudios = est;

                }
                Console.WriteLine("Puesto");
                var pu = Console.ReadLine();
                var puN = 0;
                if (int.TryParse(pu, out puN))
                {
                    if (Enum.IsDefined(typeof(Puesto), puN))
                        e.Puesto = (Puesto)puN;

                }
                else
                {
                    Puesto est;
                    Puesto.TryParse(pu, out est);
                    e.Puesto = est;

                }

                lista.Add(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
