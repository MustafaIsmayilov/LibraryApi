namespace LibraryApi.Domain.Entities;

public class Author : BaseEntity
{
    public string FullName { get; set; }

    // Bir müəllifin bir çox kitabı ola bilər
    public ICollection<Book> Books { get; set; } = new List<Book>();
}

