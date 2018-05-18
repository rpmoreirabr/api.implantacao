namespace Api.Implantacao.Data.Entidades.ModeloNegocio
{
    public class LimiteOperacionalProfissao
    {
        public string Causa { get; set; }
       
        public int? ProfissaoId { get; set; }

        public float? ValorMaximoCapitalSegurado { get; set; }
    }
}