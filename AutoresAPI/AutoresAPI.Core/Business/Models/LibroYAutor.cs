namespace AutoresAPI.Core.Business.Models
{
    public class LibroYAutor
    {
        public int AutorId { get; set; }

        public int LibroId { get; set; }

        public Autor Autor { get; set; }

        public Libro Libro { get; set; }
    }
}
