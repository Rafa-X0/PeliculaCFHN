namespace PeliculasCFHN.ClienteBlazor.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public int IdGenero { get; set; }
        public int IdDirector { get; set; }
        public string Titulo { get; set; }
        public string FechaEstreno { get; set; }
        public string Actores { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

    }
}
