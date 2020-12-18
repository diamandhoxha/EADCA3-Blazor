using EADCA3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Net.WebRequestMethods;

namespace EADCA3Test
{
    [TestClass]
    public class UnitTest1
    {
        private Response news;
        private Response news1;

        //not working, wanted to compare to different apis and show they are different
        [TestMethod]
        /*public async void ComparingTwoApis_willfail()
        {
            news = await Http.GetFromJsonAsync<Response>("https://newsapi.org/v2/top-headlines?sources=fox-news&apiKey=a15cbcc05e814709a1749fbec881c2c2", options);
            news1 = await Http.GetFromJsonAsync<Response>("https://newsapi.org/v2/top-headlines?sources=nbc-news&apiKey=a15cbcc05e814709a1749fbec881c2c2", options);

            Assert.IsFalse.AreEqual(news,news1);
        }*/
    }
}
