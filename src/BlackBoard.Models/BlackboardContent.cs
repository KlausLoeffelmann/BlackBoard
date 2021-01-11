using System;

namespace BlackboardWebApi.Model
{
    public class BlackboardContent
    {
        public string BlackboardId { get; set; }
        public string UserId { get; set; }
        public DateTime ContentDate { get; set; }
        public DateTime DateContent { get; set; }
        public string Content { get; set; }
    }
}
