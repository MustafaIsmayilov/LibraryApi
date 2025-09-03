using LibraryApi.Application.Abstracts.Repositories;
using LibraryApi.Domain.Entities;
using LibraryApi.Persistence.Contexts;

namespace LibraryApi.Persistence.Repositories;

public class ReviewRepository : GenericRepository<Review>, IReviewRepository
{
    public ReviewRepository(LibraryDbContext context) : base(context)
    {
    }
}
