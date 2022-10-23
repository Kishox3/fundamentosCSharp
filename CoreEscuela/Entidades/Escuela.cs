namespace CoreEscuela.Entidades
{
    class CoreEscuela
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

        public string Tipo { get; set; }  //esto lo editaremos mas tarde con otra entindad [enumeraciones]
    }
}