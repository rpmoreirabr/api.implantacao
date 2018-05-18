using Api.Implantacao.Contrato;
using Api.Implantacao.Data.UnityOfWork;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implantacao.Data.Repositorio
{
    public class RepositorioProfissao : Repositorio<Entidades.ModeloNegocio.Profissao, Int32>
    {
        public RepositorioProfissao(IUnityOfWork<IDocumentClient> uow) : base(uow)
        {
            DatabaseId = "Venda";
            CollectionId = "Profissoes";            
        }
    }
}
