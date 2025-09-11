namespace LibraryApi.Application.Dtos.BookDtos;

public class BookUpdateDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Guid AuthorId { get; set; }
    public Guid CategoryId { get; set; }
    public bool IsAvailable { get; set; }
}
