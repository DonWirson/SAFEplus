//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAFE.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class MULTA
    {
        public long ID { get; set; }
        public long MONTO_MULTA { get; set; }
        public string DESCRIPCION { get; set; }
        public System.DateTime FECHA_MULTA { get; set; }
        public long MULTA_CLIENTE_ID { get; set; }
    
        public virtual AUTH_USER AUTH_USER { get; set; }
    }
}