using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TodoApp.Dominio.Entidades;
using TodoApp.Dominio.Repositorios;

namespace TodoApp.Teste.Repositorios
{
    public class FakeTarefaRepositorio : ITarefaRepositorio
    {
        public void Atualizar(Tarefa tarefa) { }

        public void Criar(Tarefa tarefa) { }

        public Tarefa Obter(Guid id, string usuario)
        {
            return new Tarefa("Titulo novo", DateTime.Now, "Rafael novo");
        }

        public IQueryable<Tarefa> Obter(string usuario)
        {
            var tarefas = new List<Tarefa> {
                new Tarefa("Titulo novo 1", DateTime.Now, "Rafael novo 1"),
                new Tarefa("Titulo novo 2", DateTime.Now, "Rafael novo 1")
            };

            return tarefas.AsQueryable().Where(x => x.Usuario == usuario);
        }

        public IQueryable<Tarefa> Obter(Expression<Func<Tarefa, bool>> criterio, string usuario)
        {
            var tarefas = new List<Tarefa> {
                new Tarefa("Titulo novo 1", DateTime.Now, "Rafael novo 1"),
                new Tarefa("Titulo novo 2", DateTime.Now, "Rafael novo 1")
            };

            return tarefas.AsQueryable().Where(criterio);
        }
    }
}
