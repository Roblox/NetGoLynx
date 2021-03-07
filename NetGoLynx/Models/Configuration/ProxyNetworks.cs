﻿namespace NetGoLynx.Models.Configuration
{
    /// <summary>
    /// Model for proxy network configuration
    /// </summary>
    public class ProxyNetworks
    {
        /// <summary>
        /// The allowed values from x-forwarded-host. If the list is empty then all hosts
        /// are allowed. Failing to restrict this these values may allow an attacker to spoof
        /// links generated by your service.
        /// </summary>
        /// <remarks>
        /// • Port numbers must be excluded.
        /// • A top level wildcard "*" allows all non-empty hosts.
        /// • Subdomain wildcards are permitted. E.g. "*.example.com" matches subdomains
        /// like foo.example.com, but not the parent domain example.com.
        /// • Unicode host names are allowed but will be converted to punycode for matching.
        /// • IPv6 addresses must include their bounding brackets and be in their normalized
        /// form.
        /// </remarks>
        public string[] AllowedHosts { get; set; } = System.Array.Empty<string>();
    }
}