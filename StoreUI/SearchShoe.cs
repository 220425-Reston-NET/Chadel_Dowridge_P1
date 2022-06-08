using StoreBL;
using StoreModel;
public class SearchCustomer : IMenu
{
    public static Sneaker foundedSneaker;
    
    //===========Dependency Injection===========
    private IStoreBL _StoreBL;
    public SearchCustomer(IStoreBL p_pokeBL)
    {
        _StoreBL = p_pokeBL;
    }
    //==========================================
    public void Display()
    {
        Console.WriteLine("How would you like to Search for the Sneaker?");
        // Console.WriteLine("[3] - Search by ShoeID");
        Console.WriteLine("[2] - Search by Name of the Shoe");
        Console.WriteLine("[1] - Search by Type of Shoe");
        Console.WriteLine("[0] - Exit");
    }
    public string YourChoice()
    {
        string userInput = Console.ReadLine();

        // if (userInput == "3")
        // {
        //     //Search logic by CustomerID
        //     return "MainMenu";
        // }
        if (userInput == "2")
        {
            //Search Logic by Name
            Console.WriteLine("Enter a Sneaker Name: ");
            string shoeName = Console.ReadLine();
            
            foundedSneaker = _StoreBL.SearchSneakerByName(shoeName);
            Console.Clear();
            

            
            //Condition that it should only display the pokemon info if it found a pokemon
            if (foundedSneaker == null)
            {
                Console.WriteLine("Sneaker was not found!");
            }
            else
            {
                Console.WriteLine(foundedSneaker);
                //Ask user if they want to add an ability to this Sneaker
                Console.WriteLine("Do you want to see the Inventory of The Shoes? (Y - Yes, N - No)");
                string addSneakerChoice = Console.ReadLine();
                if (addSneakerChoice == "Y")
                {
                    return "SelectAbility";
                }
                else
                {
                    return "SearchCustomer";
                }
            } 
            Console.ReadLine();
            return "SearchCustomer";

        }
        else if (userInput == "1")
        {
            //Search Logic by Type
            Console.WriteLine("Enter a Sneaker Type: ");
            string shoeName = Console.ReadLine();
            
            foundedSneaker = _StoreBL.SearchCustomerByType(shoeName);
            
            //Condition that it should only display the pokemon info if it found a pokemon
            if (foundedSneaker == null)
            {
                Console.WriteLine("Sneaker was not found!");
            }
            else
            {
                Console.WriteLine(foundedSneaker.ToString());

                //Ask user if they want to see the Inventoryof the Sneaker
                Console.WriteLine("Do you want to see the Inventory of The Shoes? (Y - Yes, N - No)");
                string addSneakerChoice = Console.ReadLine();
                if (addSneakerChoice == "Y")
                {
                   
                }
                else
                {
                    return "SearchCustomer";
                }
            } 
            Console.ReadLine();
            return "SearchCustomer";
            return "MainMenu";
        }
        else if (userInput == "0")
        {
            //Exit
            return "MainMenu";
        }
        else
        {
            Console.WriteLine("Please enter a valid response");
            return "SearchCustomer";
        }
    }
}