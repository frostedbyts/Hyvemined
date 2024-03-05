using System.ComponentModel.DataAnnotations;
using Hyvemined.Server.Models.Enums.Jobs;

namespace Hyvemined.Server.Database.Models
{
    public class Job
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FriendlyId { get; set; } = null!;

        public JobState State { get; set; }

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Started { get; set; }

        public DateTimeOffset Completed { get; set; }

        public string? Error { get; set; }

        public Guid? ResultId { get; set; }

        public string? Command { get; set; }

        public string? Arguments { get; set; }
    }
}
