using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoresAPI.Core.Business.Models
{
    public class Editorial
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Sede { get; set; }

        public IEnumerable<Libro> Libros { get; set; }
    }
}
