//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Libro
    {
        public int IdLibro { get; set; }
        public string NombreLibro { get; set; }
        public Nullable<int> IdAutor { get; set; }
        public Nullable<int> NumeroPaginas { get; set; }
        public string FechaPublicacion { get; set; }
        public Nullable<int> IdEditorial { get; set; }
        public string Edicion { get; set; }
        public Nullable<int> IdGenero { get; set; }
    
        public virtual Autor Autor { get; set; }
        public virtual Editorial Editorial { get; set; }
        public virtual Genero Genero { get; set; }
    }
}
