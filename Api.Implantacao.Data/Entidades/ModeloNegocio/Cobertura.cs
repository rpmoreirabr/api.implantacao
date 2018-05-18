using System.Collections.Generic;

namespace Api.Implantacao.Data.Entidades.ModeloNegocio
{
    public class Cobertura
    {
        public int? Id { get; set; }
         public string Descricao { get; set; }
        public string DescricaoComercial { get; set; }
         public bool? Obrigatoria { get; set; }
        public List<PrazoRenda> PrazoRenda { get; set; }
        public TipoCobertura Tipo { get; set; }
        public TipoRelacaoSegurado TipoRelacaoSegurado { get; set; }
        public int? IdadeMinima { get; set; }
        public int? IdadeMaxima { get; set; }
        public int? IdadeExclusao { get; set; }
        public bool? IndicarBeneficiario { get; set; }
        public float? ValorFixo { get; set; }
        public float? CapitalFixo { get; set; }
        public List<Causa> Causas { get; set; }
        public bool? CoberturaPrincipal { get; set; }
        public bool? ExigeDPS { get; set; }
        public List<Fundo> Fundos { get; set; }
        public List<int> ProfissoesRecusadas { get; set; }
        public List<string> UFsRecusadas { get; set; }
        public List<int> PrazoDecrescimo { get; set; }
        public List<int> IdadeAntecipacao { get; set; }
        public List<int> TempoAntecipacao { get; set; }
    }
}