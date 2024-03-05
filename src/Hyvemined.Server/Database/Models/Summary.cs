using System.ComponentModel.DataAnnotations;
using Hyvemined.Server.Models.Enums;

namespace Hyvemined.Server.Database.Models
{
    public class Summary
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FriendlyId { get; set; } = null!;
        [Required]
        public string Ioc { get; set; } = null!;

        public IocType IocType { get; set; }

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset LastUpdated { get; set; }

        public TimeSpan UpdateDelta { get; set; }
        [Required]
        public List<string> Feeds { get; set; } = new List<string>();

        public List<string> Tags { get; set; } = new List<string>();

        public int Score { get; set; }

        public ThreatSeverity Severity { get; set; }
        [Required]
        public ICollection<Report> LinkedReports { get; set; } = new List<Report>();

        public ICollection<CorrelationResult> LinkedCorrelations { get; set; } = new List<CorrelationResult>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public ICollection<ChangelogEntity> Changelog { get; set; } = new List<ChangelogEntity>();
    }
}
