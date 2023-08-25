using Crm.DataAccess;
namespace Crm.BusinesLogic;

public static class ClientExtension
{
    public static ClientInfo ToClientInfo(this Client client)
    {
        return new(
            client.Id,
            client.FirstName,
            client.LastName,
            client.MiddleName,
            client.Phone,
            client.PassportNumber,
            client.Age,
            client.Email,
            client.Password,
            client.Gender.ToString());
    }
}

     

     

 
