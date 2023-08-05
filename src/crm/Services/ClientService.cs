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

        clients.Add (new Client()
        {
         FirstName = client.FirstName,
         LastName =client.LastName,
         MiddleName = client.MiddleName,
         Age = client.Age,
         PassportNumber = client.PassportNumber,
         Gender = client.Gender,
         Phone = client.Phone,
         Email = client.Email,
         Password = client.Password});
       
       
       foreach(Client clientsDetail in clients )
       {
        Console.WriteLine("Clients full details:");
        Console.WriteLine($"{clientsDetail.FirstName}");
        Console.WriteLine($"{clientsDetail.LastName}");
        Console.WriteLine($"{clientsDetail.MiddleName}");
        Console.WriteLine($"{clientsDetail.Age}");
        Console.WriteLine($"{clientsDetail.PassportNumber}");
        Console.WriteLine($"{clientsDetail.Gender}");
        Console.WriteLine($"{clientsDetail.Phone}");
        Console.WriteLine($"{clientsDetail.Email}");
        Console.WriteLine($"{clientsDetail.Password}");
         
       }

        return client;
    }

}



