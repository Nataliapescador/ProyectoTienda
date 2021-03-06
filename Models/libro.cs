//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTienda.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class libro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public libro()
        {
            this.ejemplar_libro = new HashSet<ejemplar_libro>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int paginas { get; set; }
        public decimal precio_sugerido { get; set; }
        public int autor_id { get; set; }
        public int genero_id { get; set; }
        public System.DateTime fecha_creacion { get; set; }
    
        public virtual autor autor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ejemplar_libro> ejemplar_libro { get; set; }
        public virtual genero genero { get; set; }
    }
}
