using DotNetCore.Domain;

namespace DotNetCore.EntityFrameworkCore.Tests
{
    public class FakeEntityChild : Entity
    {
        public long FakeEntityId { get; set; }

        public FakeEntity FakeEntity { get; set; }
    }
}
