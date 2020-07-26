using Flunt.Notifications;
using TodoApp.Dominio.Commands;
using TodoApp.Dominio.Commands.Contracts;
using TodoApp.Dominio.Entidades;
using TodoApp.Dominio.Handlers.Contracts;
using TodoApp.Dominio.Repositorios;

namespace TodoApp.Dominio.Handlers
{
    public class TarefaHandler :
        Notifiable,
        IHandler<CriarTarefaCommand>,
        IHandler<AtualizarTarefaCommand>,
        IHandler<MarcarTarefaComoConcluidaCommand>,
        IHandler<MarcarTarefaComoNaoConcluidaCommand>
    {
        private readonly ITarefaRepositorio _repositorio;

        public TarefaHandler(ITarefaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public ICommandResult Handle(CriarTarefaCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new ResultadoGenericoCommands(false, "Erro! Sua tarefa está errada.", command.Notifications);

            var tarefa = new Tarefa(command.Titulo, command.Data, command.Usuario);

            _repositorio.Criar(tarefa);

            return new ResultadoGenericoCommands(true, "Sucesso! Tarefa salva.", tarefa);
        }

        public ICommandResult Handle(AtualizarTarefaCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new ResultadoGenericoCommands(false, "Erro! Sua tarefa está errada.", command.Notifications);

            Tarefa tarefa = _repositorio.Obter(command.Id, command.Usuario);

            tarefa.ModificarTitulo(command.Titulo);

            _repositorio.Atualizar(tarefa);

            return new ResultadoGenericoCommands(true, "Sucesso! Tarefa salva.", tarefa);
        }

        public ICommandResult Handle(MarcarTarefaComoConcluidaCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new ResultadoGenericoCommands(false, "Erro! Não foi possível concluir esta tarefa.", command.Notifications);

            Tarefa tarefa = _repositorio.Obter(command.Id, command.Usuario);

            tarefa.MarcarComoConcluida();

            _repositorio.Atualizar(tarefa);

            return new ResultadoGenericoCommands(true, "Sucesso! Tarefa salva.", tarefa);
        }

        public ICommandResult Handle(MarcarTarefaComoNaoConcluidaCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new ResultadoGenericoCommands(false, "Erro! Não foi possível desmarcar esta tarefa.", command.Notifications);

            Tarefa tarefa = _repositorio.Obter(command.Id, command.Usuario);

            tarefa.MarcarComoNaoConcluida();

            _repositorio.Atualizar(tarefa);

            return new ResultadoGenericoCommands(true, "Sucesso! Tarefa salva.", tarefa);
        }
    }
}
