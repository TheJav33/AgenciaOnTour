//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CC
{
    using System;
    using System.Collections.Generic;
    
    public partial class SERVICIO
    {
        public SERVICIO()
        {
            this.DOCUMENTO = new HashSet<DOCUMENTO>();
            this.SERVICIO_PAQUETE = new HashSet<SERVICIO_PAQUETE>();
        }
    
        public decimal ID_SERVICIO { get; set; }
        public decimal ID_SERVICIO_WS { get; set; }
        public string ACTIVO { get; set; }
        public decimal ID_TIPO_SERVICIO { get; set; }
    
        public virtual ICollection<DOCUMENTO> DOCUMENTO { get; set; }
        public virtual ICollection<SERVICIO_PAQUETE> SERVICIO_PAQUETE { get; set; }
        public virtual TIPO_SERVICIO TIPO_SERVICIO { get; set; }
    }
}
