/* Classe relacional com enum */

using System;

namespace titanium.erp.dominio
{
    public enum StatusChamado
    {
        Novo,
        AprovacaoOrcamento,
        Desenvolvimento,
        Testando,
        AguardandoCliente,
        ParadoCliente,
        Parado,
        AguardandoPagamento,
        Pago,
        Finalizado
    }

    public class ChamadoStatus
    {
        public int ChamadoStatusId { get; set; }
        public DateTime Data { get; set; }

        public virtual StatusChamado StatusChamado { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Chamado Chamado { get; set; }

    }
}