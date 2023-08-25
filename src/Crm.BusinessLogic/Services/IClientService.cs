namespace Crm.BusinesLogic;

public interface IClientService
{
    public ClientInfo CreateClient(ClientInfo clientInfo);
    public ClientInfo GetClient(string firstName, string lastName);
    public bool RemoveClient(string firstName, string lastName);
    public bool EditClient (long id, string newFirstName, string newLastName);
}