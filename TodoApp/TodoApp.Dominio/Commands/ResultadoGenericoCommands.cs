using TodoApp.Dominio.Commands.Contracts;

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

        public ResultadoGenericoCommands(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }
    }
}
