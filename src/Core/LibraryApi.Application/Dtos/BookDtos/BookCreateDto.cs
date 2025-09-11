namespace LibraryApi.Application.Dtos.BookDtos;

public class BookCreateDto
{
    public string Title { get; set; }
    public Guid AuthorId { get; set; }
    public Guid CategoryId { get; set; }
}
