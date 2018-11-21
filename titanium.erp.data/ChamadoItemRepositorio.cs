using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class ChamadoItemRepositorio: RepositorioBase<ChamadoItem>, IChamadoItemRepositorio
    {
        public ChamadoItemRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
        
    }
}
