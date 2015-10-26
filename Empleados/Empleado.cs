using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    public enum Puesto { Programador=1,Analista, DirectorP,DirectorIt}
    public enum Estudios { Basico=1, Medios, Superiores, Doctor}
    public class Empleado
    {
        public String Nombre { get; set; }
        public Int32 Edad { get; set; }
        public Estudios Estudios { get; set; }

        private Puesto _puesto;
        public Puesto Puesto
        {
            get { return _puesto; }
            set
            {
                if ((int)value >(int) Estudios)
                {
                    throw new ExcepcionEmpleado(
                        "Estudios insuficientes");
                }

                _puesto = value;

            }
        }

       



    }
}
