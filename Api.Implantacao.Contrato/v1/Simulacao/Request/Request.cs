using System.Collections.Generic;

namespace Api.Implantacao.Contrato.v1.Simulacao.Request
{


    public class Request
    {
        public Proponente Proponente { get; set; }
        public Conjuge Conjuge { get; set; }
        public Contratacao Contratacao { get; set; }
        public List<Observacao> Observacoes { get; set; }
    }
}
