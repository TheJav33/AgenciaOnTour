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
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.CLIENTE = new HashSet<CLIENTE>();
            this.EMPLEADO = new HashSet<EMPLEADO>();
        }
    
        public decimal ID_USR { get; set; }
        public string LOGIN_USR { get; set; }
        public string PASS_USR { get; set; }
        public decimal ID_TIPO_USUARIO { get; set; }
        public string ACTIVO { get; set; }
    
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }
        public virtual ICollection<EMPLEADO> EMPLEADO { get; set; }
        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
    }
}
