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
            
            var arregloCursos = new Curso[3];

            //curso 1
            arregloCursos[0] = new Curso()
                                {
                                    Nombre = "101"
                                };
            
            //curso 2
            var curso2 = new Curso()
            {
                Nombre = "201"
            };
            arregloCursos[1] = curso2;

            //curso 3
            arregloCursos[2] = new Curso
                                {
                                    Nombre = "301"
                                };

            Console.WriteLine(escuela);
            System.Console.WriteLine("====================");
            
        }
    }

}
