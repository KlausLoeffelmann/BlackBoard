using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlackBoardDataAccess
{
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
}
