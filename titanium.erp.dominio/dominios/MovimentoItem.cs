namespace titanium.erp.dominio
{
    public class MovimentoItem
    {
        public int MovimentoItemId { get; set; }
        public int Quantidade { get; set; }
        public int ValorVendido { get; set; } /* CENTAVOS */
        public int Desconto { get; set; } /* CENTAVOS */

        public virtual Operacao Operacao { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Movimento Movimento { get; set; }
        public virtual Estoque Estoque { get; set; }


    }
}