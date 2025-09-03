using LibraryApi.Application.Abstracts.Repositories;
using LibraryApi.Domain.Entities;
using LibraryApi.Persistence.Contexts;

namespace LibraryApi.Persistence.Repositories;

public class BookRepository : GenericRepository<Book>, IBookRepository
{
    public BookRepository(LibraryDbContext context) : base(context)
    {
    }
}
