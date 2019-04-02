using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Requests;

namespace GoogleLoginService.Controllers
{
    public class DsAuthorizationCodeFlow : GoogleAuthorizationCodeFlow
    {
        public DsAuthorizationCodeFlow(Initializer initializer): base(initializer) { }

        public override AuthorizationCodeRequestUrl

        CreateAuthorizationCodeRequest(string redirectUri)
        {
            return base.CreateAuthorizationCodeRequest(DsAuthorizationBroker.RedirectUri);
        }
    }
}