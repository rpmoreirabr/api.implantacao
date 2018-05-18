using System.Collections.Generic;

namespace Api.Implantacao.Data.Entidades.Simulacao
{
    public class ProdutoSimulado
    {
        public string Descricao { get; set; }
        public int? Id { get; set; }
        public bool? Obrigatorio { get; set; }
        public List<CoberturaSimulada> Coberturas { get; set; }
    }
}
