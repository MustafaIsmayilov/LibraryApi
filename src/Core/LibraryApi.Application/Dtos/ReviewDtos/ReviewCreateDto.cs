namespace LibraryApi.Application.Dtos.ReviewDtos;

public class ReviewCreateDto
{
    public string Content { get; set; }
    public int Rating { get; set; }
    public Guid BookId { get; set; }
    public string UserId { get; set; }
}
