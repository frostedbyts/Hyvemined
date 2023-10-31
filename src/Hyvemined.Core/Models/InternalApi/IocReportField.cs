using Hyvemined.Core.Models.Enums;
namespace Hyvemined.Core.Models.InternalApi
{
    public class IocReportField
    {
        public string? Name { get; set; }

        public string? Value { get; set; }

        public ReportFieldType FieldType { get; set; }
    }
}
