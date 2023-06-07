using System.Net.Http.Json;
using Core.Domain.Models;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Tests.E2E;

[TestFixture]
public class WebApiTests
{
    private WebApplicationFactory<Program> _factory;
    private HttpClient _testClient;
        
    [OneTimeSetUp]
    public void BeforeAll()
    {
        _factory = new WebApplicationFactory<Program>();
        _testClient = _factory.CreateClient();
    }

    [Test]
    public async Task HealthCheck_Returns200()
    {
        var actual = await _testClient.GetAsync("/health");
        Assert.That((int)actual.StatusCode, Is.EqualTo(200));
    }
    
    [Test]
    public async Task GetQuestions_ReturnsQuestions()
    {
        var response = await _testClient.GetAsync("/api/questions?categories=1,2,3&difficulty=3&questionCount=20&tags=");
        var actualQuestions =  await response.Content.ReadFromJsonAsync<List<Question>>();
        Assert.That(actualQuestions, Is.Not.Null);
        Assert.That(actualQuestions, Is.Not.Empty);
    }
}