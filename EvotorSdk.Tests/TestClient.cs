using NUnit.Framework;

namespace EvotorSdk.Tests
{
    public class TestClient : EvotorClient
    {
        public TestClient(string token) : base(token)
        {
            Tracer = TestContext.Progress.WriteLine;
        }
    }
}
