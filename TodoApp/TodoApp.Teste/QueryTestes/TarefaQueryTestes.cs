using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoApp.Dominio.Entidades;
using TodoApp.Dominio.Queries;

namespace TodoApp.Teste.QueryTestes
{
    [TestClass]
    public class TarefaQueryTestes
    {
        private IList<Tarefa> _tarefas;

        [TestInitialize]
        public void Iniciar()
        {
            _tarefas = new List<Tarefa> {
                new Tarefa("Titulo 1", DateTime.Now, "Rafael 1"),
                new Tarefa("Titulo 2", DateTime.Now, "Rafael 2"),
                new Tarefa("Titulo 3", DateTime.Now, "Rafael 1"),
                new Tarefa("Titulo 4", DateTime.Now, "Rafael 3"),
                new Tarefa("Titulo 5", DateTime.Now, "Rafael 4"),
            };
        }

        [TestMethod]
        public void DevePassarSeConsultaRetornarTarefasDeUsuarioEspecifico()
        {
            var resultado = _tarefas.AsQueryable().Where(TarefaQueries.ObterTodas("Rafael 1"));
            Assert.AreEqual(2, resultado.Count());
        }
    }
}
