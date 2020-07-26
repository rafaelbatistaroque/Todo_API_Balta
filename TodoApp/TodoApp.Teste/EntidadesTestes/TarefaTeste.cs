using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TodoApp.Dominio.Entidades;

namespace TodoApp.Teste.EntidadesTestes
{
    [TestClass]
    public class TarefaTeste
    {
        private Tarefa _novaTarefa;
        [TestInitialize]
        public void Iniciar()
        {
            _novaTarefa = new Tarefa("Tarefa1", DateTime.Now, "Rafael");
        }

        [TestMethod]
        public void DevePassarSeNovaTarefaNaoEhConcluida()
        {
            Assert.AreEqual(false, _novaTarefa.Feito);
        }

        [TestMethod]
        public void DevePassarTarefaFoiMarcadaComoConcluida()
        {
            _novaTarefa.MarcarComoConcluida();
            Assert.AreEqual(true, _novaTarefa.Feito);
        }
    }
}
