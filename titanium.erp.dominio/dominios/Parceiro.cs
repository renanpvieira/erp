using System.Collections.Generic;

namespace titanium.erp.dominio
{
    public class Parceiro
    {
        public int ParceiroId { get; set; }
        public string Nome { get; set; }
        public string CGC { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual ICollection<ContatoTelefone> ContatoTelefones { get; set; }
        public virtual ICollection<ContatoEmail> ContatoEmails { get; set; }
    }
}
