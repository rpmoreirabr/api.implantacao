using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implantacao.Contrato
{
    public interface IEntidade<Tid>
    {
        Tid Id { get; set; }
    }
}
