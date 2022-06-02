using StoreBL;
using StoreModel;

public class AddCustomer : IMenu 
{
    private Sneaker sneakerObj = new Sneaker();
    
    //====== Dependency Injection Pattern =======
    //Add the field of the interface you are trying to add
    private IStoreBL _storeBL;


    //Create a constructor with a parameter of that interface
    public AddCustomer (IStoreBL p_storeBL)
    {
        //Set the field with the parameter
        _storeBL = p_storeBL;
    }

    //NOTE: Look into your program.cs and fix the red line
    //===========================================
    
    public void Display()
    {
        Console.WriteLine("Please enter Your Shoe Details for the following questions?");
        Console.WriteLine("What is the Name of the Shoe?");
        sneakerObj.Name = Console.ReadLine();
        Console.WriteLine("What is the Type/Silhouette of the shoe?");
        sneakerObj.Type = Console.ReadLine();
        Console.WriteLine("What is your Size of Shoe?");
        sneakerObj.Size = Console.ReadLine();

        // try
        // {
        //     sneakerObj.SneakerID = Convert.ToInt32(Console.ReadLine());
        // }
        // catch (System.Exception)
        // {
        //     Log.Warning("User tried to add a negative number!");
        //     Console.WriteLine("Your Shoe Size Cannot be Negative!");
        //     sneakerObj.SneakerID = 1;
        // }
        
        Console.WriteLine("[1] - Add the Shoe");
        Console.WriteLine("[0] - Exit");
    }
    

    public string YourChoice()
    {
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            _storeBL.AddSneaker(sneakerObj);
            Console.WriteLine("Sneaker Added! ");
            Console.WriteLine("Press any Key to Go Back to the MainMenu ");
            Console.ReadLine();
            try
            {
                //  _storeBL.AddSneaker(sneakerObj);
            }
            catch (System.Exception)
            {
                Log.Warning("User tried to add a neagtive number!");
                Log.Information(sneakerObj.ToString());
                Console.WriteLine("The Sneaker name you entered already exist!");
                Console.ReadLine();
            }

            return "MainMenu";
        }
        else if (userInput == "0")
        {
            return "Exit";
        }
        else
        {
            Console.WriteLine("Please enter a correct response");
            return "AddCustomer";
        }
    }
}