using SQLite;

namespace JournalApp.Models;

public class Tags
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [Unique]
    [NotNull]
    public string Name { get; set; } = string.Empty;
}
