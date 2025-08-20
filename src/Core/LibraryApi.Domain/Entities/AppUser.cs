using Microsoft.AspNetCore.Identity;

namespace LibraryApi.Domain.Entities;

public class AppUser:IdentityUser
{
    public string Id { get; set; } // Identity default string id

    public string FullName { get; set; }

    // Bir istifadəçinin bir çox kirayə qeydi ola bilər
    public ICollection<BorrowRecord> BorrowRecords { get; set; } = new List<BorrowRecord>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
