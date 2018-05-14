namespace Api.Implantacao.Contrato.v1
{
    public class LimiteOperacionalRenda
    {
        public string Causa { get; set; }
        public int? IdadeInicial { get; set; }
        public int? IdadeFinal { get; set; }
        public int? MultiploRenda { get; set; }
    }
}