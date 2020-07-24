using System;

namespace TodoApp.Dominio.Entidades
{
    public class Tarefa : Entidade
    {
        public string Titulo { get; private set; }
        public bool Feito { get; private set; }
        public DateTime Data { get; private set; }
        public string Usuario { get; private set; }

        public Tarefa(string titulo, DateTime data, string usuario)
        {
            Titulo = titulo;
            Feito = false;
            Data = data;
            Usuario = usuario;
        }

        public void MarcarComoConcluida()
        {
            Feito = true;
        }

        public void MarcarComoNaoConcluida()
        {
            Feito = false;
        }

        public void ModificarTitulo(string titulo)
        {
            Titulo = titulo;
        }
    }
}
