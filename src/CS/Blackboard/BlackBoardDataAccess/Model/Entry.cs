using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlackBoardDataAccess
{
    public enum Scope
    {
        @private,
        friend,
        @public
    }

    public class Entry
    {
        [Key]
        public Guid EntryId { get; set; }

        [AllowNull]
        public User User { get; set; }
        public Guid EntityId { get; set; }
        public Guid RevisionId { get; set; }
        public int RevisionNo { get; set; }
        
        public bool IsCurrent { get; set; }
        public DateTimeOffset PostingTime { get; set; }
        public string? Content { get; set; }
        public Scope EntryScope { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeLastEdited { get; set; }
    }

    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [AllowNull]
        public string UserIdentityExternal { get; set; }

        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeLastEdited { get; set; }
    }

    public class WebLink
    {
        [Key]
        public Guid WebLinkId { get; set; }

        [AllowNull]
        public User User { get; set; }

        [AllowNull]
        public string Url { get; set; }

        [AllowNull]
        public string Caption { get; set; }
        public string? Note { get; set; }
        public Scope WeblinkScope { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeLastEdited { get; set; }
    }

    public class Log
    {
        [Key]
        public Guid LogId { get; set; }

        [AllowNull]
        public User User { get; set; }
        public DateTimeOffset LogTime { get; set; }

        [MaxLength(100)]
        public string? LogInfo { get; set; }
    }
}
