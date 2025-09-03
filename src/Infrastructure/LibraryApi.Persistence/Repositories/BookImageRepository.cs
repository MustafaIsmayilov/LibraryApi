using LibraryApi.Application.Abstracts.Repositories;
using LibraryApi.Domain.Entities;
using LibraryApi.Persistence.Contexts;

namespace LibraryApi.Persistence.Repositories;

public class BookImageRepository : GenericRepository<BookImage>, IBookImageRepository
{
    public BookImageRepository(LibraryDbContext context) : base(context)
    {
    }
}
