using System.Collections.Generic;

namespace Api.Implantacao.Data.Entidades.Simulacao
{ 
    public class Request
    {
        public Proponente Proponente { get; set; }
        public Conjuge Conjuge { get; set; }
        public Contratacao Contratacao { get; set; }
        public List<Observacao> Observacoes { get; set; }
    }
}
