using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implantacao.Data.UnityOfWork
{
    public interface IUnityOfWork<TConnection> : IDisposable
    {
        TConnection AbrirConexao();
        IDbTransaction IniciarTransacao();
        void Commit();
        void Rollback();

        T Salvar<T>(T objeto);
        void Excluir<T>(T objeto);

    }
}
