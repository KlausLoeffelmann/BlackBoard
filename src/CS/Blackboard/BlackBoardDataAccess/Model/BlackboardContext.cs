using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace BlackBoardDataAccess
{
    public class BlackboardContext : DbContext
    {
        [AllowNull]
        public DbSet<Entry> Entries { get; set; }

        [AllowNull]
        public DbSet<User> Users { get; set; }

        [AllowNull]
        public DbSet<WebLink> WebLinks { get; set; }

        [AllowNull]
        public DbSet<LogEntry> LogEntries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=BlackBoard;");
        }
    }
}
