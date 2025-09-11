namespace LibraryApi.Application.Dtos.BookImageDtos;

public class BookImageUpdateDto
{
    public Guid Id { get; set; }
    public string ImageUrl { get; set; }
    public bool IsMain { get; set; }
}
