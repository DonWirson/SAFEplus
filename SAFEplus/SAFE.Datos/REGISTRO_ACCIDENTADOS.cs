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
    
    public partial class REGISTRO_ACCIDENTADOS
    {
        public long ID { get; set; }
        public long ID_ACCIDENTE_ID { get; set; }
        public long RUT_TRABAJADOR_ID { get; set; }
    
        public virtual ACCIDENTE ACCIDENTE { get; set; }
        public virtual ACCOUNT_USERPROFILE ACCOUNT_USERPROFILE { get; set; }
    }
}
