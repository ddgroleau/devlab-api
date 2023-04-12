using Core.Utility;

namespace Tests.Integration.Core.Utility;

[TestFixture]
public class AppConfigTests
{
    [Test]
    public void LoadEnv_LoadsEnvironmentVariables()
    {
        AppConfig.LoadEnv();
        Assert.That(Environment.GetEnvironmentVariable("PG_HOST"),Is.Not.Null);
    }
}