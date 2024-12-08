using Application;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infrastructures;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly AppDbContext _dbContext;
    private IDbContextTransaction? _transaction = null;

    public UnitOfWork(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task BeginTransactionAsync()
    {
        _transaction = await _dbContext.Database.BeginTransactionAsync();
    }

    public async Task CommitTransactionAsync()
    {
        if(_transaction != null)
        {
            await _transaction.CommitAsync();
            await _transaction.DisposeAsync();
        }
    }

    public  void Dispose()
    {
        _dbContext.Dispose(); 
        GC.SuppressFinalize(this);
    }

    public async Task RollbackTransactionAsync()
    {
        if(_transaction != null)
        {
            await _transaction.RollbackAsync();
            await _transaction.DisposeAsync();
        }
    }

    public async Task<int> SaveChanges()
    {
        return await _dbContext.SaveChangesAsync();
    }
}