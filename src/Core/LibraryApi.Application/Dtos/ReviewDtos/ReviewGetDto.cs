namespace LibraryApi.Application.Dtos.ReviewDtos;

public class ReviewGetDto
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public int Rating { get; set; }

    public Guid BookId { get; set; }
    public string BookTitle { get; set; }

    public string UserId { get; set; }
    public string UserFullName { get; set; }
}
