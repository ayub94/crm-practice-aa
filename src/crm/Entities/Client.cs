namespace Crm.Entities;
public sealed class Client
{
    public long  Id { get; init; }
    public required string  FirstName { get; init; }
    public required string LastName { get; init; }
    public required string MiddleName { get; init; }
    public short Age { get; init; }
    public required string PassportNumber { get; init; }
    public required Gender Gender { get; init; }
    public required long  Phone { get; init; }
    public required string  Email { get; init; }
    public required string  Password { get; init; }


}
