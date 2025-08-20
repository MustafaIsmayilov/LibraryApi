using LibraryApi.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Persistence.Contexts;

public class LibraryDbContext : IdentityDbContext<AppUser>
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Book> Books{ get; set; }
    public DbSet<BookImage> BookImages { get; set; }
    public DbSet<Author> Authors{ get; set; }
    public DbSet<BorrowRecord> BorrowRecords { get; set; }
    public DbSet<Review> Reviews { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibraryDbContext).Assembly);
    }
}
