using System;
using System.Collections.Generic;

namespace Api.Implantacao.Data.Entidades.ModeloNegocio
{
    public class Questionario
    {       
        public int? Id { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public TipoQuestionario Tipo { get; set; }
        public Sexo Sexo { get; set; }
        public TipoRelacaoSegurado RelacaoSegurado { get; set; }
        public List<ItemQuestionario> Perguntas { get; set; }
    }
}