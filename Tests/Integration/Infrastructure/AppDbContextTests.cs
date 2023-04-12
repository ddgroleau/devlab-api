using Core.Utility;
using Infrastructure;

namespace Tests.Integration.Infrastructure;

[TestFixture]
public class AppDbContextTests
{
    private AppDbContext _context;

    [OneTimeSetUp]
    public void BeforeAll()
    {
        AppConfig.LoadEnv();
        _context = new AppDbContext();
    }

    [Test]
    public void Context_HasConnection()
    {
        Assert.That(_context.Database.CanConnect);
    }
}