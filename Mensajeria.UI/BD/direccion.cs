//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mensajeria.UI.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class direccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public direccion()
        {
            this.envio = new HashSet<envio>();
        }
    
        public long id { get; set; }
        public string tipoCalle { get; set; }
        public string numero { get; set; }
        public string tipoInmueble { get; set; }
        public string barrio { get; set; }
        public string observaciones { get; set; }
        public bool actual { get; set; }
        public long idMunicipio { get; set; }
        public long idPersona { get; set; }
    
        public virtual municipio municipio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<envio> envio { get; set; }
        public virtual persona persona { get; set; }
    }
}
