using Api.Implantacao.Data.UnityOfWork;
using Microsoft.Azure.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implantacao.Data.Repositorio
{
    public class RepositorioSimulacao : Repositorio<Entidades.Simulacao.Simulacao, string>
    {
        public RepositorioSimulacao(IUnityOfWork<IDocumentClient> uow) : base(uow)
        {
            DatabaseId = "Venda";
            CollectionId = "Simulacoes";
        }
    }
}
