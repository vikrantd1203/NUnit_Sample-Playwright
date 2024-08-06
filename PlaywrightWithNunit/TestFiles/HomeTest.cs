using Microsoft.Playwright.NUnit;

namespace PlaywrightWithNunit.TestFiles
{
    public class Tests: PageTest
    {

        [Test]
        public async Task Login_With_Valid_Credentials_And_Logout()
        {
            var url = "https://www.browserstack.com/docs/";

            //Go to URL
            await Page.GotoAsync(url);

         
            //Validating URL and Text on Home Page
            if (!Page.Url.Equals(url))
            {
                Assert.Fail();
            }

     

        }
    }
}