/*
 * eHelply SDK - 1.1.71
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.71
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
    public interface IAuthApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Reset Password Confirmation
        /// </summary>
        /// <remarks>
        /// Resets the given user&#39;s password to the given password when the proper code is provided
        /// </remarks>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userPasswordResetConfirmation"></param>
        /// <returns>Object</returns>
        Object ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost(UserPasswordResetConfirmation userPasswordResetConfirmation);

        /// <summary>
        /// Reset Password Confirmation
        /// </summary>
        /// <remarks>
        /// Resets the given user&#39;s password to the given password when the proper code is provided
        /// </remarks>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userPasswordResetConfirmation"></param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ResetPasswordConfirmationUsersAuthPasswordResetConfirmPostWithHttpInfo(UserPasswordResetConfirmation userPasswordResetConfirmation);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Reset Password Confirmation
        /// </summary>
        /// <remarks>
        /// Resets the given user&#39;s password to the given password when the proper code is provided
        /// </remarks>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userPasswordResetConfirmation"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ResetPasswordConfirmationUsersAuthPasswordResetConfirmPostAsync(UserPasswordResetConfirmation userPasswordResetConfirmation, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Reset Password Confirmation
        /// </summary>
        /// <remarks>
        /// Resets the given user&#39;s password to the given password when the proper code is provided
        /// </remarks>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userPasswordResetConfirmation"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ResetPasswordConfirmationUsersAuthPasswordResetConfirmPostWithHttpInfoAsync(UserPasswordResetConfirmation userPasswordResetConfirmation, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthApi : IAuthApiSync, IAuthApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthApi : IAuthApi
    {
        private Ehelply.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthApi(Ehelply.Sdk.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuthApi(Ehelply.Sdk.Client.ISynchronousClient client, Ehelply.Sdk.Client.IAsynchronousClient asyncClient, Ehelply.Sdk.Client.IReadableConfiguration configuration)
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
        /// Reset Password Confirmation Resets the given user&#39;s password to the given password when the proper code is provided
        /// </summary>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userPasswordResetConfirmation"></param>
        /// <returns>Object</returns>
        public Object ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost(UserPasswordResetConfirmation userPasswordResetConfirmation)
        {
            Ehelply.Sdk.Client.ApiResponse<Object> localVarResponse = ResetPasswordConfirmationUsersAuthPasswordResetConfirmPostWithHttpInfo(userPasswordResetConfirmation);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reset Password Confirmation Resets the given user&#39;s password to the given password when the proper code is provided
        /// </summary>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userPasswordResetConfirmation"></param>
        /// <returns>ApiResponse of Object</returns>
        public Ehelply.Sdk.Client.ApiResponse<Object> ResetPasswordConfirmationUsersAuthPasswordResetConfirmPostWithHttpInfo(UserPasswordResetConfirmation userPasswordResetConfirmation)
        {
            // verify the required parameter 'userPasswordResetConfirmation' is set
            if (userPasswordResetConfirmation == null)
                throw new Ehelply.Sdk.Client.ApiException(400, "Missing required parameter 'userPasswordResetConfirmation' when calling AuthApi->ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost");

            Ehelply.Sdk.Client.RequestOptions localVarRequestOptions = new Ehelply.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ehelply.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Ehelply.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = userPasswordResetConfirmation;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/sam/users/auth/password/reset/confirm", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset Password Confirmation Resets the given user&#39;s password to the given password when the proper code is provided
        /// </summary>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userPasswordResetConfirmation"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ResetPasswordConfirmationUsersAuthPasswordResetConfirmPostAsync(UserPasswordResetConfirmation userPasswordResetConfirmation, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ehelply.Sdk.Client.ApiResponse<Object> localVarResponse = await ResetPasswordConfirmationUsersAuthPasswordResetConfirmPostWithHttpInfoAsync(userPasswordResetConfirmation, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reset Password Confirmation Resets the given user&#39;s password to the given password when the proper code is provided
        /// </summary>
        /// <exception cref="Ehelply.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userPasswordResetConfirmation"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Ehelply.Sdk.Client.ApiResponse<Object>> ResetPasswordConfirmationUsersAuthPasswordResetConfirmPostWithHttpInfoAsync(UserPasswordResetConfirmation userPasswordResetConfirmation, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'userPasswordResetConfirmation' is set
            if (userPasswordResetConfirmation == null)
                throw new Ehelply.Sdk.Client.ApiException(400, "Missing required parameter 'userPasswordResetConfirmation' when calling AuthApi->ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost");


            Ehelply.Sdk.Client.RequestOptions localVarRequestOptions = new Ehelply.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Ehelply.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Ehelply.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = userPasswordResetConfirmation;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/sam/users/auth/password/reset/confirm", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
