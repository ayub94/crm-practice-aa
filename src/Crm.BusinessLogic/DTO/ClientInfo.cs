namespace Crm.BusinesLogic;

public readonly record struct ClientInfo(long Id, string FirstName, string LastName, string MiddleName, string Phone, string Email, string Password, string PassportNumber, string Age, string Gender) ;