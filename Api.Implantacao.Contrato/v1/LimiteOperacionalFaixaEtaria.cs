namespace Api.Implantacao.Contrato.v1
{
    public class LimiteOperacionalFaixaEtaria
    {
        public string Causa { get; set; }
        public int? IdadeInicial { get; set; }
        public int? IdadeFinal { get; set; }
        public int? ValorMaximoCapitalSegurado { get; set; }
    }

}
