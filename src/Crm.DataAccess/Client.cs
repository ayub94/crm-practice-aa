namespace Crm.DataAccess;
public sealed class Client
{
    public long  Id { get; set; }
    public required string  FirstName { get; set; }
    public required string LastName { get; set; }
    public required string MiddleName { get; set; }
    public required string Age { get; set; }
    public required string PassportNumber { get; set; }
    public required Gender Gender { get; set; }
    public required string  Phone { get; set; }
    public required string  Email { get; set; }
    public required string  Password { get; set; }

}
