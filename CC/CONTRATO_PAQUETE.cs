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
    
    public partial class CONTRATO_PAQUETE
    {
        public CONTRATO_PAQUETE()
        {
            this.DOCUMENTO = new HashSet<DOCUMENTO>();
        }
    
        public decimal ID_CONTRATO { get; set; }
        public decimal ID_PAQUETEVIAJE { get; set; }
        public string ACTIVO { get; set; }
    
        public virtual CONTRATO CONTRATO { get; set; }
        public virtual PAQUETEVIAJE PAQUETEVIAJE { get; set; }
        public virtual ICollection<DOCUMENTO> DOCUMENTO { get; set; }
    }
}