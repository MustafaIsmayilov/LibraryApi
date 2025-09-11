namespace LibraryApi.Application.Dtos.BorrowRecordDtos;

public class BorrowRecordUpdateDto
{
    public Guid Id { get; set; }
    public DateTime? ReturnDate { get; set; }
}
