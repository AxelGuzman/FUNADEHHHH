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
    
    public partial class tbEmprendimiento
    {
        public int empr_Id { get; set; }
        public int ben_Id { get; set; }
        public int rub_Id { get; set; }
        public string empr_NombreEmprendimiento { get; set; }
        public Nullable<System.DateTime> empr_FechaInauguracion { get; set; }
        public Nullable<decimal> empr_ValorKit { get; set; }
        public string empr_DireccionNegocio { get; set; }
        public int empr_UsuarioCrea { get; set; }
        public System.DateTime empr_FechaCrea { get; set; }
        public Nullable<int> empr_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> empr_FechaModifica { get; set; }
    
        public virtual tbUsuarios tbUsuarios { get; set; }
        public virtual tbUsuarios tbUsuarios1 { get; set; }
        public virtual tbRubroEmpresa tbRubroEmpresa { get; set; }
        public virtual tbBeneficiarios tbBeneficiarios { get; set; }
    }
}
