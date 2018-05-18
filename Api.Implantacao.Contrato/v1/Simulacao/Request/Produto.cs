using System.Collections.Generic;

namespace Api.Implantacao.Contrato.v1.Simulacao.Request
{

    public class Produto {
    public int? Id { get; set; }

    public List<Cobertura> Coberturas { get; set; }
  }
}
