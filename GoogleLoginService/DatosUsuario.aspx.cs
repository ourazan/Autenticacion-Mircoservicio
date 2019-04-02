using System;
using System.Configuration;
using AutenticacionBLL;

namespace GoogleLoginService
{
    public partial class DatosUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request["code"] != null)
            {
                TokenTextBox.Text = ValidarToken(Request["code"]
                    ,ConfigurationManager.AppSettings["clientId"].ToString()
                    ,ConfigurationManager.AppSettings["clientSecret"].ToString()
                    ,ConfigurationManager.AppSettings["redirectURI"].ToString()
                    );
            }
            else
            {
                ErrorLabel.Text = "No se se recibio un codigo de autorización";
                ErrorLabel.Visible = true;
            }
        }

        public string ValidarToken( string Codigo
            ,string ClientID
            ,string Secret
            ,string Uri) {
          
                Autenticacion objeto = new Autenticacion();
               return  objeto.Autenticar(ClientID
                    , Secret
                    , Uri
                    , Codigo  );
        }
    }
}