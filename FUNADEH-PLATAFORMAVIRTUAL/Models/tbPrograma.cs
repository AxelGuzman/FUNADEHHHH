//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FUNADEH_PLATAFORMAVIRTUAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbPrograma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbPrograma()
        {
            this.tbTipoTaller = new HashSet<tbTipoTaller>();
            this.tbBeneficiarios = new HashSet<tbBeneficiarios>();
        }
    
        public int prog_Id { get; set; }
        public string prog_Descripcion { get; set; }
        public int prog_UsuarioCrea { get; set; }
        public System.DateTime prog_FechaCrea { get; set; }
        public Nullable<int> prog_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> prog_FechaModifica { get; set; }
    
        public virtual tbUsuarios tbUsuarios { get; set; }
        public virtual tbUsuarios tbUsuarios1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoTaller> tbTipoTaller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBeneficiarios> tbBeneficiarios { get; set; }
    }
}