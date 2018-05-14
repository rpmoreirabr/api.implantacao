using Api.Implantacao.Contrato;
using System;
using System.Collections.Generic;

namespace Api.Implantacao.Data.Entidades
{
    public class Produto : IEntidade<int>
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string DescricaoComercial { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public List<Cobertura> Coberturas { get; set; }
        public List<DependenciaProduto> DependenciasProduto { get; set; }
        public List<Fundo> Fundos { get; set; }
        public List<Periodicidade> Periodicidades { get; set; }
        public TipoProponente TipoProponente { get; set; }
        public int? IdadeMinima { get; set; }
        public int? IdadeMaxima { get; set; }
        public int? IdadeExclusao { get; set; }
        public bool? IndicarBeneficiario { get; set; }
        public bool? ExigeDPS { get; set; }
        public List<int> PrazoCerto { get; set; }
        public List<PrazoRenda> PrazoRenda { get; set; }
        public List<int> ProfissoesAceitas { get; set; }
        public List<int> ProfissoesRecusadas { get; set; }
        public List<string> UFsRecusadas { get; set; }
        public List<int> PrazoDecrescimo { get; set; }
        public List<int> IdadeAntecipacao { get; set; }
        public List<int> TempoAntecipacao { get; set; }
    }
}