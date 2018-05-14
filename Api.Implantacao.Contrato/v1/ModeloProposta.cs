using Api.Implantacao.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implantacao.Contrato.v1
{
    public class ModeloProposta : IEntidade<string>
    {
        public string Id { get; set; }
        public List<Produto> Produtos { get; set; }
        public PoliticaAceitacao PoliticaAceitacao { get; set; }
        public List<Questionario> Questionarios { get; set; }
    }
}
