using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TodoApp.Dominio.Commands;
using TodoApp.Dominio.Commands.Contracts;

namespace TodoApp.Teste
{
    [TestClass]
    public class CriarTarefaCommandTeste
    {
        private CriarTarefaCommand _commandoInvalido;
        private CriarTarefaCommand _commandoValido;

        [TestInitialize]
        public void Iniciar()
        {
            _commandoInvalido = new CriarTarefaCommand("", "", DateTime.Now);
            _commandoValido = new CriarTarefaCommand("Tarefa1", "Rafael", DateTime.Now);
            _commandoInvalido.Validate();
            _commandoValido.Validate();
        }

        [TestMethod]
        public void DevePassarSeComandoInvalido()
        {
            Assert.AreEqual(_commandoInvalido.Valid, false);
        }

        [TestMethod]
        public void DevePassarSeComandoValido()
        {
            Assert.AreEqual(_commandoValido.Valid, true);
        }
    }
}
