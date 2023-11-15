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

        public FeedConnectorDownloadConfig? FeedUpdateConfig { get; set; }

        public Dictionary<IocType, Uri>? AlternateEndpoints { get; set; }

        public ConnectorAuthenticationConfig? Authentication { get; set; }

        public List<FieldExtractorConfig>? FieldExtractors { get; set; }

        public List<ComputedFieldConfig>? ComputedFields { get; set; }
    }

    public class FeedConnectorDownloadConfig
    {
        public TimeSpan? UpdateInterval { get; set; }

        public int? EveryNDays { get; set; }

        public int? EveryNHours { get; set; }

        public int? EveryNMinutes { get; set; }

        public int? EveryNSeconds { get; set; }
    }

    public class ConnectorAuthenticationConfig 
    {
        public TokenAuthentication? TokenAuth { get; set; }

        public BasicAuthentication? BasicAuth { get; set; }

        public BearerAuthentication? BearerAuth { get; set; }

        public OAuth2Authentication? OAuth2 { get; set; }
    }

    public class TokenAuthentication
    {
        public string? Key { get; set; }

        public string? Token { get; set; }

        public AuthenticationCredentialLocation CredentialLocation { get; set; }
    }

    public class BasicAuthentication 
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }

    public class BearerAuthentication
    {
        public string? Token { get; set; }

        public string? Prefix { get; set; }
    }

    public class OAuth2Authentication 
    {
        public OAuth2GrantType GrantType { get; set; }

        public Uri? AuthorizationUrl { get; set; }

        public Uri? AccessTokenUrl { get; set; }

        public Uri? RedirectUrl { get; set; }

        public AuthenticationCredentialLocation CredentialLocation { get; set; }

        public string? ClientId { get; set; }

        public string? ClientSecret { get; set; }

        public bool UsePkce { get; set; }

        public OAuth2CodeChallengeType ChallengeMethod { get; set; }

        public OAuth2ImplicitResponseType ImplicitResponseType { get; set; }

        public string? Scope { get; set; }

        public string? HeaderPrefix { get; set; }

        public string? Audience { get; set; }

        public string? Resource { get; set; }

        public string? Origin { get; set; }
    }

    public class FieldExtractorConfig
    {
        public string? TargetField { get; set; }

        public string? OutputFieldName { get; set; }
    }

    public class ComputedFieldConfig
    {
        public List<string>? TargetFields { get; set; }

        public string? ComputeFunction { get; set; }

        public string? OutputFieldName { get; set; }
    }
}
