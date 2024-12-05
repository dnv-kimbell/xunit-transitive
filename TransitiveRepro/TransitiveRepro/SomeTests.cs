using Xunit;

namespace TransitiveRepro
{
    public class SomeTests
    {
        [Fact]
        public async Task MyTest()
        {
            await Task.Delay(1000, TestContext.Current.CancellationToken);
        }
    }
}
