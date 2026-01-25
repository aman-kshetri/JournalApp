using SQLite;

namespace JournalApp.Models;

public class User
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    // Store HASHED pin (never plain)
    [NotNull]
    public string PinHash { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
}
