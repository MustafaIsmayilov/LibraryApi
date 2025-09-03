using LibraryApi.Application.Abstracts.Repositories;
using LibraryApi.Domain.Entities;
using LibraryApi.Persistence.Contexts;

namespace LibraryApi.Persistence.Repositories;

public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
{
    public AuthorRepository(LibraryDbContext context) : base(context)
    {
    }
}
