namespace titanium.erp.dominio
{
    public class UsuarioMenuAdmin
    {
        public int UsuarioMenuAdminId { get; set; }
        public bool ReadOnly { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual MenuAdmin MenuAdmin { get; set; }

    }
}
