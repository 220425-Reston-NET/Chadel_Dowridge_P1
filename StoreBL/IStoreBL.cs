using StoreModel;

namespace StoreBL
{
    /// <summary>
    /// Business Layer is resposible for futher validation or process of data obtained from the database or the user
    /// What kind of process? That all depends on the type of functionality you will be doing
    /// </summary>
    
    public interface IStoreBL
    {
        /// <summary>
        /// Add Customers to the database 
        /// </summary>
        /// <param name="_sneaker">This will add Customers name to the database</param>
        /// <returns>Gives back the Customers name is added to the database</returns>
        void AddSneaker(Sneaker p_sneaker);

        /// <summary>
        /// This will search for a pokemon in the DB using their name
        /// </summary>
        /// <param name="p_shoeName">Name of the pokemon used to search</param>
        /// <returns>Multiple pokemons if they have matching name</returns>
        Sneaker SearchSneakerByName(string p_shoeName);
        Ability SearchAbilityByName(string? userInput);

        // List<Sneaker> SearchSneakerById(int p_sneakerId);
        void AddSelectToShoes(Sneaker p_Sneaker);
        Sneaker SearchCustomerByName(string shoeName);
        Sneaker SearchCustomerByType(string shoeName);
        void SearchAbilityByName(Sneaker foundedSneaker);

        /// <summary>
        /// Will give current Sneaker in the DB
        /// </summary>
        /// <returns>List object that holds Sneaker</returns>
        List<Sneaker> GetAllSneakers();

    }
}
