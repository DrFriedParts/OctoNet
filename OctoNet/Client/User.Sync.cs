#if WINDOWS_PHONE
//Exclude
#else
using OctoNet.Models;
using RestSharp;
using OctoNet.Authenticators;
using System.Net;
using OctoNet.Helpers;

namespace OctoNet
{
    public partial class OctoNetClient
    {

        public UserLogin Login(string email, string password)
        {
            _restClient.BaseUrl = Resource.SecureLoginBaseUrl;
            _restClient.Authenticator = new OAuthAuthenticator(_restClient.BaseUrl, _apiKey, _appsecret, null, null);

            var request = _requestHelper.CreateLoginRequest(_apiKey, email, password);

            var response = _restClient.Execute<UserLogin>(request);

            _userLogin = response.Data;

            return _userLogin;
        }

        public RestResponse CreateAccount(string email, string firstName, string lastName, string password)
        {
            _restClient.BaseUrl = Resource.SecureLoginBaseUrl;

            var request = _requestHelper.CreateNewAccountRequest(_apiKey, email, firstName, lastName, password);

            return _restClient.Execute(request);
        }

        public AccountInfo Account_Info()
        {
            //This has to be here as Octopart change their base URL between calls
            _restClient.BaseUrl = Resource.ApiBaseUrl;
            _restClient.Authenticator = new OAuthAuthenticator(_restClient.BaseUrl, _apiKey, _appsecret, _userLogin.Token, _userLogin.Secret);

            var request = _requestHelper.CreateAccountInfoRequest();

            var response = _restClient.Execute<AccountInfo>(request);

            return response.Data;
        }

    }
}
#endif