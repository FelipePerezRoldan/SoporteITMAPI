//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoporteITMAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistorialSolicitude
    {
        public int idHistorial { get; set; }
        public Nullable<int> idSolicitud { get; set; }
        public System.DateTime FechaCambio { get; set; }
        public Nullable<int> idEstadoAnterior { get; set; }
        public Nullable<int> idEstadoNuevo { get; set; }
        public string Observaciones { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Estado Estado1 { get; set; }
        public virtual SolicitudesSoporte SolicitudesSoporte { get; set; }
    }
}
