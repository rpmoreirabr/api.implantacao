using Api.Implantacao.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Api.Implantacao.Data.Repositorio
{
    public interface IRepositorio<T, Tid>
        where T : IEntidade<Tid>
    {
        T Salvar(T objeto);
        void Excluir(T objeto);
        Task<T> RecuperarAsync(Tid id);
        Task<List<T>> RecuperarTodosAsync();
        Task<List<T>> SelecionarAsync(Expression<Func<T, bool>> filtro);
    }
}
