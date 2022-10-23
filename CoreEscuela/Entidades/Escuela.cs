namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;

        public string Nombre //este "Nombre" es diferente a "nombre" se encargar de registrar los datos y convertirlos en MAYUS
        {
            get {return nombre;}
            set { nombre = value.ToUpper();}
        }

        //uso de propiedades
        //es lo mismo que lo anterior pero de forma mas simple ya que tiene variables internas ocultas
        public int AñoDeCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; } //vamos a usar enumeraciones para evitar TYPOS 
        // en lugar de string el tipo de datos sera con el nombre del enum que se creo

        /*
        public Escuela(string nombre, int año) //constructor de escuelas
        {
            this.nombre = nombre; //se utiliza this para poder usar la palabra nombre dos veces
            // clase       entrada
            
            se puede hacer asi sin this:
            public Escuela(string nombre de Entrada)
            {
                nombre = nombreEntrada; /
            }
            

            AñoDeCreacion = año;
            // clase        entrada
        }
        */
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año); //se procede a utilziar una igulacion por tuplas para simplificar el constructor
                        //parametros                //entrada                   //salida

        public override string ToString()
        {
            return $"Nombre: {Nombre} \nTipo: {TipoEscuela} \nPais: {Pais} \nCiudad: {Ciudad}"; //signo dolar me permite usar variable dentro de llaves
        }
        
    }
}