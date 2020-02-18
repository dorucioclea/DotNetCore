# DotNetCore.Domain

The package provides generic classes for **domain**.

## Entity

```cs
public abstract class Entity : IEquatable<Entity>
{
    public long Id { get; protected set; }

    public static bool operator !=(Entity a, Entity b) { }

    public static bool operator ==(Entity a, Entity b) { }

    public override bool Equals(object obj) { }

    public bool Equals(Entity other) { }

    public override int GetHashCode() { }
}
```

## Event

```cs
public abstract class Event
{
    public Guid Id { get; } = Guid.NewGuid();

    public DateTime DateTime { get; } = DateTime.UtcNow;
}
```

## ValueObject

```cs
public abstract class ValueObject
{
    public static bool operator !=(ValueObject a, ValueObject b) { }

    public static bool operator ==(ValueObject a, ValueObject b) { }

    public override bool Equals(object obj) { }

    public override int GetHashCode() { }

    protected abstract IEnumerable<object> GetEquals();
}
```
