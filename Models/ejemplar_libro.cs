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
    
    public partial class ejemplar_libro
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public int libro_id { get; set; }
        public Nullable<int> cliente_id { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual libro libro { get; set; }
    }
}
