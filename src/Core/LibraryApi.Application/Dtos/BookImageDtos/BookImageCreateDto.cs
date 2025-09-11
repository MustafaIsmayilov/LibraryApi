namespace LibraryApi.Application.Dtos.BookImageDtos;

public class BookImageCreateDto
{
    public string ImageUrl { get; set; }
    public Guid BookId { get; set; }
    public bool IsMain { get; set; }
}
