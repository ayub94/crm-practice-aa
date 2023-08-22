using System.Security.Cryptography.X509Certificates;
using Crm.DataAccess;
namespace Crm.Services;

abstract class ClientServices
{
    public List<Client> clients = new();
    public abstract Client CreateClient(ClientInfo clientInfo);
    public abstract Client? GetClient(string firstName, string  lastName);
    public abstract Client? EditClient(string firstName, string  lastName, string newFirstName, string newLastName);
    public abstract Client? DeleteClient(string firstName, string  lastName);
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
    public override Client? EditClient(string firstName, string  lastName, string newFirstName, string newLastName)
    {
        if(firstName is not {Length: >0})
            throw new ArgumentNullException(nameof(lastName));
        if(lastName is not {Length: >0})
            throw new ArgumentNullException(nameof(lastName));

        foreach (Client client in clients)
        {
            if(client.FirstName.Equals(firstName) && client.LastName.Equals(lastName))
            {
                Console.WriteLine("Input the new firstName and LastName for current client");
                client.FirstName= newFirstName;
                client.LastName = newLastName;

               return client;
            }      
        }
        return null;
    }
    public override Client? DeleteClient(string firstName, string  lastName)
    {
         if(firstName is not {Length: >0})
            throw new ArgumentNullException(nameof(lastName));
        if(lastName is not {Length: >0})
            throw new ArgumentNullException(nameof(lastName));

        foreach (Client client in clients)
        {
            if(client.FirstName.Equals(firstName) && client.LastName.Equals(lastName))
            {
                clients.Remove(client);
                return client;
            }
            
        }
        return null;

    }
}
