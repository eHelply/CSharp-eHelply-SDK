/*
 * eHelply SDK - 1.1.120
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.120
 * Contact: support@ehelply.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Polly;
using RestSharp;

namespace Ehelply.Sdk.Client
{
    /// <summary>
    /// Configuration class to set the polly retry policies to be applied to the requests.
    /// </summary>
    public static class RetryConfiguration
    {
        /// <summary>
        /// Retry policy
        /// </summary>
        public static Policy<IRestResponse> RetryPolicy { get; set; }

        /// <summary>
        /// Async retry policy
        /// </summary>
        public static AsyncPolicy<IRestResponse> AsyncRetryPolicy { get; set; }
    }
}
