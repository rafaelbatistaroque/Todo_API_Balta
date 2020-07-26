using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TodoApp.Dominio.Entidades;

namespace TodoApp.Dominio.Repositorios
{
    public interface ITarefaRepositorio
    {
        void Criar(Tarefa tarefa);
        void Atualizar(Tarefa tarefa);
        Tarefa Obter(Guid id, string usuario);
        IQueryable<Tarefa> Obter(string usuario);
        IQueryable<Tarefa> Obter(Expression<Func<Tarefa, bool>> criterio, string usuario);
    }
}
