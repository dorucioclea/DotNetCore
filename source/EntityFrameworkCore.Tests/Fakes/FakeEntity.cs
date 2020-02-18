using System.Collections.Generic;
using DotNetCore.Domain;

namespace DotNetCore.EntityFrameworkCore.Tests
{
    public class FakeEntity : Entity
    {
        public FakeEntity()
        {
        }

        public FakeEntity(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public FakeEntity(string name, string surname, FakeValueObject fakeValueObject)
        {
            Name = name;
            Surname = surname;
            FakeValueObject = fakeValueObject;
            FakeEntityChild = new List<FakeEntityChild> { new FakeEntityChild { FakeEntityId = Id } };
        }

        public FakeEntity(long id, string name, string surname, FakeValueObject fakeValueObject)
        {
            Id = id;
            Name = name;
            Surname = surname;
            FakeValueObject = fakeValueObject;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public FakeValueObject FakeValueObject { get; private set; }

        public IReadOnlyCollection<FakeEntityChild> FakeEntityChild { get; private set; }
    }
}
