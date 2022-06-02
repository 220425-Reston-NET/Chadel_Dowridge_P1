using StoreModel;

namespace StoreBL
{
    public interface ISelectBL
    {
        
    /// <summary>
    /// Will give you all the abilities from the DB
    /// </summary>
    List<Ability> GetAllAbility();

    /// <summary>
        /// Will find an ability in the DB based on the name
        /// </summary>
        /// <param name="p_abilityName">The name parameter used to find the ability</param>
        /// <returns>Returns an ability object that it found or a null if no pokemon was found</returns>
        Ability SearchAbilityByName(string p_abilityName);
        List<Sneaker> GetAllShoes();
    }
}