using LibraryApi.Domain.Entities;
using LibraryApi.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System;
using LibraryApi.Application.Abstracts.Repositories;

namespace LibraryApi.Persistence.Repositories;

public class Repository<T> : IRepository<T> where T : BaseEntity, new()
{
    private readonly DbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(DbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
    }

    public IQueryable<T> GetByFiltered(
        Expression<Func<T, bool>> predicate,
        Expression<Func<T, object>>[]? include = null,
        bool isTracking = false)
    {
        IQueryable<T> query = _dbSet;

        if (include != null)
        {
            foreach (var inc in include)
            {
                query = query.Include(inc);
            }
        }

        query = query.Where(predicate);

        if (!isTracking)
            query = query.AsNoTracking();

        return query;
    }

    public IQueryable<T> GetAll(bool isTracking = false)
    {
        var query = _dbSet.AsQueryable();

        if (!isTracking)
            query = query.AsNoTracking();

        return query;
    }

    public IQueryable<T?> GetAllFiltered(
        Expression<Func<T, bool>> predicate,
        Expression<Func<T, object>>[]? include = null,
        Expression<Func<T, object>>? orderby = null,
        bool isOrderByAsc = true,
        bool isTracking = false)
    {
        IQueryable<T> query = _dbSet;

        if (include != null)
        {
            foreach (var inc in include)
            {
                query = query.Include(inc);
            }
        }

        query = query.Where(predicate);

        if (orderby != null)
            query = isOrderByAsc ? query.OrderBy(orderby) : query.OrderByDescending(orderby);

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
