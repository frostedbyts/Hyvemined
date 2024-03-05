using System.ComponentModel.DataAnnotations;

namespace Hyvemined.Server.Database.Models
{
    public class Comment
    {   
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FriendlyId { get; set; } = null!;
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Content { get; set; } = null!;
        [Required]
        public DateTimeOffset Created { get; set; }
        [Required]
        public DateTimeOffset Updated { get; set; }

        public ICollection<ChangelogEntity> Changelog { get; set; } = new List<ChangelogEntity>();

        public Guid? SummaryId { get; set; }

        public Summary? Summary { get; set; }

        public Guid? ReportId { get; set; }

        public Report? Report { get; set; }
    }
}
