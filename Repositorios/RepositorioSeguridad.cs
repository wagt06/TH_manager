using MD.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Repositorios
{
    public class RepositorioSeguridad
    {

        public Usuario UsuarioById(int Id) {
            Usuario usuario;
            using (DbContext db = new DbContext()) {
               usuario = db.Usuarios
                    .Include(x=>x.Rol)
                    .Where(x => x.UsuarioId == Id).FirstOrDefault();
                if (usuario == null)
                    throw new Exception("No existe el Usuario");

                if (usuario.Rol == null)
                    throw new Exception("No Tiene Permisos configurados");

                List<RolMenu> menu = db.RollMenus
                    .Include(x=>x.RolMenuOpciones)
                    .Where(x => x.RolId == usuario.RolId).ToList();

                usuario.Rol.RolMenus = menu;
            }
            return usuario;
        }

        public List<Rol> Roles() {
            using (DbContext db = new DbContext()) {

                return db.Roll.ToList(); 
            }
        }

        public Rol Add(Rol rol)
        {
            using (DbContext db = new DbContext())
            {

                db.Roll.Add(rol);
                db.SaveChanges();
                return rol; 
            }
        }

        public Rol Update(Rol rol)
        {
            using (DbContext db = new DbContext())
            {

                db.Roll.Update(rol);
                db.SaveChanges();
                return rol;
            }
        }


        public List<Menu> Menus()
        {
            using (DbContext db = new DbContext())
            {
                return db.Menus
                    .Include(x=>x.Opciones)
                    .ToList();
            }
        }

        public RolMenu MenusAddOrUpdate(RolMenu rolMenu)
        {
            using (DbContext db = new DbContext())
            {
                RolMenu r = db.RollMenus
                    .Where(x=>x.MenuId == rolMenu.MenuId && x.RolId == rolMenu.RolId)
                    .FirstOrDefault();

                if (r == null)
                    db.RollMenus.Add(rolMenu);
                else {
                    r.IsActivo = rolMenu.IsActivo;
                    db.RollMenus.Update(r);
                }
                    
                db.SaveChanges();
                return rolMenu;
            }
        }

        public List<RolMenu> RollMenuByRolId(int id)
        {
            try
            {
                using (DbContext db = new DbContext())
                {
                    return db.RollMenus
                        .Include(x => x.RolMenuOpciones)
                        .Where(x => x.RolId == id)
                        .ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        internal void MenusOptionAddOrUpdate(RolMenuOpciones rm)
        {
            using (DbContext db = new DbContext())
            {

                MenusOpciones opcion = db.MenuOpciones.FirstOrDefault(x => x.MenuOpcionesId == rm.MenuOpcionesId);
                if (opcion == null)
                    throw new Exception("No existe esta Opcion de menu");

                /*Revisar si existe el menu en el roll*/
                RolMenu rolmenu = db.RollMenus.Where(x => x.MenuId == opcion.MenuId && x.RolId == rm.RolId).FirstOrDefault();


                if (rolmenu == null)
                    rolmenu =  MenusAddOrUpdate(new RolMenu { MenuId = opcion.MenuId,RolId = rm.RolId,IsActivo = false});


                RolMenuOpciones o = db.RollMenuOpciones.FirstOrDefault(x => x.MenuOpcionesId == rm.MenuOpcionesId && x.RolId == rm.RolId);

                if (o == null)
                {
                    rm.RolMenuId = rolmenu.RolMenuId;
                    db.RollMenuOpciones.Add(rm);
                }
                else
                {
                    o.IsActivo = rm.IsActivo;
                    db.RollMenuOpciones.Update(o);
                }
                   

                db.SaveChanges();
                    

            }
        }
    }
}
