
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    
        class estudiante_secundaria : estudiante, IEstudiante
        {
            public int nive_terminado { get; set; }
            public int precioi_fijo { get; set; }

            public estudiante_secundaria(int nive_terminado, string nombre, string apellido, string institucion, int cedula) : base(nombre, apellido, institucion, cedula)
            {
                this.nivel_terminado = nive_terminado;
                this.precioi_fijo = 10;
            }
            public void mostrar_datos()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Apellido:" + apellido);
                Console.WriteLine("Nombre de Institucion: " +institucion);
                Console.WriteLine("Numero de cedula: " + cedula);
                Console.WriteLine("Nivel de estudio: " + nivel_terminado);
            }
            public void matricula()
            {
                int operacion;
                operacion = nivel_terminado* this.precioi_fijo;
                Console.WriteLine("La Matricula de un Estudiante de secundaria");
                Console.WriteLine("Por " + nivel_terminado + " nivel se calcula un valor de " + operacion);
            }
        }
    }


