namespace DotNetCore.Results
{
    public interface IResult
    {
        bool Failed { get; }

        string Message { get; }

        bool Succeeded { get; }
    }
}
