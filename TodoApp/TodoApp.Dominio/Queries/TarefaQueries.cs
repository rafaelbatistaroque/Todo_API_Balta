using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
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
            return x => x.Usuario == usuario && x.Feito;
        }

        public static Expression<Func<Tarefa, bool>> ObterTodasNaoConcluidas(string usuario)
        {
            return x => x.Usuario == usuario && x.Feito == false;
        }

        public static Expression<Func<Tarefa, bool>> ObterTodasPorPeriodo(string usuario, DateTime data, bool statusConcluida)
        {
            return x => x.Usuario == usuario && x.Feito == statusConcluida && x.Data.Date == data;
        }
    }
}
