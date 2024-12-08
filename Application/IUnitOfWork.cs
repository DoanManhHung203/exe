namespace Application;

public interface IUnitOfWork
{
    Task<int> SaveChanges();

    Task BeginTransactionAsync();

    Task CommitTransactionAsync();

    Task RollbackTransactionAsync();
}