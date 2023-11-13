using Hyvemined.Core.Models.Enums;

namespace Hyvemined.Core.Models.Configs
{
    public class FeedConnectorConfig
    {
        public required string FeedName { get; set; }

        public required Uri Url { get; set; }

        public required List<IocType> AllowedIocTypes { get; set; }
    }
}
