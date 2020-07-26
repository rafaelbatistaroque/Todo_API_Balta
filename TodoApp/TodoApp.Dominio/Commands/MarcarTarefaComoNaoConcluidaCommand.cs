using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Dominio.Commands.Contracts;

namespace TodoApp.Dominio.Commands
{
    public class MarcarTarefaComoNaoConcluidaCommand : Notifiable, ICommandBase
    {
        public Guid Id { get; set; }
        public string Usuario { get; set; }

        public MarcarTarefaComoNaoConcluidaCommand() { }

        public MarcarTarefaComoNaoConcluidaCommand(Guid id, string usuario)
        {
            Id = id;
            Usuario = usuario;
        }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Usuario, 6, nameof(Usuario), "Usuário inválido!"));
        }
    }
}
