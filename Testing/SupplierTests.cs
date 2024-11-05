using Microsoft.AspNetCore.Mvc.Testing;

namespace Testing
{
    public class SupplierTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _httpClient;
        public SupplierTests(WebApplicationFactory<Program> factory)
        {
            _httpClient = factory.CreateClient();
        }
        [Fact]
        public async Task ListSupplier()
        {
            var response = await _httpClient.GetAsync("/api/suppliers/list");

            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var content = await response.Content.ReadAsStringAsync();
            Assert.False(string.IsNullOrEmpty(content));
        }
    }
}
