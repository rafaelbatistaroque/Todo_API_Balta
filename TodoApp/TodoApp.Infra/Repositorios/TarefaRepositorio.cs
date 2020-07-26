using System;
using System.Linq;
using System.Linq.Expressions;
using TodoApp.Dominio.Entidades;
using TodoApp.Dominio.Repositorios;

namespace TodoApp.Infra.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        public void Atualizar(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public void Criar(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public Tarefa Obter(Guid id, string usuario)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Tarefa> Obter(string usuario)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Tarefa> Obter(Expression<Func<Tarefa, bool>> criterio, string usuario)
        {
            throw new NotImplementedException();
        }
    }
}
