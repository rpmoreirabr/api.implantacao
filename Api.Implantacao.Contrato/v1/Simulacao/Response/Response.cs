using System;
using System.Collections.Generic;

namespace Api.Implantacao.Contrato.v1.Simulacao.Response
{

    public class Response
    {
        public Response ()
        {
            id = Guid.NewGuid().ToString();
        }
        public string id { get; set; }
        public Api.Implantacao.Contrato.v1.Simulacao.Request.Request Request { get; set; }
        public List<Produto> Produtos { get; set; }
        public decimal TicketMinimo { get; set; }
    }
}
