using Entidades = Api.Implantacao.Data.Entidades;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Api.Implantacao.Data.Repositorio;

namespace Api.Implantacao.Controllers
{
    [RoutePrefix("api/modeloNegocio")]
    public class ModeloNegocioController : ApiController
    {
        private ILogger Log;
        private IRepositorio<Entidades.ModeloNegocio.ModeloNegocio, string> RepositorioModeloNegocio;
        public ModeloNegocioController(ILogger log, IRepositorio<Entidades.ModeloNegocio.ModeloNegocio, string> repositorioModeloNegocio)
        {
            Log = log;
            RepositorioModeloNegocio = repositorioModeloNegocio;
        }

        [HttpGet]
        public async Task<IHttpActionResult> ModeloNegocio(string cnpj, string canalVenda)
        {
            Expression<Func<Entidades.ModeloNegocio.ModeloNegocio, bool>> predicado;

            if (canalVenda != String.Empty)
            {
                predicado = mn => mn.Cnpj == cnpj && mn.CanalVenda == canalVenda;
            }
            else
            {
                predicado = mn => mn.Cnpj == cnpj;
            }
            var modelosNegocio = await RepositorioModeloNegocio.SelecionarAsync(predicado);
            return Ok(modelosNegocio);
        }

        [HttpGet]
        public async Task<IHttpActionResult> ModeloNegocioPorId(string cnpj, string id)
        {
            var modelosNegocio = await RepositorioModeloNegocio.SelecionarAsync(mn => mn.Cnpj == cnpj && mn.Modelos.Any(mp => mp.Id == id));

            var modeloNegocio = modelosNegocio.FirstOrDefault();
            modeloNegocio.Modelos = modeloNegocio.Modelos.Where(mp => mp.Id == id).ToList();

            return Ok(modeloNegocio);
        }
    }
}