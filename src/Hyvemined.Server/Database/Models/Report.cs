using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Hyvemined.Server.Models.Enums;

namespace Hyvemined.Server.Database.Models
{
    public class Report
    {   
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FriendlyId { get; set; } = null!;
        [Required]
        public string Feed { get; set; } = null!;
        [Required]
        public string Ioc { get; set; } = null!;

        public IocType IocType { get; set; } = IocType.INVALID;

        public ReportType ReportType { get; set; } = ReportType.Api;

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Updated { get; set; }

        public TimeSpan Delta { get; set; }

        public List<ReportField> ExtractedFields { get; set; } = new List<ReportField>();

        public List<ReportField> ComputedFields { get; set; } = new List<ReportField>();

        public List<ReportField> UserDefinedFields { get; set; } = new List<ReportField>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public ICollection<ChangelogEntity> Changelog { get; set; } = new List<ChangelogEntity>();

        public Dictionary<string, JsonElement>? RawReport { get; set; }

        public Guid? SummaryId { get; set; }

        public Summary? Summary { get; set; }
    }

    public partial class ReportField
    {
        public string? Name { get; set; }

        public string? Value { get; set; }

        public ReportFieldType FieldType { get; set; }
    }
}
