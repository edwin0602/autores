using System;
using System.Collections.Generic;
using System.Text;

namespace AutoresAPI.Core.Business.Models
{
    public class Autor
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public IEnumerable<LibroYAutor> Libros { get; set; }
    }
}
