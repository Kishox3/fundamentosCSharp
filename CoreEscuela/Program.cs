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
            separador();
            ImprimirCursosWhile(arregloCursos);
            separador();
            ImprimirCursosDoWhile(arregloCursos);
            separador();
            ImprimirCursosFor(arregloCursos);
            separador();
            ImprimirCursosForEach(arregloCursos);
            separador();
        }

        private static void separador()
        {
            System.Console.WriteLine("===================================================");
        }

        //formas de recorrer el arreglo
        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniequeId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do //hara una vez la iteracion por lo menos
            {
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniequeId}");
                contador++;
            } while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int contador = 0; contador < arregloCursos.Length; contador++)
            {
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniequeId}");
            }
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos) //con foreach no se tiene que usar contador ni posicion en el arreglo
            {
                Console.WriteLine($"Nombre {curso.Nombre}, Id {curso.UniequeId}");
            }
        }
    }

}
