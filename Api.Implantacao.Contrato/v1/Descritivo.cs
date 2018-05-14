﻿using Api.Implantacao.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implantacao.Contrato.v1
{
    public abstract class Descritivo : IEntidade<int>
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
