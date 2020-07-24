using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Windows.Input;
using TodoApp.Dominio.Contracts;

namespace TodoApp.Dominio.Commands
{
    public class CriarTarefaCommand : Notifiable, ICommandBase
    {
        public string Titulo { get; set; }
        public string Usuario { get; set; }
        public DateTime Data { get; set; }

        public CriarTarefaCommand() { }

        public CriarTarefaCommand(string titulo, string usuario, DateTime data)
        {
            Titulo = titulo;
            Usuario = usuario;
            Data = data;
        }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Titulo, 3, nameof(Titulo), "Sua Tarefa precisa ser mais detalhada!")
                .HasMinLen(Usuario, 6, nameof(Usuario), "Usuário Inválido!")
                );

            return;
        }
    }
}
