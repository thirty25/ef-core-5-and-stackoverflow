using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StackEfCore.Data;
using Xunit;

namespace StackEfCore.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Can_query_some_users()
        {
            var context = new StackOverflowMathContext();
            var usersCount = await context.Users.LongCountAsync();
            Assert.True(usersCount > 0, "expected to find a user or two");
        }
    }
}
