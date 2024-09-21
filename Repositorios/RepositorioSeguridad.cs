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
            using (DbContext db = new DbContext())
            {
                return db.RollMenus
                    .Include(x => x.RolMenuOpciones)
                    .Where(x=>x.RolId == id)
                    .ToList();
            }
        }



    }
}
