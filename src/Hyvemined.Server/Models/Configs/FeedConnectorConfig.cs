using Hyvemined.Server.Models.Enums;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Hyvemined.Server.Models.Configs
{
    public class FeedConnectorConfig
    {
        public string? FeedName { get; set; }

        public Uri? Url { get; set; }

        public List<IocType>? AllowedIocTypes { get; set; }

        public FeedConnectorType ConnectorType { get; set; }

        public Dictionary<IocType, Uri>? AlternateEndpoints { get; set; }
    }

    public class ConnectorAuthenticationConfig 
    {

    }

    public class TokenAuthentication
    {
        public string? Key { get; set; }

        public string? Token { get; set; }
    }

    public class BasicAuthentication 
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
