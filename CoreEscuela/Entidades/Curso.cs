using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string Nombre { get; set; }
        public string UniequeId { get; private set; } //se pone privado para evitar setear un valor [encapsulamiento]
        public TiposJornada Jornada { get; set; }

        public Curso() => UniequeId = Guid.NewGuid().ToString();
    }
}