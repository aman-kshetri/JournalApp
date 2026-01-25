using SQLite;

namespace JournalApp.Models;

public class JournalEntry
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    // Enforces ONE entry per day
    [Unique]
    [Indexed]
    public DateTime EntryDate { get; set; }

    [NotNull]
    public string Title { get; set; } = string.Empty;

    [NotNull]
    public string Content { get; set; } = string.Empty;

    // Mood references
    [Indexed]
    public int PrimaryMoodId { get; set; }

    public int? SecondaryMoodId1 { get; set; }
    public int? SecondaryMoodId2 { get; set; }

    // Category like Work, Health
    [Indexed]
    public string Category { get; set; } = string.Empty;

    // Analytics
    public int WordCount { get; set; }

    [Indexed]
    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
