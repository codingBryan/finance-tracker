

namespace Finance_Tracker
{
    public static class Constants
    {
        public const string DatabaseFileName = "FinanceTracker.db3";
        public const SQLite.SQLiteOpenFlags Flags = SQLite.SQLiteOpenFlags.Create | SQLite.SQLiteOpenFlags.ReadWrite | SQLite.SQLiteOpenFlags.SharedCache;
        public static string DatabasePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),DatabaseFileName);

    }
}
