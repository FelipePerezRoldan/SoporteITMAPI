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
    
    public partial class SolicitudesSoporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SolicitudesSoporte()
        {
            this.HistorialSolicitudes = new HashSet<HistorialSolicitude>();
        }
    
        public int idSolicitud { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public Nullable<int> idTecnicoAsignado { get; set; }
        public Nullable<int> idEquipoAfectado { get; set; }
        public System.DateTime FechaSolicitud { get; set; }
        public string DescripcionProblema { get; set; }
        public Nullable<int> EstadoSolicitud { get; set; }
        public string Prioridad { get; set; }
        public Nullable<System.DateTime> FechaResolucion { get; set; }
    
        public virtual Equipos Equipos { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialSolicitude> HistorialSolicitudes { get; set; }
        public virtual Tecnico Tecnico { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
