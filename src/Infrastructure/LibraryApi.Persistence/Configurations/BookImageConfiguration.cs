using LibraryApi.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Persistence.Configurations;

public class BookImageConfiguration : IEntityTypeConfiguration<BookImage>
{
    public void Configure(EntityTypeBuilder<BookImage> builder)
    {
        builder.Property(i => i.ImageUrl)
            .IsRequired();

        builder.HasOne(i => i.Book)
            .WithMany(b => b.Images)
            .HasForeignKey(i => i.BookId);
    }
}
