using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlackBoardDataAccess
{
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
}
