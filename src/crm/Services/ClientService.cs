using Crm.Entities;

namespace Crm.Services;

public sealed class ClientService
{
    public List<Client> clients = new List<Client>();
    public Client CreateClient(ClientInfo clientInfo)
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

} 
