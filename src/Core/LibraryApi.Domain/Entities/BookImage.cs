namespace LibraryApi.Domain.Entities;

public class BookImage : BaseEntity
{
    public string ImageUrl { get; set; } = string.Empty;

    public Guid BookId { get; set; }
    public Book Book { get; set; }

    public bool IsMain { get; set; }
}

