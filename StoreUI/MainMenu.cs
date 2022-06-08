using StoreModel;

namespace StoreUI
{
    public class MainMenu : IMenu
    {
        //This method will display things in your terminal that will show what the user can do
        public void Display()
        {
            Console.WriteLine("Welcome to Main Menu!");
            Console.WriteLine("What Can I Do For You?");
            Console.WriteLine("[4] - Purchase a Shoe");
            Console.WriteLine("[3] - View Store Inventory");
            Console.WriteLine("[2] - Add a New Shoe");
            Console.WriteLine("[1] - Search a Shoe ");
            Console.WriteLine("[0] - To exit the store ");

        }
        //This method will ask user what to do 
        public string YourChoice()
        {
            string userInput = Console.ReadLine();
            
            //=============== Purchase a Shoe ===========================================
            if (userInput == "4")
            {
                //We return what we think the menu should display next when that person picked that choice
                //In this case it will display the AddPokemon menu instead
                return "AddCustomer";
                
            }
            //=============== View Store Shoe Inventory =================================
            if (userInput == "3")
            {
                //We return what we think the menu should display next when that person picked that choice
                //In this case it will display the AddPokemon menu instead
                return "AddCustomer";

            }
            
            //============== Add a New Sneaker Function ================================
            if (userInput == "2")
            {
                //We return what we think the menu should display next when that person picked that choice
                //In this case it will display the AddPokemon menu instead
                //Logic : Add Sneaker
                return "AddSneaker";

            }
            
            //============== Search a Sneaker Function ================================
            else if (userInput == "1")
            {
                //Logic : Search Customer 
                return "SearchCustomer";
            }

             //============== "Exit" Function ========================================
            else if (userInput == "0")
            {
                //Exit functionality
                //Logic to exit
                return "Exit";
            }
            else
            {
                Console.WriteLine("Please enter a Vaild reponse");
                return "MainMenu";
            }
        }
    }
}






//=============================================================================================================

//                                              Old Menu : Checkout Function                                                     \\

//===============================================================================================================


// // Checkout Function Below

// int n1 = 0;
// int n2 = 0;
// int n3 = 0;
// int n4 = 0;
// int n5 = 0;
// string CheckoutOption1 = "";
// string CheckoutOption2 = "";
// string answer111 = "";


// ===================================================================================

// //Nike Logic
// n1 += 70;
// Console.WriteLine("[1] - You Have Selected Nike");
// Console.WriteLine("Your Nike purchase is going to be $" + n1 + " U.S Dollars");
// Console.WriteLine("Would you like to buy something else?");
// Console.WriteLine("Press 1 if Yes, Press 2 to checkout");

// ===================================================================================

// //Yezzy Logic
// n2 += 400;
// Console.WriteLine("[2] - Yezzy");
// Console.WriteLine("Your Yeezy purchse is going to be " + n2 + " U.S Dollars");
// Console.WriteLine("Would you like to buy something else?");
// Console.WriteLine("Press 1 if Yes, Press 2 to checkout");
// userInput = Console.ReadLine();
// CheckoutOption1 = Console.ReadLine();

// ===================================================================================

// //Puma Logic
// n3 += 150;
// Console.WriteLine("[3] - Puma");
// Console.WriteLine("Your Puma purchse is going to be " + n3 + " U.S Dollars");
// Console.WriteLine("Would you like to buy something else?");
// Console.WriteLine("Press 1 if Yes, Press 2 to checkout");
// userInput = Console.ReadLine();

// ===================================================================================

// //Adidas Logic
// n4 += 150;
// Console.WriteLine("[4] - Adidas");
// Console.WriteLine("Your Addias purchse is going to be " + n4 + " U.S Dollars");
// Console.WriteLine("Would you like to buy something else?");
// Console.WriteLine("Press 1 if Yes, Press 2 to checkout");
// userInput = Console.ReadLine();

// ===================================================================================
                    
// //Jordan Logic
// n5 += 150;
// Console.WriteLine("[5] - Jordan");
// Console.WriteLine("Your Jordan purchse is going to be " + n5 + " U.S Dollars");
// Console.WriteLine("Would you like to buy something else?");
// Console.WriteLine("Press 1 if Yes, Press 2 to checkout");
// userInput = Console.ReadLine();

// ===================================================================================
// Checkout Function

// if (CheckoutOption1 == "1")
// {
// return "true";
//}
//if (CheckoutOption1 == "2")
//{
//Console.WriteLine("Your total will be $" + (n1 + n2 + n3 + n4 + n5));
//}
//{
//if (userInput == "2")
//{
//}
//if (userInput == "3")
//{
//}
//if (userInput == "4")
//{
//if (userInput == "5")
//{
//}
//}
//return "Thank you for shopping";
// }
// else if (userInput == "2")
// {
// Logic : Checkout Function
// return "Thank you for shopping";
// }
// else if (userInput == "4")
// {
// }