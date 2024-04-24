using BookWise.Core.Contracts;
using BookWise.Core.Services;

namespace BookWise.Tests.UnitTests
{
    [TestFixture]
    public class AuthorServiceTests :UnitTestsBase
    {
        private IAuthorService authorService;

        [OneTimeSetUp]
        public void SetUp() => authorService = new AuthorService(repository);

    }
}
