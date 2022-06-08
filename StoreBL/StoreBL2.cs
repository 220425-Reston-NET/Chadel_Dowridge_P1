using StoreDL;
using StoreModel;

namespace StoreBL
{
    public class StoreBL3
    {
        private IRepository<Store> _storeRepo;
        public StoreBL3(IRepository<Store> p_storeRepo)
        {
            _storeRepo = p_storeRepo;
        }

        public List<Product> ViewStoreInventory(int p_sId)
        {
            List<Store> listOfCurrentStore = _storeRepo.GetAll();

            foreach (Store item in listOfCurrentStore)
            {
                //Condition to return a specific store
                if (item.Id == p_sId)
                {
                    return item.Products;
                }
            }

            //It will return nothing if the client specify a store that was never in the database
            return null;
        }
    }
}