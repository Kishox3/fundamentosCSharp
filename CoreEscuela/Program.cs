using System;
using CoreEscuela.Entidades; //se indica que utilice el codigo de CoreEscuela.Entidades donde creamos la clase escuela

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            // aca vamos a utilizar la clase Escuela que acabamos de crear en entidades
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
            pais:"Colombia", ciudad: "Bogota" //los parametros opcionales permiten omitir el orden
            ); //constructor para usar la clase

            escuela.TipoEscuela = TiposEscuela.Primaria; //solo deja escoger la lista de la numeracion

            Console.WriteLine(escuela); //si se imprime el objeto se impre el nombre completo del objeto, no su informacion
            //por lo tanto en escuela.cs se hizo un override para imprimir todo poniendo escuela [se profundizara mas]


        }
    }
    
}
