using StoreBL;
using StoreModel;

namespace StoreUI
{
    public class SelectOrder : IMenu
    {
        //=====Dependency Injection===========
        private ISelectBL _selectBL;
        private IStoreBL _storeBL;
        private StoreBL3 storeBL2;

        public SelectOrder(SelectBL selectBL, StoreBL3 storeBL2)
        {
            this.storeBL2 = storeBL2;
        }
        //================================================

        public void Display()
        {
            //This will display all Shoes Styles currently availbe in the datbase
            List<Sneaker> listOfSneakers = _selectBL.GetAllShoes();
            foreach (Sneaker selectObj in listOfSneakers)
            {
                Console.WriteLine(selectObj.Name);
            }
        }

        public string YourChoice()
        {
            Console.WriteLine("Give me the Style of Shoe do you like?");
            string userInput = Console.ReadLine();

             
            //Logic to select a specific ability in our listOfAbility variable
            Ability foundedSneaker = _storeBL.SearchAbilityByName(userInput);
             
            //Validation for userInput
            if (foundedSneaker != null)
            {
                // Logic adds the ability to the founded pokemon using the abilities property in its model
                SearchCustomer.foundedSneaker.Abilities.Add(foundedSneaker);
                _storeBL.SearchAbilityByName(SearchCustomer.foundedSneaker);
                Console.WriteLine("Successfully added ability!");
            }
            else
            {
                Console.WriteLine("Ability was unable to be found! Please enter the exact name (case sensitive)");
                Console.ReadLine();
                return "SelectAbility";
            }

            //Logic to save that information permanently (UPDATING)
            Console.ReadLine();
            return "MainMenu";

        }   

    }
}