using LibraryApi.Application.Abstracts.Repositories;
using LibraryApi.Domain.Entities;
using LibraryApi.Persistence.Contexts;

namespace LibraryApi.Persistence.Repositories;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(LibraryDbContext context) : base(context)
    {
    }
}
