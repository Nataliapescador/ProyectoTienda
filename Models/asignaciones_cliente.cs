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
    
    public partial class asignaciones_cliente
    {
        public int id { get; set; }
        public int cliente_id { get; set; }
        public decimal monto { get; set; }
        public System.DateTime fecha_asignacion { get; set; }
    
        public virtual cliente cliente { get; set; }
    }
}
