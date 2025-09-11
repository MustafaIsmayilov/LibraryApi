namespace LibraryApi.Application.Dtos.BorrowRecordDtos;

public class BorrowRecordGetDto
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public string BookTitle { get; set; }

    public string UserId { get; set; }
    public string UserFullName { get; set; }

    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public bool IsReturned { get; set; }
}
