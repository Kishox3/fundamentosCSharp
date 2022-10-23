using System;
using CoreEscuela.Entidades; //se indica que utilice el codigo de CoreEscuela.Entidades donde creamos la clase escuela

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            // aca vamos a utilizar la clase Escuela que acabamos de crear en entidades
            var escuela = new Escuela(); //constructor para usar la clase
            escuela.Nombre = "Platzi Academy"; 

            Console.WriteLine(escuela.Nombre); //esto imprimira el nombre que asignamos usando la clase escuela
        }
    }
    
}
