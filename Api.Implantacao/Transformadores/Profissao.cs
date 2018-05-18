using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contratos = Api.Implantacao.Contrato.v1;
using Entidades = Api.Implantacao.Data.Entidades;
namespace Api.Implantacao.Transformadores
{
    public static class Profissao
    {
        public static Contratos.Profissao v1(this Entidades.ModeloNegocio.Profissao objeto)
        {
            return new Contratos.Profissao()
            {
                Cbo = objeto.Cbo,
                Descricao = objeto.Descricao,
                Id = objeto.Id
            };
        }

        public static Entidades.ModeloNegocio.Profissao Entidade(this Contratos.Profissao objeto)
        {
            return new Entidades.ModeloNegocio.Profissao()
            {
                Cbo = objeto.Cbo,
                Descricao = objeto.Descricao,
                Id = objeto.Id
            };
        }

        public static List<Entidades.ModeloNegocio.Profissao> Entidades(this List<Contratos.Profissao> objetos)
        {
            var retorno = new List<Entidades.ModeloNegocio.Profissao>();
            objetos.ForEach(o => retorno.Add(Entidade(o)));
            return retorno;
        }

        public static List<Contratos.Profissao> v1(this List<Entidades.ModeloNegocio.Profissao> objetos)
        {
            var retorno = new List<Contratos.Profissao>();
            objetos.ForEach(o => retorno.Add(v1(o)));
            return retorno;
        }
    }
}