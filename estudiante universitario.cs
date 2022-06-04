using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class estudiante_universitario : estudiante, Iestudiante 
    {
        public int nivel_terminado { get; set; }
        public int precioacredito{ get; set; }
        

        public estudiante_universitario(int cantidadecredito, int precioacredito,string nombre,string apellido,string institucion,int cedula):base(nombre,apellido,institucion,cedula)
        {
            this.nivel_terminado = nivel_terminado;
            this.precioacredito = precioacredito;
        }
         
            public void mostrar_resultados()
        {
            Console.WriteLine("Nombre"+ nombre);
            Console.WriteLine("Apellido"+ apellido);
            Console.WriteLine("Nombre de institucion"+ institucion);
            Console.WriteLine("Numero de cedula" +cedula);
            Console.WriteLine("Nivel de estudio"+ nivel_terminado);
        }
        public void matricula()
        {
            int operacion;
            operacion =  cantidaddecredito*precioacredito;
            Console.WriteLine("La Matricula de la institucion es");
            Console.WriteLine(" la cantidad de total de creditos es " + cantidad_precio + "");
            Console.WriteLine("el valor final es " + operacion);
        }
        
    }
}
