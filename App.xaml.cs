using JournalApp.Data;

namespace JournalApp;

public partial class App : Application
{
    // Make database globally accessible
    public static DatabaseService Database { get; private set; } = null!;

    public App()
    {
        InitializeComponent();

        InitializeDatabase();
    }

    private async void InitializeDatabase()
    {
        string dbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "MyJournal.db"
        );

        Database = new DatabaseService();
        await Database.InitializeAsync(dbPath);
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage())
        {
            Title = "MyJournal"
        };
    }
}
