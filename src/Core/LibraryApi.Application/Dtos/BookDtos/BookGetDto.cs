namespace LibraryApi.Application.Dtos.BookDtos;

public class BookGetDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public bool IsAvailable { get; set; }

    public Guid AuthorId { get; set; }
    public string AuthorName { get; set; }

    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; }
}
