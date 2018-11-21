using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class ChamadoStatusRepositorio: RepositorioBase<ChamadoStatus>, IChamadoStatusRepositorio
    {
        public ChamadoStatusRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
