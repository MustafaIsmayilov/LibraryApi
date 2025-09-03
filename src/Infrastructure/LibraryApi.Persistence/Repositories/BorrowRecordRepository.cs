using LibraryApi.Application.Abstracts.Repositories;
using LibraryApi.Domain.Entities;
using LibraryApi.Persistence.Contexts;

namespace LibraryApi.Persistence.Repositories;

public class BorrowRecordRepository : GenericRepository<BorrowRecord>, IBorrowRecordRepository
{
    public BorrowRecordRepository(LibraryDbContext context) : base(context)
    {
    }
}
