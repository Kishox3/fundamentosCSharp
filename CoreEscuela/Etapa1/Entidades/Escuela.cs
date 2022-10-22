namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { { nombre = value.ToUpper(); } } //vamos a llenar la variable strin nombre con Public String Nombre el cual tiene una logica de convertilo a MAYUS antes de ingresarlo
        }

        public int AñoDeCreacion { get; set; } //esto hace lo mismo que lo anterior pero de forma interna (crea otra variable y asigna un get y un set)

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        private int myVar;

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
    }
}