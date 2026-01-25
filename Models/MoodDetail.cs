using SQLite;

namespace JournalApp.Models;

public class MoodDetail
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [NotNull]
    public string Name { get; set; } = string.Empty;

    public string Emoji { get; set; } = string.Empty;

    [Indexed]
    public MoodCategory Category { get; set; }
}
