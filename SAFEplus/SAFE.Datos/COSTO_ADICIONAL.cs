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
    
    public partial class COSTO_ADICIONAL
    {
        public long ID { get; set; }
        public long MONTO_ADICIONAL { get; set; }
        public System.DateTime FECHA_COSTOADICIONAL { get; set; }
        public long ID_CONTRATO_ID { get; set; }
    
        public virtual CONTRATO CONTRATO { get; set; }
    }
}
