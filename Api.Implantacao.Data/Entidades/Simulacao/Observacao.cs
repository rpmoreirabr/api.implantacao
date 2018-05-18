using System.Collections.Generic;

namespace Api.Implantacao.Data.Entidades.Simulacao
{
    public class Observacao
    {
        public int? Id { get; set; }
        public string Descricao { get; set; }
        public string Origem { get; set; }
        public List<string> Itens { get; set; }
    }
}
