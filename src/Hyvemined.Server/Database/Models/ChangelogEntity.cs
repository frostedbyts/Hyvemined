using System.ComponentModel.DataAnnotations;

namespace Hyvemined.Server.Database.Models
{
    public class ChangelogEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FriendlyId { get; set;} = null!;
        [Required]
        public string Username{ get; set; } = null!;
        [Required]
        public string Changed { get; set; } = null!;
        [Required]
        public string OldValue { get; set; } = null!;
        [Required]
        public string NewValue { get; set; } = null!;
        [Required]
        public DateTimeOffset Timestamp { get; set;}

        public Guid? ReportId { get; set; }

        public Report? Report { get; set; }

        public Guid? SummaryId { get; set; }

        public Summary? Summary { get; set; }

        public Guid? CommentId { get; set; }

        public Comment? Comment { get; set; }

    }
}
