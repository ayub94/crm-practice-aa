using Crm.DataAccess;

namespace Crm.BusinessLogic;


ClientService clientService = new();
OrderService orderService = new();

Console.WriteLine("Create client command: 0 ");
Console.WriteLine("Create  order command: 1 ");

int chooseCommand = int.Parse(Console.ReadLine());
if(chooseCommand == 0)
    CreateClient();
else if(chooseCommand == 1)
    CreateOrder();

void CreateClient()
{   Console.WriteLine("First Name: ");
    string firstName = Console.ReadLine();
    Console.WriteLine("Family Name: ");
    string lastName = Console.ReadLine();
    Console.WriteLine("Middle Name: ");
    string middleName = Console.ReadLine();
    Console.WriteLine("Age: ");
    string ageInputStr = Console.ReadLine();
    Console.WriteLine("Passport Number");
    string passportNumber = Console.ReadLine();
    Console.WriteLine("Gender ommands: 0-Male ,  1-Female ");
    Console.WriteLine("Gender: ");
    string genderInputStr = Console.ReadLine();
    Console.WriteLine("Phone Number: ");
    string phoneInpStr = Console.ReadLine();
    Console.WriteLine("E-mail address: ");
    string email = Console.ReadLine();
    Console.WriteLine("Password: ");
    string password = Console.ReadLine();
    

    Gender gender = (Gender)int.Parse(genderInputStr);
    short age = short.Parse(ageInputStr);
    long phone = long.Parse(phoneInpStr);

    Client newClient = clientService.CreateClient(new ClientInfo(){
        FirstName = firstName,
        LastName =lastName,
        MiddleName = middleName,
        Age = age,
        PassportNumber =passportNumber,
        Gender = gender,
        Phone = phone,
        Email = email, 
        Password = password
    });
    Console.WriteLine($"{newClient}");

    Console.WriteLine("Client Name: {0}",
        string.Join(' ' , newClient.LastName, newClient.FirstName,newClient.MiddleName));

    Console.WriteLine("Client Age: {0}", newClient.Age);
    Console.WriteLine("Client Passport Number: {0}", newClient.PassportNumber);
    Console.WriteLine("Client Gender: {0}", newClient.Gender);
    Console.WriteLine("Client Phone Number: {0}", newClient.Phone);
    Console.WriteLine("Client E-mail address: {0}", newClient.Email);
    Console.WriteLine("Client Password: {0}", newClient.Password);
}


void CreateOrder()
{
    Console.WriteLine("Ordering item: ");
    string description = Console.ReadLine();
    Console.WriteLine("Price: ");
    string priceInputStr = Console.ReadLine();
    Console.WriteLine("Date of order: ");
    string date = Console.ReadLine();

    
    Console.WriteLine("Please choose  delivery type: ");
    string deliveryType = Console.ReadLine();
    Console.WriteLine("Please provide dellivery address: ");
    string deliveryAddress = Console.ReadLine();

    float price = float.Parse(priceInputStr);

    Order newOrder = orderService.CreateOrder(new OrderInfo(){
        Description = description,
        Price = price,
        Date = date,
        DeliveryType = deliveryType,
        DeliveryAddress =deliveryAddress
    });
    Console.WriteLine(newOrder);

    Console.WriteLine("Order description: {0} ", description );
    Console.WriteLine("Order price: {0} $ ", price);
    Console.WriteLine("Order date: {0} ", date );
    Console.WriteLine("Order delivery typee: {0} ", deliveryType );
    Console.WriteLine("Order delivery address: {0} ", deliveryAddress );
}



