using System;
using System.Collections.Generic;
using CoreEscuela.Entidades; //se indica que utilice el codigo de CoreEscuela.Entidades donde creamos la clase escuela
using static System.Console;

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

            
            escuela.Cursos = new List<Curso>(){
                new Curso(){Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "301", Jornada = TiposJornada.Mañana},
            }; //asi se crea una lista

            var otraColeccion = new List<Curso>(){
                new Curso(){Nombre = "401", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "501", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "601", Jornada = TiposJornada.Mañana}
            };

            escuela.Cursos.Add( new Curso(){Nombre="102", Jornada = TiposJornada.Tarde});
            escuela.Cursos.Add( new Curso(){Nombre="202", Jornada = TiposJornada.Tarde});
            escuela.Cursos.Add( new Curso(){Nombre="302", Jornada = TiposJornada.Tarde});
            escuela.Cursos.AddRange(otraColeccion);


            Curso tmp = new Curso{Nombre = "101-Vacacional", Jornada = TiposJornada.Noche};
            escuela.Cursos.Add(tmp);
            ImprimirCursosEscuela(escuela);
            WriteLine("Curso.Hash" + tmp.GetHashCode());

            Predicate<Curso>miAlgoritmo = Predicado;

            escuela.Cursos.RemoveAll(miAlgoritmo);
            ImprimirCursosEscuela(escuela);
        }

        private static bool Predicado(Curso curobj)
        {
            return curobj.Nombre == "301";
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            separador();
            WriteLine("Cursos de la Escuela");
            separador();

            if (escuela?.Cursos == null)
                return;
            else
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.UniequeId}");
                }
            };

        }

        private static void separador()
        {
            WriteLine("===================================================");
        }
    }

}
