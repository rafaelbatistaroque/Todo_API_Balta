namespace TodoApp.Dominio.Repositorios
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
