using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
     public class estudiante
    {
        public string nombre;
        public string apellido;
        public string institucion;
        public int cedula;
        public  int nivel_terminado;

        public estudiante(string nombre,string apellido,string institucion,int cedula,int nivel_terminado)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.institucion = institucion;
            this.cedula = cedula;
            this.nivel_terminado=nivel_terminado;
            

        }
    }

    }
}
