using System;
using System.Linq.Expressions;
using TodoApp.Dominio.Entidades;

namespace TodoApp.Dominio.Queries
{
    public static class TarefaQueries
    {
        public static Expression<Func<Tarefa, bool>> ObterTodas(string usuario)
        {
            return x => x.Usuario == usuario;
        }

        public static Expression<Func<Tarefa, bool>> ObterTodasConcluidas(string usuario)
        {
            return x => x.Usuario == usuario && x.Feito == true;
        }

        public static Expression<Func<Tarefa, bool>> ObterTodasNaoConcluidas(string usuario)
        {
            return x => x.Usuario == usuario && x.Feito == false;
        }

        public static Expression<Func<Tarefa, bool>> ObterTodasPorPeriodo(string usuario, DateTime data, bool status)
        {
            return x => x.Usuario == usuario && x.Feito == status && x.Data.Date == data;
        }

        public static Expression<Func<Tarefa, bool>> ObterPorId(Guid id, string usuario)
        {
            return x => x.Usuario == usuario && x.Id == id;
        }
    }
}
