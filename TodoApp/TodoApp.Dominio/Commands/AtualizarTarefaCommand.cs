using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Dominio.Commands.Contracts;

namespace TodoApp.Dominio.Commands
{
    public class AtualizarTarefaCommand : Notifiable, ICommandBase
    {
        public Guid Id { get; set; }
        public string Usuario { get; set; }
        public string Titulo { get; set; }

        public AtualizarTarefaCommand() { }

        public AtualizarTarefaCommand(Guid id, string usuario, string titulo)
        {
            Id = id;
            Usuario = usuario;
            Titulo = titulo;
        }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Titulo, 3, nameof(Titulo), "Sua Tarefa precisa ser mais detalhada!")
                .HasMinLen(Usuario, 6, nameof(Usuario), "Usuário Inválido!"));
        }
    }
}
