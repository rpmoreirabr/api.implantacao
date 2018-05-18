using System.Collections.Generic;

namespace Api.Implantacao.Data.Entidades.Simulacao
{

    public class Produto {
    public int? Id { get; set; }

    public List<Cobertura> Coberturas { get; set; }
  }
}
