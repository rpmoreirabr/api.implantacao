using Api.Implantacao.Data.Repositorio;
using Api.Implantacao.Transformadores;
using API.Infraestrutura.Base.CaixaDeExecucao;
using API.Infraestrutura.Base.Contexto;
using API.Infraestrutura.Contrato;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Entidades = Api.Implantacao.Data.Entidades;
namespace Api.Implantacao.Controllers
{

    [RoutePrefix("api/profissao")]
    public class ProfissaoController : BaseController
    {
        protected IRepositorio<Entidades.ModeloNegocio.Profissao, int> RepositorioProfissao { get; }
        private Serilog.ILogger Log { get; }

        public ProfissaoController(IRepositorio<Entidades.ModeloNegocio.Profissao, int> repositorioProfissao, Serilog.ILogger logger)
        {
            RepositorioProfissao = repositorioProfissao;
            Log = logger;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Profissao()
        {
            var profissoes = await RepositorioProfissao.RecuperarTodosAsync();
            return Ok(profissoes.v1());
        }

        [HttpGet]
        [Route("{cbo}")]
        public IHttpActionResult ProfissaoPorCbo(string cbo)
        {
            this.Log.Information("teste");

            var resultado = Resultado<Contrato.v1.Profissao>.DaOperacao("ProfissaoPorCbo")
                .V1()
                .SemGerenciarConexaoDoBancoDeDados()
                .Rastrear($"Profissão: {cbo}")
                .Executar(() =>
                {
                    var profissoesTask = Task.Run(() => RepositorioProfissao.SelecionarAsync(p => p.Cbo == cbo));
                    profissoesTask.Wait();
                    var profissoes = profissoesTask.Result;
                    AddCorrelationKey(Contexto.Atual.Id);
                    AddMetadados(new string[] { "cbo", cbo });

                    return ResultadoDaOperacao<Contrato.v1.Profissao>.ComValor(profissoes.v1().FirstOrDefault());
                });

            if (resultado.HouveErrosDuranteProcessamento)
                return InternalServerError(new Exception(string.Join(",", resultado.Mensagens)));
            else
            {
                if (resultado.Valor == null)
                    return NotFound();
                else
                    return Ok(resultado.Valor);
            }
        }
    }
}