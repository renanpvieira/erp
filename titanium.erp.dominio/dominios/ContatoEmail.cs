namespace titanium.erp.dominio
{
    public class ContatoEmail
    {

        public int ContatoEmailId { get; set; }
        public string Nome { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        
        public virtual Parceiro Parceiro { get; set; }
    }
}
