using Crm.Entities;
using Crm.Services;

ClientService clientService = new();
CreateClient();

void CreateClient()
{
    string firstName = Console.ReadLine();
    string lastName = Console.ReadLine();
    string middleName = Console.ReadLine();
    string ageInputStr = Console.ReadLine();
    string passportNumber = Console.ReadLine();
    string genderInputStr = Console.ReadLine();
    
    if(!ValidateClient(
        firstName,
        lastName,
        middleName,
        ageInputStr,
        passportNumber,
        genderInputStr
    )) return;

    Gender gender = (Gender)int.Parse(genderInputStr);
    short age = short.Parse(ageInputStr);

    Client newClient = clientService.CreateClient(
        firstName,
        lastName,
        middleName,
        age,
        passportNumber,
        gender
    );
    Console.WriteLine(newClient);

    Console.WriteLine("Client Name: {0}",
        string.Join(' ' , newClient.LastName, newClient.FirstName,newClient.MiddleName));

    Console.WriteLine("Client Age: {0}", newClient.Age);
    Console.WriteLine("Client Passport Number: {0}", newClient.PassportNumber);
    Console.WriteLine("Client Gender: {0}", newClient.Gender);
}

bool ValidateClient(
    string firstName,
    string lastName,
    string middleName,
    string ageStr,
    string passportNumber,
    string genderStr)
{
    List<string> errors = new();

    if (firstName is { Length: 0 })
        errors.Add("First Name field is required!");

    if (lastName is { Length: 0 })
        errors.Add("Last Name field is required!");

    if (middleName is { Length: 0 })
        errors.Add("Middle Name field is required!");

    bool isAgeCorrect = short.TryParse(ageStr, out short age);
    if (!isAgeCorrect)
        errors.Add("Please input correct value for age field!");

    if (passportNumber is { Length: 0 })
        errors.Add("Passport Number field is required!");

    bool isGenderCorrect = int.TryParse(genderStr, out int genderIndex);
    if (!isGenderCorrect)
        errors.Add("Please input correct value for gender field!");
    
    bool isEnumGenderCorrect = genderIndex.TryParse(out Gender gender);
    if (!isEnumGenderCorrect)
        errors.Add("Please input correct value for gender field (0 - Male, 1 - Female)!");

    if (errors is { Count: > 0 })
    {
        foreach(string errorMessage in errors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
        }

        Console.ForegroundColor = ConsoleColor.White;
        return false;
    }

    return true;
}

OrderService orderService = new();
CreateOrder();

void CreateOrder()
{
    string orderDescription = Console.ReadLine();
    string priceInputStr = Console.ReadLine();
    string date = Console.ReadLine();
    string deliveryType = Console.ReadLine();
    string deliveryAddress = Console.ReadLine();

    if(!ValidateOrder(
        orderDescription,
        priceInputStr,
        date,
        deliveryType,
        deliveryAddress
    )) return;

    float price = float.Parse(priceInputStr);

    Order newOrder = orderService.CreateOrder(
        orderDescription,
        price,
        date,
        deliveryType,
        deliveryAddress
    );
    Console.WriteLine(newOrder);

    Console.WriteLine("Order description: {0} ", orderDescription );
    Console.WriteLine("Order price: {0} $ ", price);
    Console.WriteLine("Order date: {0} ", date );
    Console.WriteLine("Order delivery type: {0} ", deliveryType );
    Console.WriteLine("Order delivery address: {0} ", deliveryAddress );

}

bool ValidateOrder(
    string orderDescription,
    string priceInputStr,
    string date,
    string deliveryType,
    string deliveryAddress
    )
{
    List<string> errors = new();

    if (orderDescription is { Length: 0 })
        errors.Add("Order description is required!");

    if (priceInputStr is { Length: 0 })
        errors.Add("Price is required!");
    
    if (date is { Length: 0 })
        errors.Add("Date is required!");
    
    if (deliveryType is { Length: 0 })
        errors.Add("Delivery type is required!");
    
    if (deliveryAddress is { Length: 0 })
        errors.Add("Delivery address is required!");

    if (errors is {Count : > 0})
    {
        foreach( string errorMessage in errors)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
        }
        Console.ForegroundColor = ConsoleColor.White;
        return false;

    }
    return true;

}


