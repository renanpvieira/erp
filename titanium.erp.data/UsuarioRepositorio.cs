using System.Data;
using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(IDbTransaction transaction)
            :base(transaction)
        {
            
        }

        public Usuario BuscarPorLogin(string login)
        {
            return null;

    //        Usuario usu = ctx.Usuarios.Where(u => u.Login == login).Include(e => e.Empresa)
    //            .Include(m => m.UsuarioMenuAdmin.Select(a => a.MenuAdmin)).FirstOrDefault();

    //        /* Se nao limpar da merda */
    //        if (usu != null && usu.UsuarioMenuAdmin != null)
    //        {
    //            foreach (var uma in usu.UsuarioMenuAdmin)
    //            {
    //                uma.Usuario = null;
    //                uma.MenuAdmin.UsuarioMenuAdmin = null;
    //            }
    //        }
    //        usu.Empresa.Usuarios = null;
    //        ctx.Dispose();
    //        return usu;

    //        /* NAO FUNCIONA NEM FUDENDO
    //return (from usuario in ctx.Usuarios
    //         join usuariomenuadmins in ctx.UsuarioMenuAdmins on usuario.UsuarioId equals usuariomenuadmins.Usuario.UsuarioId
    //         join menuadmin in ctx.MenuAdmins on usuariomenuadmins.MenuAdmin.MenuAdminId equals menuadmin.MenuAdminId
    //         where usuario.Login == login
    //         select usuario).FirstOrDefault();
    //         */

        }

        public int? AtualizaSenha(Usuario usuario)
        {
            return null;
            //try
            //{
            //    Salvar(usuario);
            //    return SalvarMudancas();

            //}
            //catch (DbEntityValidationException entex) { throw entex; }
            //catch (Exception ex) { throw ex; }
        }



    }
}
