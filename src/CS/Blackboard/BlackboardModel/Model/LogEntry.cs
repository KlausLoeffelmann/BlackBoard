using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlackBoard.Model
{
    public class LogEntry
    {
        [Key]
        public Guid LogEntryId { get; set; }

        [AllowNull]
        public User User { get; set; }

        public DateTimeOffset LogTime { get; set; }

        [MaxLength(100)]
        public string? LogInfo { get; set; }
    }
}
