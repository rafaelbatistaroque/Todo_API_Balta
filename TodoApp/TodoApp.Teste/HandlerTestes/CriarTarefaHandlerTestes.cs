using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Dominio.Commands;
using TodoApp.Dominio.Handlers;
using TodoApp.Teste.Repositorios;

namespace TodoApp.Teste.HandlerTestes
{
    [TestClass]
    public class CriarTarefaHandlerTestes
    {
        private ResultadoGenericoCommands _resultado;
        private CriarTarefaCommand _commandoInvalido;
        private CriarTarefaCommand _commandoValido;
        private TarefaHandler _handler;

        [TestInitialize]
        public void Iniciar()
        {
            _commandoInvalido = new CriarTarefaCommand("", "", DateTime.Now);
            _commandoValido = new CriarTarefaCommand("Tarefa1", "Rafael", DateTime.Now);
            _handler = new TarefaHandler(new FakeTarefaRepositorio());
            _resultado = new ResultadoGenericoCommands();

            _commandoInvalido.Validate();
            _commandoValido.Validate();
        }

        [TestMethod]
        public void DevePassarSeResultadoInvalido()
        {
            _resultado = _handler.Handle(_commandoInvalido) as ResultadoGenericoCommands;
            Assert.AreEqual(_resultado.Sucesso, false);
        }

        [TestMethod]
        public void DevePassarSeResultadoValido()
        {
            _resultado =  _handler.Handle(_commandoValido) as ResultadoGenericoCommands;
            Assert.AreEqual(_resultado.Sucesso, true);
        }
    }
}
