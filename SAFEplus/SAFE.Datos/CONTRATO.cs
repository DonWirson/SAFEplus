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
    
    public partial class CONTRATO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTRATO()
        {
            this.REGISTRO_PAGOS = new HashSet<REGISTRO_PAGOS>();
        }
    
        public long ID { get; set; }
        public System.DateTime FECHA_CONTRATACION { get; set; }
        public long RUT_CLIENTE_ID { get; set; }
        public long TIPO_CONTRATO_ID { get; set; }
    
        public virtual AUTH_USER AUTH_USER { get; set; }
        public virtual TIPO_CONTRATO TIPO_CONTRATO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTRO_PAGOS> REGISTRO_PAGOS { get; set; }
    }
}
