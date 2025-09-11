namespace LibraryApi.Application.Dtos.BookImageDtos;

public class BookImageGetDto
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; }
    public Guid BookId { get; set; }
    public bool IsMain { get; set; }
}
