using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoogleLoginService;
namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ValidacionToken()
        {
           DatosUsuario   objeto = new DatosUsuario();
           Assert.IsNotNull(  objeto.ValidarToken("4/HwHy9JvnqEgH-rig5sphjF72e-EV_H8nOy_9nIvB6ZsypEKKYqRbdyisG0A9ShbHNChl6j3vMki_PoDKUJbWUl0"
                , "188187281435-7gksm80dotr93dvluh06gr8usa940ojp.apps.googleusercontent.com"
                , "AamqXF5qNdQvNorgcHBI5Mfy"
                , @"http://localhost:4771/DatosUsuario.aspx"));
          
        }
    }
}
