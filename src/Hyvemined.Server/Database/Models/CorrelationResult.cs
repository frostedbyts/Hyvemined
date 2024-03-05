using System.ComponentModel.DataAnnotations;
using Hyvemined.Server.Models.Enums;

namespace Hyvemined.Server.Database.Models
{
    public class CorrelationResult
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string CorrelationName { get; set; } = null!;
        [Required]
        public bool Matched { get; set; }
        [Required]
        public int AssignedScore { get; set; }
        [Required]
        public ThreatSeverity AssignedRisk { get; set; }

        public List<string> AssignedTags { get; set; } = new List<string>();

        public List<CorrelationResultAction>  Actions { get; set; } = new List<CorrelationResultAction>();

        public Guid? SummaryId { get; set; }

        public Summary? Summary { get; set; }
    }

    public partial class CorrelationResultAction
    {
        public CorrelationActionType ActionType { get; set; }

        public string? Target { get; set; }

        public string? Input { get; set; }

        public string? Output { get; set; }
    }
}
