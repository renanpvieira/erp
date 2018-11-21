using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class ContatoTelefoneRepositorio : RepositorioBase<ContatoTelefone>, IContatoTelefoneRepositorio
    {
        public ContatoTelefoneRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
