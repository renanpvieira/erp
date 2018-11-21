using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class ChamadoRepositorio: RepositorioBase<Chamado>, IChamadoRepositorio
    {
        public ChamadoRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
