namespace LibraryApi.Domain.Entities;

public class Book : BaseEntity
{
    public string Title { get; set; }

    // Əlaqələr
    public Guid AuthorId { get; set; }
    public Author Author { get; set; }

    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public bool IsAvailable { get; set; } = true;

    // Bir kitab bir çox dəfə kirayə verilə bilər
    public ICollection<BorrowRecord> BorrowRecords { get; set; } = new List<BorrowRecord>();
    public ICollection<BookImage> Images { get; set; } = new List<BookImage>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
