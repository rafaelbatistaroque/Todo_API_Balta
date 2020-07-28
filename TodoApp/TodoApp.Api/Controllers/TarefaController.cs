using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TodoApp.Dominio.Commands;
using TodoApp.Dominio.Entidades;
using TodoApp.Dominio.Handlers;
using TodoApp.Dominio.Repositorios;

namespace TodoApp.Api.Controllers
{
    [ApiController]
    [Route("v1/tarefas")]
    public class TarefaController : ControllerBase
    {
        [HttpPost("")]
        public ResultadoGenericoCommands Criar([FromBody] CriarTarefaCommand command, [FromServices] TarefaHandler handler)
        {
            command.Usuario = "Rafael";
            return (ResultadoGenericoCommands)handler.Handle(command);
        }

        [HttpGet("concluidas")]
        public IEnumerable<Tarefa> ObterConcluidas([FromServices] ITarefaRepositorio repositorio)
        {
            return repositorio.ObterConcluidas("Rafael");
        }

        [HttpGet("nao-concluidas")]
        public IEnumerable<Tarefa> ObterNaoConcluidas([FromServices] ITarefaRepositorio repositorio)
        {
            return repositorio.ObterNaoConcluidas("Rafael");
        }

        [HttpGet("concluidas/hoje")]
        public IEnumerable<Tarefa> ObterConcluidasHoje([FromServices] ITarefaRepositorio repositorio)
        {
            return repositorio.ObterPorPeriodo("Rafael", DateTime.Now.Date, true);
        }

        [HttpGet("nao-concluidas/hoje")]
        public IEnumerable<Tarefa> ObterNaoConcluidasHoje([FromServices] ITarefaRepositorio repositorio)
        {
            return repositorio.ObterPorPeriodo("Rafael", DateTime.Now.Date, false);
        }

        [HttpGet("nao-concluidas/amanha")]
        public IEnumerable<Tarefa> ObterNaoConcluidasAmanha([FromServices] ITarefaRepositorio repositorio)
        {
            return repositorio.ObterPorPeriodo("Rafael", DateTime.Now.Date.AddDays(1), false);
        }

        [HttpGet("")]
        public IEnumerable<Tarefa> ObterTodas([FromServices] ITarefaRepositorio repositorio)
        {
            //var usuario = User.Claims
            //    .FirstOrDefault(x => x.Type == "user_id")?.Value;
            return repositorio.ObterTodas("Rafael");
        }

        [HttpPut("")]
        public ResultadoGenericoCommands Atualizar([FromBody] AtualizarTarefaCommand command, [FromServices] TarefaHandler handler)
        {
            command.Usuario = "Rafael";
            return (ResultadoGenericoCommands)handler.Handle(command);
        }

        [HttpPut("marcar-como-concluida")]
        public ResultadoGenericoCommands MarcarComoConcluida([FromBody] MarcarTarefaComoConcluidaCommand command, [FromServices] TarefaHandler handler)
        {
            command.Usuario = "Rafael";
            return (ResultadoGenericoCommands)handler.Handle(command);
        }

        [HttpPut("marcar-como-nao-concluida")]
        public ResultadoGenericoCommands MarcarNaoComoConcluida([FromBody] MarcarTarefaComoNaoConcluidaCommand command, [FromServices] TarefaHandler handler)
        {
            command.Usuario = "Rafael";
            return (ResultadoGenericoCommands)handler.Handle(command);
        }
    }
}