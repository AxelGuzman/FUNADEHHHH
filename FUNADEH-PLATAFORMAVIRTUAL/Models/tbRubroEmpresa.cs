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
    
    public partial class tbRubroEmpresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbRubroEmpresa()
        {
            this.tbEmprendimiento = new HashSet<tbEmprendimiento>();
            this.tbEmpresa = new HashSet<tbEmpresa>();
        }
    
        public int rub_Id { get; set; }
        public string rub_Descripcion { get; set; }
        public int rub_UsuarioCrea { get; set; }
        public System.DateTime rub_FechaCrea { get; set; }
        public Nullable<int> rub_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> rub_FechaModifica { get; set; }
    
        public virtual tbUsuarios tbUsuarios { get; set; }
        public virtual tbUsuarios tbUsuarios1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmprendimiento> tbEmprendimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpresa> tbEmpresa { get; set; }
    }
}
