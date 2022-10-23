using System;
using CoreEscuela.Entidades; //se indica que utilice el codigo de CoreEscuela.Entidades donde creamos la clase escuela

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor 2
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
            pais: "Colombia", ciudad: "Bogota" //parametros opcionales
            );
            
            var curso1 = new Curso() {
                Nombre = "101"
            };

            var curso2 = new Curso() {
                Nombre = "201"
            };

            var curso3 = new Curso() {
                Nombre = "301"
            };

            Console.WriteLine(escuela);
            System.Console.WriteLine("====================");
            System.Console.WriteLine(curso1.Nombre + " , " + curso1.UniequeId);
            System.Console.WriteLine($"{curso2.Nombre} , {curso2.UniequeId}");
            System.Console.WriteLine(curso3);
        }
    }

}
