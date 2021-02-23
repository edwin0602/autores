using System;
using System.Collections.Generic;
using System.Text;

namespace AutoresAPI.Core.Business.Models
{
    public class Libro
    {
        public int ISBN { get; set; }

        public string Titulo { get; set; }

        public string Sinopsis { get; set; }

        public string NPaginas { get; set; }

        public int EditorialID { get; set; }

        public Editorial Editorial { get; set; }

        public IEnumerable<LibroYAutor> Autores { get; set; }
    }
}
