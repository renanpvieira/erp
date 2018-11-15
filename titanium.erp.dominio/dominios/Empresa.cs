using System.Collections.Generic;

namespace titanium.erp.dominio
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }

        public virtual Endereco EnderecoNFiscal { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual ICollection<Estoque> Estoques { get; set; }
        public virtual ICollection<Parceiro> Parceiros { get; set; }
        public virtual ICollection<Movimento> Movimentos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }

    }
}
