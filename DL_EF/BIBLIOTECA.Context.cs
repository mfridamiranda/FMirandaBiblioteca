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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BIBLIOTECAEntities : DbContext
    {
        public BIBLIOTECAEntities()
            : base("name=BIBLIOTECAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Autor> Autors { get; set; }
        public virtual DbSet<Editorial> Editorials { get; set; }
        public virtual DbSet<Genero> Generoes { get; set; }
        public virtual DbSet<Libro> Libroes { get; set; }
    
        public virtual int LibroAdd(string nombreLibro, Nullable<int> idAutor, Nullable<int> numeroPaginas, string fechaPublicacion, Nullable<int> idEditorial, string edicion, Nullable<int> idGenero)
        {
            var nombreLibroParameter = nombreLibro != null ?
                new ObjectParameter("NombreLibro", nombreLibro) :
                new ObjectParameter("NombreLibro", typeof(string));
    
            var idAutorParameter = idAutor.HasValue ?
                new ObjectParameter("IdAutor", idAutor) :
                new ObjectParameter("IdAutor", typeof(int));
    
            var numeroPaginasParameter = numeroPaginas.HasValue ?
                new ObjectParameter("NumeroPaginas", numeroPaginas) :
                new ObjectParameter("NumeroPaginas", typeof(int));
    
            var fechaPublicacionParameter = fechaPublicacion != null ?
                new ObjectParameter("FechaPublicacion", fechaPublicacion) :
                new ObjectParameter("FechaPublicacion", typeof(string));
    
            var idEditorialParameter = idEditorial.HasValue ?
                new ObjectParameter("IdEditorial", idEditorial) :
                new ObjectParameter("IdEditorial", typeof(int));
    
            var edicionParameter = edicion != null ?
                new ObjectParameter("Edicion", edicion) :
                new ObjectParameter("Edicion", typeof(string));
    
            var idGeneroParameter = idGenero.HasValue ?
                new ObjectParameter("IdGenero", idGenero) :
                new ObjectParameter("IdGenero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LibroAdd", nombreLibroParameter, idAutorParameter, numeroPaginasParameter, fechaPublicacionParameter, idEditorialParameter, edicionParameter, idGeneroParameter);
        }
    
        public virtual int LibroDelete(Nullable<int> idLibro)
        {
            var idLibroParameter = idLibro.HasValue ?
                new ObjectParameter("IdLibro", idLibro) :
                new ObjectParameter("IdLibro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LibroDelete", idLibroParameter);
        }
    
        public virtual ObjectResult<LibroGetAll_Result> LibroGetAll(string nombreLibro, Nullable<int> idAutor, Nullable<int> numeroPaginas, string fechaPublicacion, Nullable<int> idEditorial, string edicion, Nullable<int> idGenero)
        {
            var nombreLibroParameter = nombreLibro != null ?
                new ObjectParameter("NombreLibro", nombreLibro) :
                new ObjectParameter("NombreLibro", typeof(string));
    
            var idAutorParameter = idAutor.HasValue ?
                new ObjectParameter("IdAutor", idAutor) :
                new ObjectParameter("IdAutor", typeof(int));
    
            var numeroPaginasParameter = numeroPaginas.HasValue ?
                new ObjectParameter("NumeroPaginas", numeroPaginas) :
                new ObjectParameter("NumeroPaginas", typeof(int));
    
            var fechaPublicacionParameter = fechaPublicacion != null ?
                new ObjectParameter("FechaPublicacion", fechaPublicacion) :
                new ObjectParameter("FechaPublicacion", typeof(string));
    
            var idEditorialParameter = idEditorial.HasValue ?
                new ObjectParameter("IdEditorial", idEditorial) :
                new ObjectParameter("IdEditorial", typeof(int));
    
            var edicionParameter = edicion != null ?
                new ObjectParameter("Edicion", edicion) :
                new ObjectParameter("Edicion", typeof(string));
    
            var idGeneroParameter = idGenero.HasValue ?
                new ObjectParameter("IdGenero", idGenero) :
                new ObjectParameter("IdGenero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LibroGetAll_Result>("LibroGetAll", nombreLibroParameter, idAutorParameter, numeroPaginasParameter, fechaPublicacionParameter, idEditorialParameter, edicionParameter, idGeneroParameter);
        }
    
        public virtual ObjectResult<LibroGetById_Result> LibroGetById(Nullable<int> idLibro)
        {
            var idLibroParameter = idLibro.HasValue ?
                new ObjectParameter("IdLibro", idLibro) :
                new ObjectParameter("IdLibro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LibroGetById_Result>("LibroGetById", idLibroParameter);
        }
    
        public virtual int LibroUpdate(Nullable<int> idLibro, string nombreLibro, Nullable<int> idAutor, Nullable<int> numeroPaginas, string fechaPublicacion, Nullable<int> idEditorial, string edicion, Nullable<int> idGenero)
        {
            var idLibroParameter = idLibro.HasValue ?
                new ObjectParameter("IdLibro", idLibro) :
                new ObjectParameter("IdLibro", typeof(int));
    
            var nombreLibroParameter = nombreLibro != null ?
                new ObjectParameter("NombreLibro", nombreLibro) :
                new ObjectParameter("NombreLibro", typeof(string));
    
            var idAutorParameter = idAutor.HasValue ?
                new ObjectParameter("IdAutor", idAutor) :
                new ObjectParameter("IdAutor", typeof(int));
    
            var numeroPaginasParameter = numeroPaginas.HasValue ?
                new ObjectParameter("NumeroPaginas", numeroPaginas) :
                new ObjectParameter("NumeroPaginas", typeof(int));
    
            var fechaPublicacionParameter = fechaPublicacion != null ?
                new ObjectParameter("FechaPublicacion", fechaPublicacion) :
                new ObjectParameter("FechaPublicacion", typeof(string));
    
            var idEditorialParameter = idEditorial.HasValue ?
                new ObjectParameter("IdEditorial", idEditorial) :
                new ObjectParameter("IdEditorial", typeof(int));
    
            var edicionParameter = edicion != null ?
                new ObjectParameter("Edicion", edicion) :
                new ObjectParameter("Edicion", typeof(string));
    
            var idGeneroParameter = idGenero.HasValue ?
                new ObjectParameter("IdGenero", idGenero) :
                new ObjectParameter("IdGenero", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LibroUpdate", idLibroParameter, nombreLibroParameter, idAutorParameter, numeroPaginasParameter, fechaPublicacionParameter, idEditorialParameter, edicionParameter, idGeneroParameter);
        }
    }
}
