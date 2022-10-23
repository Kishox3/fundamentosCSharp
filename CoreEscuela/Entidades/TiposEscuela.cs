namespace CoreEscuela.Entidades //se usa el mismo namespace que escuela.cs
{
    public enum TiposEscuela // lista de opciones
    {
        Primaria,
        Secundaria,
        Preescolar

        /*
        Se puede tambien asigar:

        Primaria = 0, Secundaria = 1, Preescolar = 45;
        Esto indicara la posicion del enum, si no se coloca nada se pondra por defecto desde la posc 0
        */
    }
}