using System.Linq.Expressions;
using global::LibraryApi.Application.Abstracts.Repositories;
using global::LibraryApi.Domain.Entities;
using LibraryApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Persistence.Repositories;

public class GenericRepository<T> : IRepository<T> where T : BaseEntity, new()
{
    private readonly LibraryDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(LibraryDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public IQueryable<T> GetByFiltered(
        Expression<Func<T, bool>> predicate,
        Expression<Func<T, object>>[]? include = null,
        bool isTracking = false)
    {
        IQueryable<T> query = _dbSet.Where(predicate);

        if (include is not null)
        {
            foreach (var inc in include)
                query = query.Include(inc);
        }

        if (!isTracking)
            query = query.AsNoTracking();

        return query;
    }

    public IQueryable<T> GetAll(bool isTracking = false)
    {
        return isTracking ? _dbSet : _dbSet.AsNoTracking();
    }

    public IQueryable<T> GetAllFiltered(
        Expression<Func<T, bool>> predicate,
        Expression<Func<T, object>>[]? include = null,
        Expression<Func<T, object>>? orderBy = null,
        bool isOrderByAsc = true,
        bool isTracking = false)
    {
        IQueryable<T> query = _dbSet.Where(predicate);

        if (include is not null)
        {
            foreach (var inc in include)
                query = query.Include(inc);
        }

        if (orderBy is not null)
        {
            query = isOrderByAsc
                ? query.OrderBy(orderBy)
                : query.OrderByDescending(orderBy);
        }

        if (!isTracking)
            query = query.AsNoTracking();

        return query;
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public async Task SaveChangeAsync()
    {
        await _context.SaveChangesAsync();
    }
}

