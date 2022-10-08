namespace Authentication.SDK.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}