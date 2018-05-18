using Api.Implantacao.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implantacao.Data.Entidades.ModeloNegocio
{
    public class Profissao : IEntidade<int>
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Cbo { get; set; }
        public string CodigoIr { get; set; }
        public decimal? ValorMaximoCapitalSegurado { get; set; }
        public short CodigoSysPrev { get; set; }
        public List<short> CodigosDoSysPrev { get; set; }
    }
}
