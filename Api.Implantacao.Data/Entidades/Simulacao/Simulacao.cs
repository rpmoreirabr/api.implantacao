using Api.Implantacao.Contrato;
using System;
using System.Collections.Generic;

namespace Api.Implantacao.Data.Entidades.Simulacao
{ 
    public class Simulacao : IEntidade<string>
    {
        public string Id { get; set; }
        public Request Request { get; set; }
        public List<ProdutoSimulado> Produtos { get; set; }
        public decimal TicketMinimo { get; set; }
    }
}
