using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using GoogleLoginService.Controllers;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
namespace AutenticacionBLL
{
    public class Autenticacion
    {

        public string PreAutenticarse()
        {
            return PreAutenticarse("edguerrero64@ccb.org.co"
                , "188187281435-7gksm80dotr93dvluh06gr8usa940ojp.apps.googleusercontent.com"
                , "AamqXF5qNdQvNorgcHBI5Mfy"
                , @"http://localhost:4771/DatosUsuario.aspx");
        }

        public string PreAutenticarse(string Correo
            , string ClienteId
            , string ClientSecret
            , string redirectUrl
            )
        {

            String userName = Correo;
            ClientSecrets clientSecrets = new ClientSecrets();
            String[] scopes = { "profile" };
            clientSecrets.ClientId = ClienteId;
            clientSecrets.ClientSecret = ClientSecret;
            string credPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            credPath = Path.Combine(credPath, ".credentials/", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
            DsAuthorizationBroker.RedirectUri = redirectUrl;
            UserCredential credential = DsAuthorizationBroker.AuthorizeAsync(clientSecrets, scopes, userName, CancellationToken.None, new FileDataStore(credPath, true)).Result;
            return credential.UserId;
        }


        public string Autenticar() {
            return Autenticar(
                 "188187281435-7gksm80dotr93dvluh06gr8usa940ojp.apps.googleusercontent.com"
                , "AamqXF5qNdQvNorgcHBI5Mfy"
                , @"http://localhost:4771/DatosUsuario.aspx"
                , "4/HwHy9JvnqEgH-rig5sphjF72e-EV_H8nOy_9nIvB6ZsypEKKYqRbdyisG0A9ShbHNChl6j3vMki_PoDKUJbWUl0");
        }
      
        public string Autenticar(
             string ClienteId
            , string ClientSecret
            , string redirectUrl
            , string code)
        {
            StringBuilder authLink = new StringBuilder();
            string googleplus_client_id = ClienteId;
            string googleplus_client_secret = ClientSecret;
            string redirectURI = redirectUrl.ToString();
            //get the access token 
             System.Net.HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"https://accounts.google.com/o/oauth2/token");
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.Method = "POST";
            authLink.Append("code=");
            authLink.Append(code);
            authLink.Append("&client_id=");
            authLink.Append(googleplus_client_id);
            authLink.Append("&client_secret=");
            authLink.Append(googleplus_client_secret);
            authLink.Append("&redirect_uri=");
            authLink.Append(redirectURI);
            authLink.Append("&grant_type=authorization_code");
            UTF8Encoding utfenc = new UTF8Encoding();
            byte[] bytes = utfenc.GetBytes(authLink.ToString());
            Stream os = null;
            try // send the post
            {
                webRequest.ContentLength = bytes.Length; // Count bytes to send
                os = webRequest.GetRequestStream();
                os.Write(bytes, 0, bytes.Length);        // Send it
                System.Net.HttpWebResponse webResponse = (System.Net.HttpWebResponse)webRequest.GetResponse();
                StreamReader sr = new StreamReader(webResponse.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (Exception ex)
            {
                return "sin token";
            }

        }

    }
}
