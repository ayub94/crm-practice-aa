using Crm.Entities;
namespace Crm.Services;

abstract class ClientServices
{
    public List<Client> clients = new();
    public abstract Client CreateClient(ClientInfo clientInfo);
    public abstract Client? GetClient(string firstName, string  lastName);
} 
 class ClientService : ClientServices
{
    public override Client CreateClient(ClientInfo clientInfo)
    {
         Client client = new()
        {
            FirstName = clientInfo.FirstName,
            LastName = clientInfo.LastName,
            MiddleName = clientInfo.MiddleName,
            Age = clientInfo.Age,
            PassportNumber = clientInfo.PassportNumber,
            Gender = clientInfo.Gender,
            Phone = clientInfo.Phone,
            Email = clientInfo.Email,
            Password = clientInfo.Password
        };

        clients.Add (client) ;

        return client;
    }
     public override Client? GetClient(string firstName, string  lastName)
    { 
         if(firstName is not {Length: >0})
            throw new ArgumentNullException(nameof(lastName));
        if(lastName is not {Length: >0})
            throw new ArgumentNullException(nameof(lastName));

        foreach (Client client in clients)
        {
            if(client.FirstName.Equals(firstName) && client.LastName.Equals(lastName))
                return client;
        }
        return null;
    }
}
