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
    
    public partial class MATERIAL_SOLICITADO
    {
        public long ID { get; set; }
        public long CANTIDAD { get; set; }
        public long ID_MATERIAL_ID { get; set; }
        public long MATERIAL_CAPACITACION_ID { get; set; }
    
        public virtual CAPACITACION CAPACITACION { get; set; }
        public virtual MATERIAL_CAPACITACIONES MATERIAL_CAPACITACIONES { get; set; }
    }
}