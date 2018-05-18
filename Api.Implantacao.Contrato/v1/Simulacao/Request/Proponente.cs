using System;

namespace Api.Implantacao.Contrato.v1.Simulacao.Request
{

    public class Proponente {
    public DateTime? DataNascimento { get; set; }
    public long? Documento { get; set; }
    public string Sexo { get; set; }
    public string Profissao { get; set; }
    public string Estado { get; set; }
    public decimal? Renda { get; set; }
    public string DeclaracaoIr { get; set; }
  }
}
