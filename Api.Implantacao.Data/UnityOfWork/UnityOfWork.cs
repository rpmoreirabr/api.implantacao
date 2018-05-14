using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implantacao.Data.UnityOfWork
{
    public class UnityOfWork : IUnityOfWork<IDocumentClient>
    {
        public IDbTransaction IniciarTransacao()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public void Excluir<T>(T objeto)
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public T Salvar<T>(T objeto)
        {
            throw new NotImplementedException();
        }

        public IDocumentClient AbrirConexao()
        {
            return new DocumentClient(new Uri("https://localhost:8081/"), "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==");
        }
    }
}
