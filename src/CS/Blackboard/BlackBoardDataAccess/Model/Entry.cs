using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlackBoardDataAccess
{
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
}
