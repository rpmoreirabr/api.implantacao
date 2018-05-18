using System.Collections.Generic;

namespace Api.Implantacao.Data.Entidades.Simulacao
{


    public class Contratacao {
    
    public string ModeloProposta { get; set; }
    public List<Produto> Produtos { get; set; }
    public List<Parametro> Parametros { get; set; }
  }
}
