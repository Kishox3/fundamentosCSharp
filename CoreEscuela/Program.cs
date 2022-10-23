using System;
using CoreEscuela.Entidades; //se indica que utilice el codigo de CoreEscuela.Entidades donde creamos la clase escuela

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            // aca vamos a utilizar la clase Escuela que acabamos de crear en entidades
            var escuela = new Escuela("Platzi Academy", 2012); //constructor para usar la clase
            // esto ya no se ocupa: 
            // escuela.Nombre = "Platzi Academy"; 
            // escuela.AñoDeCreacion = 2012;
            //debido a que se creo un contructor que requiere ambos parametros 
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";
            //de igual forma se le puede agregar
            escuela.TipoEscuela = TiposEscuela.Primaria; //solo deja escoger la lista de la numeracion

            Console.WriteLine(escuela); //idealmente si imprimos escuela deberia salir todo pero no es asi
        }
    }
    
}
