/*
 * eHelply SDK - 1.1.114
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.114
 * Contact: support@ehelply.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Ehelply.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITagApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Deletetag
        /// </summary>
        /// <remarks>
        /// Deletes the tag member with the given ID and returns True if successful
        /// </remarks>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagUuid"></param>
        /// <param name="xAccessToken"> (optional)</param>
        /// <param name="xSecretToken"> (optional)</param>
        /// <param name="authorization"> (optional)</param>
        /// <param name="ehelplyActiveParticipant"> (optional)</param>
        /// <param name="ehelplyProject"> (optional)</param>
        /// <param name="ehelplyData"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Object</returns>
        Object DeleteTag(string tagUuid, string xAccessToken = default(string), string xSecretToken = default(string), string authorization = default(string), string ehelplyActiveParticipant = default(string), string ehelplyProject = default(string), string ehelplyData = default(string), int operationIndex = 0);

        /// <summary>
        /// Deletetag
        /// </summary>
        /// <remarks>
        /// Deletes the tag member with the given ID and returns True if successful
        /// </remarks>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagUuid"></param>
        /// <param name="xAccessToken"> (optional)</param>
        /// <param name="xSecretToken"> (optional)</param>
        /// <param name="authorization"> (optional)</param>
        /// <param name="ehelplyActiveParticipant"> (optional)</param>
        /// <param name="ehelplyProject"> (optional)</param>
        /// <param name="ehelplyData"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DeleteTagWithHttpInfo(string tagUuid, string xAccessToken = default(string), string xSecretToken = default(string), string authorization = default(string), string ehelplyActiveParticipant = default(string), string ehelplyProject = default(string), string ehelplyData = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITagApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Deletetag
        /// </summary>
        /// <remarks>
        /// Deletes the tag member with the given ID and returns True if successful
        /// </remarks>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagUuid"></param>
        /// <param name="xAccessToken"> (optional)</param>
        /// <param name="xSecretToken"> (optional)</param>
        /// <param name="authorization"> (optional)</param>
        /// <param name="ehelplyActiveParticipant"> (optional)</param>
        /// <param name="ehelplyProject"> (optional)</param>
        /// <param name="ehelplyData"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DeleteTagAsync(string tagUuid, string xAccessToken = default(string), string xSecretToken = default(string), string authorization = default(string), string ehelplyActiveParticipant = default(string), string ehelplyProject = default(string), string ehelplyData = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletetag
        /// </summary>
        /// <remarks>
        /// Deletes the tag member with the given ID and returns True if successful
        /// </remarks>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagUuid"></param>
        /// <param name="xAccessToken"> (optional)</param>
        /// <param name="xSecretToken"> (optional)</param>
        /// <param name="authorization"> (optional)</param>
        /// <param name="ehelplyActiveParticipant"> (optional)</param>
        /// <param name="ehelplyProject"> (optional)</param>
        /// <param name="ehelplyData"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTagWithHttpInfoAsync(string tagUuid, string xAccessToken = default(string), string xSecretToken = default(string), string authorization = default(string), string ehelplyActiveParticipant = default(string), string ehelplyProject = default(string), string ehelplyData = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITagApi : ITagApiSync, ITagApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TagApi : ITagApi
    {
        private Ehelply.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TagApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TagApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TagApi(string basePath)
        {
            this.Configuration = Ehelply.Sdk.Client.Configuration.MergeConfigurations(
                Ehelply.Sdk.Client.GlobalConfiguration.Instance,
                new Ehelply.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Ehelply.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ehelply.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Ehelply.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TagApi(Ehelply.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Ehelply.Sdk.Client.Configuration.MergeConfigurations(
                Ehelply.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Ehelply.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ehelply.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Ehelply.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TagApi(Ehelply.Sdk.Client.ISynchronousClient client, Ehelply.Sdk.Client.IAsynchronousClient asyncClient, Ehelply.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Ehelply.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Ehelply.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Ehelply.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Ehelply.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Ehelply.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Deletetag Deletes the tag member with the given ID and returns True if successful
        /// </summary>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagUuid"></param>
        /// <param name="xAccessToken"> (optional)</param>
        /// <param name="xSecretToken"> (optional)</param>
        /// <param name="authorization"> (optional)</param>
        /// <param name="ehelplyActiveParticipant"> (optional)</param>
        /// <param name="ehelplyProject"> (optional)</param>
        /// <param name="ehelplyData"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Object</returns>
        public Object DeleteTag(string tagUuid, string xAccessToken = default(string), string xSecretToken = default(string), string authorization = default(string), string ehelplyActiveParticipant = default(string), string ehelplyProject = default(string), string ehelplyData = default(string), int operationIndex = 0)
        {
            Ehelply.Sdk.Client.ApiResponse<Object> localVarResponse = DeleteTagWithHttpInfo(tagUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Deletetag Deletes the tag member with the given ID and returns True if successful
        /// </summary>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagUuid"></param>
        /// <param name="xAccessToken"> (optional)</param>
        /// <param name="xSecretToken"> (optional)</param>
        /// <param name="authorization"> (optional)</param>
        /// <param name="ehelplyActiveParticipant"> (optional)</param>
        /// <param name="ehelplyProject"> (optional)</param>
        /// <param name="ehelplyData"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object</returns>
        public Ehelply.Sdk.Client.ApiResponse<Object> DeleteTagWithHttpInfo(string tagUuid, string xAccessToken = default(string), string xSecretToken = default(string), string authorization = default(string), string ehelplyActiveParticipant = default(string), string ehelplyProject = default(string), string ehelplyData = default(string), int operationIndex = 0)
        {
            // verify the required parameter 'tagUuid' is set
            if (tagUuid == null)
            {
                throw new Ehelply.Sdk.Client.ApiException(400, "Missing required parameter 'tagUuid' when calling TagApi->DeleteTag");
            }

            Ehelply.Sdk.Client.RequestOptions localVarRequestOptions = new Ehelply.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ehelply.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ehelply.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("tag_uuid", Ehelply.Sdk.Client.ClientUtils.ParameterToString(tagUuid)); // path parameter
            if (xAccessToken != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-access-token", Ehelply.Sdk.Client.ClientUtils.ParameterToString(xAccessToken)); // header parameter
            }
            if (xSecretToken != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-secret-token", Ehelply.Sdk.Client.ClientUtils.ParameterToString(xSecretToken)); // header parameter
            }
            if (authorization != null)
            {
                localVarRequestOptions.HeaderParameters.Add("authorization", Ehelply.Sdk.Client.ClientUtils.ParameterToString(authorization)); // header parameter
            }
            if (ehelplyActiveParticipant != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ehelply-active-participant", Ehelply.Sdk.Client.ClientUtils.ParameterToString(ehelplyActiveParticipant)); // header parameter
            }
            if (ehelplyProject != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ehelply-project", Ehelply.Sdk.Client.ClientUtils.ParameterToString(ehelplyProject)); // header parameter
            }
            if (ehelplyData != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ehelply-data", Ehelply.Sdk.Client.ClientUtils.ParameterToString(ehelplyData)); // header parameter
            }

            localVarRequestOptions.Operation = "TagApi.DeleteTag";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/places/tags/{tag_uuid}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteTag", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deletetag Deletes the tag member with the given ID and returns True if successful
        /// </summary>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagUuid"></param>
        /// <param name="xAccessToken"> (optional)</param>
        /// <param name="xSecretToken"> (optional)</param>
        /// <param name="authorization"> (optional)</param>
        /// <param name="ehelplyActiveParticipant"> (optional)</param>
        /// <param name="ehelplyProject"> (optional)</param>
        /// <param name="ehelplyData"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteTagAsync(string tagUuid, string xAccessToken = default(string), string xSecretToken = default(string), string authorization = default(string), string ehelplyActiveParticipant = default(string), string ehelplyProject = default(string), string ehelplyData = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ehelply.Sdk.Client.ApiResponse<Object> localVarResponse = await DeleteTagWithHttpInfoAsync(tagUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Deletetag Deletes the tag member with the given ID and returns True if successful
        /// </summary>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagUuid"></param>
        /// <param name="xAccessToken"> (optional)</param>
        /// <param name="xSecretToken"> (optional)</param>
        /// <param name="authorization"> (optional)</param>
        /// <param name="ehelplyActiveParticipant"> (optional)</param>
        /// <param name="ehelplyProject"> (optional)</param>
        /// <param name="ehelplyData"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Ehelply.Sdk.Client.ApiResponse<Object>> DeleteTagWithHttpInfoAsync(string tagUuid, string xAccessToken = default(string), string xSecretToken = default(string), string authorization = default(string), string ehelplyActiveParticipant = default(string), string ehelplyProject = default(string), string ehelplyData = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'tagUuid' is set
            if (tagUuid == null)
            {
                throw new Ehelply.Sdk.Client.ApiException(400, "Missing required parameter 'tagUuid' when calling TagApi->DeleteTag");
            }


            Ehelply.Sdk.Client.RequestOptions localVarRequestOptions = new Ehelply.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ehelply.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ehelply.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("tag_uuid", Ehelply.Sdk.Client.ClientUtils.ParameterToString(tagUuid)); // path parameter
            if (xAccessToken != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-access-token", Ehelply.Sdk.Client.ClientUtils.ParameterToString(xAccessToken)); // header parameter
            }
            if (xSecretToken != null)
            {
                localVarRequestOptions.HeaderParameters.Add("x-secret-token", Ehelply.Sdk.Client.ClientUtils.ParameterToString(xSecretToken)); // header parameter
            }
            if (authorization != null)
            {
                localVarRequestOptions.HeaderParameters.Add("authorization", Ehelply.Sdk.Client.ClientUtils.ParameterToString(authorization)); // header parameter
            }
            if (ehelplyActiveParticipant != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ehelply-active-participant", Ehelply.Sdk.Client.ClientUtils.ParameterToString(ehelplyActiveParticipant)); // header parameter
            }
            if (ehelplyProject != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ehelply-project", Ehelply.Sdk.Client.ClientUtils.ParameterToString(ehelplyProject)); // header parameter
            }
            if (ehelplyData != null)
            {
                localVarRequestOptions.HeaderParameters.Add("ehelply-data", Ehelply.Sdk.Client.ClientUtils.ParameterToString(ehelplyData)); // header parameter
            }

            localVarRequestOptions.Operation = "TagApi.DeleteTag";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/places/tags/{tag_uuid}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteTag", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
