using StoreDL;
using StoreModel;

namespace StoreBL
{
    public class SelectBL : ISelectBL
    {
        //====Dependency Injection====
        private IRepository<Sneaker> _sneakerRepo;
        public SelectBL(IRepository<Sneaker> p_sneakerRepo)
        {
            _sneakerRepo = p_sneakerRepo;
        }
        
        //==============================
    public List<Sneaker> GetAllAbility()
        {
            return _sneakerRepo.GetAllChoose();
        }

    public List<Sneaker> GetAllShoes()
        {
            throw new NotImplementedException();
        }

    public Ability SearchAbilityByName(string p_abilityName)
        {
            throw new NotImplementedException();
        }


//====================== SearchSneakerByType ===================================================
        public Sneaker SearchSneakerByType(string p_SneakerName)
        {
            List<Sneaker> currentListOfSneaker = _sneakerRepo.GetAllChoose();

            foreach (Sneaker SneakerName in currentListOfSneaker)
            {
                // Sneaker sneakerObj = currentListOfSneaker[i];
                if (SneakerName.Type == p_SneakerName)
                {
                    return SneakerName;
                }
            }

            //Will return null if no ability was found
            return null;
        }
//=====================================================================================================


//====================== SearchSneakerByName ===================================================
        public Sneaker SearchSneakerByName(string p_SneakerName)
        {
            List<Sneaker> currentListOfSneaker = _sneakerRepo.GetAllChoose();

            foreach (Sneaker SneakerName in currentListOfSneaker)
            {
                // Sneaker sneakerObj = currentListOfSneaker[i];
                if (SneakerName.Name == p_SneakerName)
                {
                    return SneakerName;
                }
            }

            //Will return null if no ability was found
                return null;
        }
//=====================================================================================================

//====================== View Inventory ===================================================
        // public Sneaker SearchSneakerByName(string p_SneakerName)
        // {
        //     List<Sneaker> currentListOfSneaker = _sneakerRepo.GetAllChoose();

        //     foreach (Sneaker SneakerName in currentListOfSneaker)
        //     {
        //         // Sneaker sneakerObj = currentListOfSneaker[i];
        //         if (SneakerName.Name == p_SneakerName)
        //         {
        //             return SneakerName;
        //         }
        //     }

        //     //Will return null if no ability was found
        //     return null;
        // }
//=====================================================================================================
        List<Ability> ISelectBL.GetAllAbility()
        {
            throw new NotImplementedException();
        }
    }
}