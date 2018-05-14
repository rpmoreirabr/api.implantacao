using Api.Implantacao.Data.UnityOfWork;
using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Linq;
using Microsoft.Azure.Documents;
using Api.Implantacao.Contrato;
using System.Linq.Expressions;

namespace Api.Implantacao.Data.Repositorios
{
    public class Repositorio<T, Tid> : IRepositorio<T, Tid> 
        where T : IEntidade<Tid>        
    {
        protected string DatabaseId { get; set; }
        protected string CollectionId { get; set; }
        protected Uri CollectionLink { get => UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId); }
        public IUnityOfWork<IDocumentClient> UnityOfWork { get; set; }

        public Repositorio(IUnityOfWork<IDocumentClient> uow)
        {
            UnityOfWork = uow;           
        }

        public T Salvar(T objeto)
        {
            return UnityOfWork.Salvar(objeto);
        }

        public void Excluir(T objeto)
        {
            Excluir(objeto);
        }
       
        public async Task<T> RecuperarAsync(Tid id)
        {
            var documentClient = UnityOfWork.AbrirConexao();
            var query = documentClient.CreateDocumentQuery<T>(CollectionLink, $"SELECT * FROM c WHERE c.Id = {id}")
                .AsDocumentQuery();
            var retorno = await query.ExecuteNextAsync<T>();
            return retorno.FirstOrDefault();
        }

        public async Task<List<T>> SelecionarAsync(Expression<Func<T, bool>> filtro)
        {
            var documentClient = UnityOfWork.AbrirConexao();
            var query = documentClient.CreateDocumentQuery<T>(CollectionLink)
                .Where(filtro)                
                .AsDocumentQuery();
            var retorno = await query.ExecuteNextAsync<T>();
            return retorno.ToList();
        }

        public async Task<List<T>> RecuperarTodosAsync()
        {
            var documentClient = UnityOfWork.AbrirConexao();
            var query = documentClient.CreateDocumentQuery<T>(CollectionLink).AsDocumentQuery();
            var retorno = await query.ExecuteNextAsync<T>();
            return retorno.ToList();
        }        
    }
}
