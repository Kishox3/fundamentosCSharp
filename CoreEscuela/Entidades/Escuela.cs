namespace CoreEscuela.Entidades
{
    class Escuela
    {
        //Propiedades
        public string Nombre { get; set; }

        public int AñoDeCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        //constructor 1
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año); //se procede a utilziar una igualacion por tuplas para simplificar el constructor

        //constructor 2
        public Escuela(
            string nombre,
            int año,
            TiposEscuela tipo,
            string pais = "",
            string ciudad = "")
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }


        //Override para imprimir toda la info cuando se llame el obj escuela
        public override string ToString()
        {
            return $"Nombre: {Nombre} \nTipo: {TipoEscuela} \nPais: {Pais} \nCiudad: {Ciudad}"; //signo dolar me permite usar variable dentro de llaves
        }

    }
}