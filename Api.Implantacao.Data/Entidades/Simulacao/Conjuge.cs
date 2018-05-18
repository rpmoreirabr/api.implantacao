using System;

namespace Api.Implantacao.Data.Entidades.Simulacao
{

    public class Conjuge
    {
        public DateTime? DataNascimento { get; set; }

        public long? Documento { get; set; }

        public string Sexo { get; set; }

        public string Profissao { get; set; }
    }
}