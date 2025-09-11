namespace LibraryApi.Application.Dtos.BorrowRecordDtos;

public class BorrowRecordCreateDto
{
    public Guid BookId { get; set; }
    public string UserId { get; set; }
    public DateTime BorrowDate { get; set; }
}
