namespace LibraryApi.Domain.Entities;

public class Review : BaseEntity
{
    public string Content { get; set; } = string.Empty;

    public int Rating { get; set; } // 1-5 arası

    public Guid BookId { get; set; }
    public Book Book { get; set; }

    public string UserId { get; set; }
    public AppUser User { get; set; }
}
