using System;
using System.Diagnostics.CodeAnalysis;

namespace TodoApp.Dominio.Entidades
{
    public abstract class Entidade : IEquatable<Entidade>
    {
        public Guid Id { get; private set; }

        protected Entidade()
        {
            Id = Guid.NewGuid();
        }

        public bool Equals([AllowNull] Entidade other)
        {
            return Id == other.Id;
        }
    }
}
