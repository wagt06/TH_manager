using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.Entidades;

namespace MD.Entidades
{
    public class Usuario:Entidades.BaseEntidad
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasena { get; set; }
        public int RollId { get; set; }
        public virtual Rol Roll { get; set; }
    }

    public class Menu {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MenuId { get; set; }
        public string Modulo  { get; set; }
        public string NombreMenu { get; set; }
        public virtual List<MenusOpciones> Opciones { get; set; }
    }

    public class MenusOpciones
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MenuOpcionesId { get; set; }
        public int MenuId { get; set; }
        public virtual Menu Menu { get; set; }
        public string NombreOpcion { get; set; }
    }

    public class Rol
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RolId { get; set; }
        public string NombreRol { get; set; }
        public bool IsActivo { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<RolMenu> RolMenus { get; set; }
    }

    public class RolMenu
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RolMenuId { get; set; }
        public int RolId { get; set; }
        public Rol Rol  { get; set; }
        public int MenuId { get; set; }
        public bool IsActivo { get; set; }
        public List<RolMenuOpciones> RolMenuOpciones { get; set; } 
    }


    public class RolMenuOpciones
    {
        
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RolMenuOpcionesid { get; set; }
        public int  RolMenuId { get; set; }
        public RolMenu RolMenu { get; set; }
        public bool IsActivo { get; set; }
        
    }



}
