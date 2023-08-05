
namespace Crm.Entities;

public readonly struct ClientInfo
{
    private readonly long _id;
    private readonly string? _firstName;
    private readonly string _lastName;
    private readonly string _middleName;
    private readonly short _age;
    private readonly string _passportNumber;
    private readonly Gender _gender;
    private readonly long _phone;
    private readonly string _email;
    private readonly string _password;


    public long  Id 
    {   
        get => _id; 
        init => _id = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required string  FirstName 
    { 
        get => _firstName ?? string.Empty; 
        init => _firstName =value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required string LastName
    { 
        get => _lastName ?? string.Empty; 
        init => _lastName =value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string MiddleName
    {
        get => _middleName ?? string.Empty; 
        init => _middleName =value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public short Age
    {
        get => _age; 
        init => _age =value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required string PassportNumber 
    { 
        get => _passportNumber ?? string.Empty; 
        init => _passportNumber =value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value)); 
    }
    public required Gender Gender 
    { 
        get => _gender; 
        init => _gender = value ==0 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required long Phone 
    { 
        get => _phone; 
        init => _phone = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required string Email 
    { 
        get => _email ?? string.Empty; 
        init => _email =value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value)); 
    }
    public required string Password 
    { 
        get => _password ?? string.Empty; 
        init => _password  =value is {Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value)); 
    }

    public ClientInfo(
        string firstName,
        string lastName,
        string middleName,
        short  age,
        string passportNumber,
        Gender gender,
        long  phone,
        string email,
        string password
    )
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        Age = age;
        PassportNumber = passportNumber;
        Gender = gender;
        Phone = phone;
        Email = email;
        Password = password;
    }
}
