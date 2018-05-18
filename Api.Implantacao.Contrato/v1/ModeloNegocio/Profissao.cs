using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implantacao.Contrato.v1
{
    public class Profissao : IEntidade<int>
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Cbo { get; set; }
    }
}
