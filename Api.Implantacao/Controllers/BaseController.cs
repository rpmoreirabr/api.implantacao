using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Api.Implantacao.Controllers
{
    public class BaseController : ApiController
    {
        public void AddCorrelationKey(string key)
        {
            HttpContext.Current.Items.Add("Correlation-Key", key);
        }

        public void AddMetadados(List<string> metadados)
        {
            this.AddMetadados(metadados.ToArray());
        }

        public void AddMetadados(string[] metadados)
        {
            HttpContext.Current.Items.Add("Metadados", metadados);
        }
    }
}