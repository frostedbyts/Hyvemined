using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using Hyvemined.Server.Models.Enums;

namespace Hyvemined.Server.Utils
{
    public static class IocTypeValidator
    {
        private static string MD5_REGEX = @"(?:[^a-fA-F\d]|\b)([a-fA-F\d]{32})(?:[^a-fA-F\d]|\b)";
        private static string SHA1_REGEX = @"(?:[^a-fA-F\d]|\b)([a-fA-F\d]{40})(?:[^a-fA-F\d]|\b)";
        private static string SHA256_REGEX = @"(?:[^a-fA-F\d]|\b)([a-fA-F\d]{64})(?:[^a-fA-F\d]|\b)";
        private static string SHA512_REGEX = @"(?:[^a-fA-F\d]|\b)([a-fA-F\d]{128})(?:[^a-fA-F\d]|\b)";
        public static bool IsValidIpv4(this string ioc)
        {
            IPAddress? ip;
            bool valid = IPAddress.TryParse(ioc, out ip);
            if(valid && !IPAddress.IsLoopback(ip!) && ip!.AddressFamily == AddressFamily.InterNetwork)
            {
                byte[] ipBytes = ip!.GetAddressBytes();
                switch(ipBytes[0])
                {
                    case 127:
                    case 169:
                    case 10:
                        return false;
                    case 192:
                        return ipBytes[1] != 168;
                    case 172:
                        return ipBytes[1] < 16 || ipBytes[1] > 31;   
                    default:
                        break;
                }
            }
            return valid;
        }

        public static bool IsValidIpv6(this string ioc)
        {
            IPAddress? ip;
            return IPAddress.TryParse(ioc, out ip) && ip!.AddressFamily == AddressFamily.InterNetworkV6 && !ip!.IsIPv6UniqueLocal && !ip!.IsIPv6SiteLocal; 
        }

        public static bool IsValidUrl(this string ioc)
        {
            Uri? url;
            return Uri.TryCreate(ioc, UriKind.Absolute, out url);
        }

        public static bool IsValidDomain(this string ioc)
        {
            return !ioc.IsValidIpv4() && !ioc.IsValidIpv6() && Uri.CheckHostName(ioc) == UriHostNameType.Dns;
        }

        public static bool IsValidEmail(this string ioc)
        {
            try
            {
                MailAddress temp = new MailAddress(ioc);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidMd5(this string ioc)
        {
            return Regex.IsMatch(ioc, MD5_REGEX);
        }

        public static bool IsValidSha1(this string ioc)
        {
            return Regex.IsMatch(ioc, SHA1_REGEX);
        }

        public static bool IsValidSha256(this string ioc)
        {
            return Regex.IsMatch(ioc, SHA256_REGEX);
        }

        public static bool IsValidSha512(this string ioc)
        {
            return Regex.IsMatch(ioc, SHA512_REGEX);
        }

        public static bool IsValidIoc(this string ioc)
        {
            return ioc.IsValidIpv4()
            || ioc.IsValidIpv6()
            || ioc.IsValidEmail()
            || ioc.IsValidUrl()
            || ioc.IsValidDomain()
            || ioc.IsValidMd5()
            || ioc.IsValidSha1()
            || ioc.IsValidSha256()
            || ioc.IsValidSha512();
        }

        public static IocType GetIocType(this string ioc)
        {
            if(ioc.IsValidIoc())
            {
                if(ioc.IsValidIpv4())
                    return IocType.IPV4;
                else if(ioc.IsValidIpv6())
                    return IocType.IPV6;
                else if(ioc.IsValidEmail())
                    return IocType.EMAIL;
                else if(ioc.IsValidUrl())
                    return IocType.URL;
                else if(ioc.IsValidDomain())
                    return IocType.DOMAIN;
                else if(ioc.IsValidMd5())
                    return IocType.MD5;
                else if(ioc.IsValidSha1())
                    return IocType.SHA1;
                else if(ioc.IsValidSha256())
                    return IocType.SHA256;
                else if(ioc.IsValidSha512())
                    return IocType.SHA512;
            }
            return IocType.INVALID;
        }

        public static IocType GetIocTypeFromString(this string str) => str switch
        {
            "IPV4" => IocType.IPV4,
            "IPV6" => IocType.IPV6,
            "EMAIL" => IocType.EMAIL,
            "URL" => IocType.URL,
            "DOMAIN" => IocType.DOMAIN,
            "MD5" => IocType.MD5,
            "SHA1" => IocType.SHA1,
            "SHA256" => IocType.SHA256,
            "SHA512" => IocType.SHA512,
            _ => IocType.INVALID
        };

        public static string GetIocTypeString(IocType type) => type switch
        {
            IocType.IPV4 => "IPV4",
            IocType.IPV6 => "IPV6",
            IocType.EMAIL => "EMAIL",
            IocType.URL => "URL",
            IocType.DOMAIN => "DOMAIN",
            IocType.MD5 => "MD5",
            IocType.SHA1 => "SHA1",
            IocType.SHA256 => "SHA256",
            IocType.SHA512 => "SHA512",
            _ => "INVALID"
        };

        public static string GetIocTypeString(this string ioc)
        {
            IocType iocType = ioc.GetIocType();
            switch(iocType)
            {
                case IocType.IPV4:
                    return "IPV4";
                case IocType.IPV6:
                    return "IPV6";
                case IocType.EMAIL:
                    return "EMAIL";
                case IocType.URL:
                    return "URL";
                case IocType.DOMAIN:
                    return "DOMAIN";
                case IocType.MD5:
                    return "MD5";
                case IocType.SHA1:
                    return "SHA1";
                case IocType.SHA256:
                    return "SHA256";
                case IocType.SHA512:
                    return "SHA512";
                default:
                    return "INVALID";
            }
        }
    }
}
