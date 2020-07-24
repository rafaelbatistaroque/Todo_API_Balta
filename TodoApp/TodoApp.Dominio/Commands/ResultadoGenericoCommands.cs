﻿using TodoApp.Dominio.Contracts;

namespace TodoApp.Dominio.Commands
{
    public class ResultadoGenericoCommands : ICommandResult
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public object Dados { get; set; }

        public ResultadoGenericoCommands() { }

        public ResultadoGenericoCommands(bool sucesso, string mensagem, object dados)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Dados = dados;
        }
    }
}