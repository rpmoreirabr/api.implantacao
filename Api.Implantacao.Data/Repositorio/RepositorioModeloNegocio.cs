using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Implantacao.Data.UnityOfWork;
using Microsoft.Azure.Documents;

namespace Api.Implantacao.Data.Repositorio
{
    public class RepositorioModeloNegocio : Repositorio<Entidades.ModeloNegocio.ModeloNegocio, string>
    {
        public RepositorioModeloNegocio(IUnityOfWork<IDocumentClient> uow) : base(uow)
        {
            DatabaseId = "Venda";
            CollectionId = "ModelosNegocio";
        }
    }
}
