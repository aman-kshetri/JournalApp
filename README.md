# Journal App

A cross-platform personal journaling app built with **.NET MAUI Blazor Hybrid**.  
It supports secure local access with PIN lock, daily journal writing, mood tracking, tags, analytics, and PDF export.

## Features

- 🔐 4-digit PIN lock for local app access
- ✍️ Rich-text journal editor with daily entries
- 😊 Mood selection (primary + specific feelings)
- 🏷️ Prebuilt and custom tags
- 📅 Calendar and list views of entries
- 🔎 Search entries by content, tags, or mood
- 📊 Insights dashboard (streaks, mood distribution, word trends, top tags)
- 📄 Export selected entries to password-protected PDF
- 🌙 Light/Dark theme toggle

## Tech Stack

- .NET 9
- .NET MAUI (Blazor Hybrid)
- Razor Components
- SQLite (`sqlite-net-pcl`) for local data
- PdfSharpCore for PDF generation
- Markdig (available as dependency)

## Getting Started

### Prerequisites

- .NET 9 SDK
- MAUI workload installed:

```bash
dotnet workload install maui
```

- Platform-specific requirements:
  - **Windows:** Visual Studio 2022 with MAUI support (or required build tools)
  - **Android/iOS/macOS:** corresponding SDK/toolchain setup

### Build

```bash
dotnet build /home/runner/work/JournalApp/JournalApp/journal-app.csproj
```

### Run

Choose a target framework from the project file:

- `net9.0-android`
- `net9.0-ios`
- `net9.0-maccatalyst`
- `net9.0-windows10.0.19041.0` (on Windows)

Example (Windows):

```bash
dotnet run --project /home/runner/work/JournalApp/JournalApp/journal-app.csproj -f net9.0-windows10.0.19041.0
```

## Project Structure

```text
JournalApp/
├── Components/          # UI pages, layout, routing, login overlay
├── Data/                # SQLite database initialization and seeding
├── Models/              # Journal, mood, tag, and user models
├── Services/            # Business/data services and PDF export service
├── Platforms/           # Platform-specific MAUI startup/config
├── Resources/           # App icons, splash, fonts, images, assets
├── wwwroot/             # Blazor web assets and JS helpers
└── journal-app.csproj   # Project configuration and dependencies
```

## Data & Security Notes

- Data is stored locally in a SQLite database under app data storage.
- First launch prompts for a 4-digit PIN setup.
- PDF exports can optionally be password protected.

## Future Improvements

- Cloud sync/backup
- Stronger PIN security (hashing/salting)
- Automated tests

