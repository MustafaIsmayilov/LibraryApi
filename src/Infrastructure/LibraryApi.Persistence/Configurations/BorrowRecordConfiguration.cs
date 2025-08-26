using LibraryApi.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Persistence.Configurations;

public class BorrowRecordConfiguration : IEntityTypeConfiguration<BorrowRecord>
{
    public void Configure(EntityTypeBuilder<BorrowRecord> builder)
    {
        builder.Property(br => br.BorrowDate)
            .IsRequired();

        builder.HasOne(br => br.Book)
            .WithMany(b => b.BorrowRecords)
            .HasForeignKey(br => br.BookId);

        builder.HasOne(br => br.User)
            .WithMany(u => u.BorrowRecords)
            .HasForeignKey(br => br.UserId);
    }
}
