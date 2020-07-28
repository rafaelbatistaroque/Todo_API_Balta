using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.Dominio.Entidades;
using TodoApp.Dominio.Queries;
using TodoApp.Dominio.Repositorios;

namespace TodoApp.Teste.Repositorios
{
    public class FakeTarefaRepositorio : ITarefaRepositorio
    {
        private readonly IList<Tarefa> tarefas = new List<Tarefa>() {
            new Tarefa("Titulo novo 1", DateTime.Now, "Rafael novo 1"),
            new Tarefa("Titulo novo 2", DateTime.Now, "Rafael novo 1")
        };

        public void Atualizar(Tarefa tarefa) { }

        public void Criar(Tarefa tarefa) { }

        public Tarefa ObterTarefa(Guid id, string usuario)
        {
            return new Tarefa("Titulo novo", DateTime.Now, "Rafael novo");
        }

        public IQueryable<Tarefa> ObterTodas(string usuario)
        {
            return tarefas.AsQueryable().Where(TarefaQueries.ObterTodas(usuario));
        }

        public IQueryable<Tarefa> ObterConcluidas(string usuario)
        {
            return tarefas.AsQueryable().Where(TarefaQueries.ObterTodasConcluidas(usuario));
        }

        public IQueryable<Tarefa> ObterNaoConcluidas(string usuario)
        {
            return tarefas.AsQueryable().Where(TarefaQueries.ObterTodasNaoConcluidas(usuario));
        }

        public IQueryable<Tarefa> ObterPorPeriodo(string usuario, DateTime data, bool status)
        {
            return tarefas.AsQueryable().Where(TarefaQueries.ObterTodasPorPeriodo(usuario, data, status));
        }
    }
}
