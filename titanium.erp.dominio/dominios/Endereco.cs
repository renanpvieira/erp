namespace titanium.erp.dominio
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public virtual Parceiro Parceiro { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}