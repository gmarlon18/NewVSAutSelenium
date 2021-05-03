using NewVSAutSelenium.PageObjects;
using NUnit.Framework;

namespace NewVSAutSelenium.Tests.TestSuite
{
    [TestFixture]
    public class AutHomePage01 : BaseTest
    {

        [Test]
        [Description("check elements")]
        [Author("Marlon")]

        public void Check_elements()
        {
            ExistingPages.home.GoTo();
            ExistingPages.home.CheckElements();
            string subText = ExistingPages.home.subscribe_alert();
            string textoEsperado = "Gracias por suscribirse: "+ExistingPages.home.User+"...";

            Assert.IsTrue(subText.Contains(textoEsperado), "No coincide el texto '"+ textoEsperado + "' con '"+subText+"'");
           

         

        }

    }
}
