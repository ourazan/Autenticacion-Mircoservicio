using System;
using System.Configuration;
using System.Web.Http;
using AutenticacionBLL;

namespace GoogleLoginService.Controllers
{
    public class LoginController : ApiController
    {
        //GET api/Login
        public String Get()
        {
            Autenticacion Objeto = new Autenticacion();
             return   Objeto.PreAutenticarse(ConfigurationManager.AppSettings["appUser"].ToString()
                , ConfigurationManager.AppSettings["clientId"].ToString()
                ,ConfigurationManager.AppSettings["clientSecret"].ToString()
                ,ConfigurationManager.AppSettings["redirectURI"].ToString());
           
        }
    }
}
