using Api.Implantacao.Data.Repositorio;
using API.Infraestrutura.Base.CaixaDeExecucao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Entidades = Api.Implantacao.Data.Entidades;
namespace Api.Implantacao.Controllers
{
    [RoutePrefix("api/simulacaoindividual")]
    public class SimulacaoController : BaseController
    {
        protected IRepositorio<Entidades.Simulacao.Simulacao, string> RepositorioSimulacoes { get; }

        public SimulacaoController(IRepositorio<Entidades.Simulacao.Simulacao, string> repositorioSimulacoes, Serilog.ILogger logger)
        {
            RepositorioSimulacoes = repositorioSimulacoes;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IHttpActionResult> GetSimulacao(string id)
        {
            return Ok(await RepositorioSimulacoes.RecuperarAsync(id));          
        }

        [HttpPost]
        [Route]
        public async Task<IHttpActionResult> PostSimulacao([FromBody] Contrato.v1.Simulacao.Request.Request request)
        {
            Entidades.Simulacao.Simulacao retorno = null;
           
            var simulacoes = await RepositorioSimulacoes.SelecionarAsync(s =>
                s.Request.Contratacao.ModeloProposta == request.Contratacao.ModeloProposta &&
                s.Request.Proponente.Documento == request.Proponente.Documento &&
                s.Request.Proponente.DeclaracaoIr == request.Proponente.DeclaracaoIr &&
                s.Request.Proponente.Profissao == request.Proponente.Profissao
            );
            if (simulacoes.Count() > 0 )
            {
                retorno = simulacoes.First();
            }
            else
            {
                var vendaEngineUrl = System.Configuration.ConfigurationManager.AppSettings["Api.Engine.Venda.Simulacao.Url"];
                var cliente = new HttpClient();
                var response = await cliente.PostAsJsonAsync(vendaEngineUrl, request);
                if (response.IsSuccessStatusCode)
                {
                    retorno = (Entidades.Simulacao.Simulacao)await response.Content.ReadAsAsync(typeof(Entidades.Simulacao.Simulacao));
                }
                else
                {
                    return InternalServerError(new Exception(response.ReasonPhrase));
                }
            }           
                return Created($"{Request.RequestUri}{retorno.Id}", retorno);           
        }
    }
}
