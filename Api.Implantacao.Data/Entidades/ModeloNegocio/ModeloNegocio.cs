using Api.Implantacao.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implantacao.Data.Entidades.ModeloNegocio
{
    public class ModeloNegocio : IEntidade<string>
    {
        public string Id { get; set; }
        public string Cnpj { get; set; }
        public string CanalVenda { get; set; }
        public List<ModeloProposta> Modelos { get; set; }
    }
}
