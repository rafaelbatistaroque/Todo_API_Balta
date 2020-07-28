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
        Tarefa ObterTarefa(Guid id, string usuario);
        IQueryable<Tarefa> ObterTodas(string usuario);
        IQueryable<Tarefa> ObterConcluidas(string usuario);
        IQueryable<Tarefa> ObterNaoConcluidas(string usuario);
        IQueryable<Tarefa> ObterPorPeriodo(string usuario, DateTime data, bool status);

    }
}
