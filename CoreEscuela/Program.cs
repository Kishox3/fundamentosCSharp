using System;

namespace CoreEscuela
{

    class Escuela
    {
        public string nombre;
        public string direccion;
        public int fechaFundacion;

        public string ceo = "Freddy Vega";

        public void Timbrar()
        {
            Console.Beep(500, 3000);
        }
    }

    class Program //es una clase programa
    {
        static void Main(string[] args) //hay un metodo que se llama main
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Xino Academy";
            miEscuela.fechaFundacion = 2022;
            miEscuela.direccion = "Costa Rica";
            Console.WriteLine("Timbre!");
            miEscuela.Timbrar();
        }
    }
}
