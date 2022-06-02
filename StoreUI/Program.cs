global using Serilog;
using Microsoft.Extensions.Configuration;
using StoreBL;
using StoreDL;
using StoreUI;

//Initialzing my logger
Log.Logger = new LoggerConfiguration() //Logger Configuration used to configure your logger and create it
.WriteTo.File("./logs/user.txt") //A method
.CreateLogger();

var Configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json") // Grabs the specfic 
        .Build(); // Crates the object


//Creating MainMenu obj
// Another form of polymorphism called variance
// Variance are that is letting a refrence variable have multiple forms/objects hold by having it define as a interface
IMenu menu = new MainMenu();

bool repeat = true;

while (repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.YourChoice(); 
    
    if (ans == "MainMenu")
    {
        Log.Information("User going to Main Menu");
        menu = new MainMenu();
    }
    else if (ans == "AddCustomer")
    {
        Log.Information("User Added a Customer");
        menu = new AddCustomer(new StoreBL2(new SQLSneakerRepository(Configuration.GetConnectionString("Chadel Dowridge"))));
    }
    else if(ans == "SearchCustomer")
    {
        Log.Information("User Selected a shoe");
        menu = new SearchCustomer(new StoreBL2(new SQLSneakerRepository(Configuration.GetConnectionString("Chadel Dowridge"))));
    }
    else if(ans == "SelectShoe")
    {
        Log.Information("User Select for a shoe");
        menu = new SelectShoe(new SelectBL(new SneakerAbilityRepository()), new StoreBL2(new SneakerAbilityRepository()));
    }
    else if (ans == "Exit")
    {
        repeat = false;
    }
}



//=========================Old Code===============================================
// Creating an object
// Sneaker pokeObj = new Sneaker();
// pokeObj.SneakerID = 100;
// pokeObj.Name = "Charmander";
// Console.WriteLine(pokeObj.SneakerID);


// pokeObj.SneakerID = -10;
// Console.WriteLine(pokeObj.SneakerID);


// Console.Clear();