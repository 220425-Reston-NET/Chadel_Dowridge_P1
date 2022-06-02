using StoreDL;
using StoreModel;

namespace StoreBL
{

    public class StoreBL2 : IStoreBL
    {
        //========= Dependency Injection ===============
        private IRepository<Sneaker> _shoeRepo;
        public StoreBL2(IRepository<Sneaker> p_shoeRepo)
        {
            _shoeRepo = p_shoeRepo;
        }
        public void AddAbilityTo(Sneaker p_sneaker)
        {
            //Logic to update Sneaker
            _shoeRepo.Update(p_sneaker);
        }
        //==============================================

        public void AddAbilityToSneaker(object foundedSneaker)
        {
            throw new NotImplementedException();
        }

        public void AddSelectToShoes(Sneaker p_Sneaker)
        {
            throw new NotImplementedException();
        }

        public void addShoes(Sneaker p_poke)
        {
            throw new NotImplementedException();
        }

        public Ability SearchAbilityByName(string? userInput)
        {
            throw new NotImplementedException();
        }

        public Sneaker SearchCustomerByName(string? shoeName)
        {
            throw new NotImplementedException();
        }
        public List<Sneaker> GetAllSneakers()
        {
            return _shoeRepo.GetAllInventory();
        }

        //==============================================

        //====================== Add Sneaker Code ===================================================== 
        public void AddSneaker(Sneaker p_sneaker)
        {
            _shoeRepo.Add(p_sneaker);
        }
        //=================== Search Sneaker Code ====================================================
        public Sneaker SearchSneakerByName(string p_shoeName)
        {
            List<Sneaker> currentListOfSneakers = _shoeRepo.GetAllChoose();

            foreach (Sneaker sneakerObj in currentListOfSneakers)
            {
                //Condition to check that the name is similar
                if (sneakerObj.Name == p_shoeName)
                {
                    return sneakerObj;
                }
            }

            //Will return null or no value if no Sneaker was found
            return null;
        }
        //==============================================================================================

        public void SearchAbilityByName(Sneaker foundedSneaker)
        {
            throw new NotImplementedException();
        }

        public Sneaker SearchCustomerByType(string shoeName)
        {
            List<Sneaker> currentListOfSneaker = _shoeRepo.GetAllChoose();

            foreach (Sneaker SneakerName in currentListOfSneaker)
            {
                // Sneaker sneakerObj = currentListOfSneaker[i];
                if (SneakerName.Type == shoeName)
                {
                    return SneakerName;
                }
            }

            //Will return null if no ability was found
            return null;
        }



        //=================================== Old Code ================================================================
        // //Processing data
        // //We randomize the potential value we get when we add a Sneaker to the database
        // Random rand = new Random();
        // p_sneaker.Type = rand.Next(50);

        // //Checks if that Sneaker name already exists
        // Sneaker foundedSneaker = SearchSneakerByName(p_sneaker.Name);
        // if (foundedSneaker == null)
        // {
        //     _shoeRepo.Add(p_sneaker);
        // }
        // else
        // {
        //     _shoeRepo.Add(p_sneaker);
        // }
        // public Ability SearchAbilityByName(string? userInput)
        // {
        //     throw new NotImplementedException();
        // }

        // public Sneaker SearchCustomerByName(string? shoeName)
        // {
        //     throw new NotImplementedException();
        // }

        // public Sneaker? searchSneakerByName(string p_sneakerName)
        // {
        //     List<Sneaker> currentListOfSneaker = _shoeRepo.GetAll();

        //     foreach (Sneaker sneakerObj in currentListOfSneaker)
        //     {
        //         //Condition to check that the name is similar
        //         if (sneakerObj.Name == p_sneakerName)
        //         {
        //             return sneakerObj;
        //         }
        //     }

        //     //Will return null or no value if no Sneaker was found
        //         return null;
        // }

        // public void AddSelectToShoes(Sneaker p_Sneaker)
        // {
        //     throw new NotImplementedException();
        // }

        // public void addShoeChoice(Sneaker p_Sneaker)
        // {
        //     //Logic to update Sneaker
        //     _shoeRepo.Update(p_Sneaker);
        // }

        // public void addShoes(Sneaker p_poke)
        // {
        //     throw new NotImplementedException();
        // }

        // public void AddSneaker(Sneaker sneakerObj)
        // {
        //     throw new NotImplementedException();
        // }

        // public Ability SearchAbilityByName(string? userInput)
        // {
        //     throw new NotImplementedException();
        // }

        // public Sneaker SearchCustomerByName(string? shoeName)
        // {
        //     throw new NotImplementedException();
        // }

        //==============================================
    }
}