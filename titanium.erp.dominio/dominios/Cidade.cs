using System.Collections.Generic;

namespace titanium.erp.dominio
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string Nome { get; set; }
        public string CodigoIBGE { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual UF UF { get; set; }
    }
}
