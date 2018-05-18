using System.Collections.Generic;

namespace Api.Implantacao.Contrato.v1.Simulacao.Request
{
    public class Observacao
    {
        public int? Id { get; set; }
        public string Descricao { get; set; }
        public string Origem { get; set; }
        public List<string> Itens { get; set; }
    }
}
