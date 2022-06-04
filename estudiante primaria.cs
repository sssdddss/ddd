using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class estudiante_primaria : estudiante, IEstudiante
    {
        public int anual { get; set; }
        public int valor_fijo { get; set; }

        public estudiante_primaria(int nive_terminado, string nombre, string apellido, string institucion, int cedula) : base(nombre, apellido, institucion, cedula)
        {
            this.anual = anual;
            this.valor_fijo = 1000;
        }
        public void mostrar_datos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido:" + apellido);
            Console.WriteLine("Nombre de Institucion: " + institucion);
            Console.WriteLine("Numero de cedula: " + cedula);
            Console.WriteLine("Nivel de estudio: " + nivel_terminado);
        }
        public void matricula()
        {
            int operacion;
            operacion = anual * this.valor_fijo;
            Console.WriteLine("La Matricula de un Estudiante de primaria");
            Console.WriteLine("Por " + valor_fijo + " nivel se calcula un valor de " + operacion);
        }
    }

}
