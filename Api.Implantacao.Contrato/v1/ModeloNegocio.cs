using Api.Implantacao.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implantacao.Contrato.v1
{
    public class ModeloNegocio : IEntidade<string>
    {
        public string Id { get; set; }
        public long Cnpj { get; set; }
        public int IdCanalVenda { get; set; }
        public List<ModeloProposta> ModelosProposta { get; set; }
    }
}
