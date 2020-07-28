using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using TodoApp.Dominio.Entidades;
using TodoApp.Dominio.Queries;
using TodoApp.Dominio.Repositorios;
using TodoApp.Infra.Contexts;

namespace TodoApp.Infra.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly DataContext _bd;

        public TarefaRepositorio(DataContext bd)
        {
            _bd = bd;
        }

        public void Atualizar(Tarefa tarefa)
        {
            _bd.Entry(tarefa).State = EntityState.Modified;
        }

        public void Criar(Tarefa tarefa)
        {
            _bd.Tarefas.Add(tarefa);
        }

        public Tarefa ObterTarefa(Guid id, string usuario)
        {
            return _bd.Tarefas
               .FirstOrDefault(TarefaQueries.ObterPorId(id, usuario));
        }

        public IQueryable<Tarefa> ObterTodas(string usuario)
        {
            return _bd.Tarefas
                .AsNoTracking()
                .Where(TarefaQueries.ObterTodas(usuario))
                .OrderBy(x => x.Data);
        }

        public IQueryable<Tarefa> ObterConcluidas(string usuario)
        {
            return _bd.Tarefas
               .AsNoTracking()
               .Where(TarefaQueries.ObterTodasConcluidas(usuario))
               .OrderBy(x => x.Data);
        }

        public IQueryable<Tarefa> ObterNaoConcluidas(string usuario)
        {
            return _bd.Tarefas
               .AsNoTracking()
               .Where(TarefaQueries.ObterTodasNaoConcluidas(usuario))
               .OrderBy(x => x.Data);
        }

        public IQueryable<Tarefa> ObterPorPeriodo(string usuario, DateTime data, bool status)
        {
            return _bd.Tarefas
                .AsNoTracking()
                .Where(TarefaQueries.ObterTodasPorPeriodo(usuario, data, status))
                .OrderBy(x => x.Data);
        }
    }
}
