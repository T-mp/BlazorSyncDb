using NUnit.Framework;

namespace t_mp.BlazorSyncStorage.Tests
{
    public class Tests
    {
        [Test]
        public void TestObTestsLaufen()
        {
            Assert.Pass();
        }

        [Test]
        [Ignore("Ist nur zum Testen der Testumgebung, schl�gt immer fehl ;-)")]
        public void TestObTestsLaufenFail()
        {
            Assert.Fail();
        }
    }
}