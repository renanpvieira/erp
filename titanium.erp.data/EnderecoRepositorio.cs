using titanium.erp.dominio;
using titanium.erp.dominio.interfaces.repositorios;

namespace titanium.erp.data
{
    public class EnderecoRepositorio : RepositorioBase<Endereco>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(System.Data.IDbTransaction transaction)
            : base(transaction)
        {

        }
    }
}
