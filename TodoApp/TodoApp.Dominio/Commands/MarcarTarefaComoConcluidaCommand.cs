using Flunt.Notifications;
using Flunt.Validations;
using System;
using TodoApp.Dominio.Commands.Contracts;

namespace TodoApp.Dominio.Commands
{
    public class MarcarTarefaComoConcluidaCommand : Notifiable, ICommandBase
    {
        public Guid Id { get; set; }
        public string Usuario { get; set; }

        public MarcarTarefaComoConcluidaCommand() { }

        public MarcarTarefaComoConcluidaCommand(Guid id, string usuario)
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
