//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FUNADEH_PLATAFORMAVIRTUAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbUsuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbUsuarios()
        {
            this.tbAccesoRol = new HashSet<tbAccesoRol>();
            this.tbAccesoRol1 = new HashSet<tbAccesoRol>();
            this.tbPermisos = new HashSet<tbPermisos>();
            this.tbPermisos1 = new HashSet<tbPermisos>();
            this.tbRoles = new HashSet<tbRoles>();
            this.tbRoles1 = new HashSet<tbRoles>();
            this.tbRolesUsuario = new HashSet<tbRolesUsuario>();
            this.tbRolesUsuario1 = new HashSet<tbRolesUsuario>();
            this.tbDepartamentos = new HashSet<tbDepartamentos>();
            this.tbDepartamentos1 = new HashSet<tbDepartamentos>();
            this.tbMunicipios = new HashSet<tbMunicipios>();
            this.tbMunicipios1 = new HashSet<tbMunicipios>();
            this.tbPrograma = new HashSet<tbPrograma>();
            this.tbPrograma1 = new HashSet<tbPrograma>();
            this.tbRubroEmpresa = new HashSet<tbRubroEmpresa>();
            this.tbRubroEmpresa1 = new HashSet<tbRubroEmpresa>();
            this.tbTipoSeguimiento = new HashSet<tbTipoSeguimiento>();
            this.tbTipoSeguimiento1 = new HashSet<tbTipoSeguimiento>();
            this.tbTipoTaller = new HashSet<tbTipoTaller>();
            this.tbTipoTaller1 = new HashSet<tbTipoTaller>();
            this.tbBeneficiarios = new HashSet<tbBeneficiarios>();
            this.tbBeneficiarios1 = new HashSet<tbBeneficiarios>();
            this.tbCapacitacion = new HashSet<tbCapacitacion>();
            this.tbCapacitacion1 = new HashSet<tbCapacitacion>();
            this.tbCapacitador = new HashSet<tbCapacitador>();
            this.tbCapacitador1 = new HashSet<tbCapacitador>();
            this.tbCentroAlcance = new HashSet<tbCentroAlcance>();
            this.tbCentroAlcance1 = new HashSet<tbCentroAlcance>();
            this.tbEmpleabilidad = new HashSet<tbEmpleabilidad>();
            this.tbEmpleabilidad1 = new HashSet<tbEmpleabilidad>();
            this.tbEmprendimiento = new HashSet<tbEmprendimiento>();
            this.tbEmprendimiento1 = new HashSet<tbEmprendimiento>();
            this.tbEmpresa = new HashSet<tbEmpresa>();
            this.tbEmpresa1 = new HashSet<tbEmpresa>();
            this.tbSeguimiento = new HashSet<tbSeguimiento>();
            this.tbSeguimiento1 = new HashSet<tbSeguimiento>();
            this.tbEventos = new HashSet<tbEventos>();
            this.tbEventos1 = new HashSet<tbEventos>();
            this.tbPreguntas = new HashSet<tbPreguntas>();
            this.tbPreguntas1 = new HashSet<tbPreguntas>();
            this.tbRespuestas = new HashSet<tbRespuestas>();
            this.tbRespuestas1 = new HashSet<tbRespuestas>();
            this.tbUsuariosLinea = new HashSet<tbUsuariosLinea>();
            this.tbUsuariosLinea1 = new HashSet<tbUsuariosLinea>();
        }
    
        public int usu_Id { get; set; }
        public string usu_NombreUsuario { get; set; }
        public byte[] usu_Password { get; set; }
        public string usu_FotoPerfil { get; set; }
        public string usu_Nombres { get; set; }
        public string usu_Apellidos { get; set; }
        public string usu_Direccion { get; set; }
        public string usu_Telefono { get; set; }
        public string usu_Sexo { get; set; }
        public string usu_CorreoElectronico { get; set; }
        public bool usu_EsActivo { get; set; }
        public string usu_RazonInactivo { get; set; }
        public bool usu_EsAdministrador { get; set; }
        public byte usu_SesionesValidas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAccesoRol> tbAccesoRol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAccesoRol> tbAccesoRol1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPermisos> tbPermisos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPermisos> tbPermisos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRoles> tbRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRoles> tbRoles1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRolesUsuario> tbRolesUsuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRolesUsuario> tbRolesUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDepartamentos> tbDepartamentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDepartamentos> tbDepartamentos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMunicipios> tbMunicipios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMunicipios> tbMunicipios1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPrograma> tbPrograma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPrograma> tbPrograma1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRubroEmpresa> tbRubroEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRubroEmpresa> tbRubroEmpresa1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoSeguimiento> tbTipoSeguimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoSeguimiento> tbTipoSeguimiento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoTaller> tbTipoTaller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTipoTaller> tbTipoTaller1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBeneficiarios> tbBeneficiarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBeneficiarios> tbBeneficiarios1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCapacitacion> tbCapacitacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCapacitacion> tbCapacitacion1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCapacitador> tbCapacitador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCapacitador> tbCapacitador1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCentroAlcance> tbCentroAlcance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCentroAlcance> tbCentroAlcance1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleabilidad> tbEmpleabilidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleabilidad> tbEmpleabilidad1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmprendimiento> tbEmprendimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmprendimiento> tbEmprendimiento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpresa> tbEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpresa> tbEmpresa1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSeguimiento> tbSeguimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSeguimiento> tbSeguimiento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEventos> tbEventos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEventos> tbEventos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPreguntas> tbPreguntas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPreguntas> tbPreguntas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRespuestas> tbRespuestas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRespuestas> tbRespuestas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbUsuariosLinea> tbUsuariosLinea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbUsuariosLinea> tbUsuariosLinea1 { get; set; }
    }
}
