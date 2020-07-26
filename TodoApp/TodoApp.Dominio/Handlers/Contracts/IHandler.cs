using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Dominio.Commands.Contracts;

namespace TodoApp.Dominio.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommandBase
    {
        ICommandResult Handle(T command);

    }
}
