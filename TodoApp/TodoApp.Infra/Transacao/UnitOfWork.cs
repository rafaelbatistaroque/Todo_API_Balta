using TodoApp.Dominio.Repositorios;
using TodoApp.Infra.Contexts;

namespace TodoApp.Infra.Transacao
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _bd;

        public UnitOfWork(DataContext bd)
        {
            _bd = bd;
        }

        public void Commit()
        {
            _bd.SaveChanges();
        }

        public void Rollback()
        {
            //
        }
    }
}
