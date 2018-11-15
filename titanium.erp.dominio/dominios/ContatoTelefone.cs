namespace titanium.erp.dominio
{
    public class ContatoTelefone
    {
        public int ContatoTelefoneId { get; set; }
        public string Nome { get; set; }
        public string DDD1 { get; set; }
        public string Telefone1 { get; set; }
        public string DDD2 { get; set; }
        public string Telefone2 { get; set; }
        public virtual Parceiro Parceiro { get; set; }

    }
}
