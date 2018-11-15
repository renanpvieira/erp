namespace titanium.erp.dominio.interfaces.repositorios
{
    public interface IUsuarioRepositorio : IRepositorioBase<Usuario>
    {
        Usuario BuscarPorLogin(string login);
        
    }
}
