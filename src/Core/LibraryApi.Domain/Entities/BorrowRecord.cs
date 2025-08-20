namespace LibraryApi.Domain.Entities;

public class BorrowRecord : BaseEntity
{
    public Guid BookId { get; set; }
    public Book Book { get; set; }

    public string UserId { get; set; }
    public AppUser User { get; set; } // Navigation property

    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    // Helper property
    public bool IsReturned => ReturnDate != null;
}
