using SQLite;

namespace JournalApp.Models;

public class JournalTag
{
    [Indexed]
    public int JournalEntryId { get; set; }

    [Indexed]
    public int TagId { get; set; }
}
