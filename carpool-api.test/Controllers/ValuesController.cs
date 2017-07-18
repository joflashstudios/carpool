using NUnit.Framework;

namespace carpool_api.test.Controllers
{
    [TestFixture]
    public class ValuesControllerFixture
    {
        [Theory]
        public void Non_Contradiction_Holds(bool truth)
        {
            Assert.That(truth, Is.EqualTo(truth));
        }
    }
}
