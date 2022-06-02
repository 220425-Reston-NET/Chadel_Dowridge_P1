using System.Text.Json;
using StoreModel;

namespace StoreDL
{

    //This class is responsible for storing and reading our data
    public class SneakerAbilityRepository : IRepository<Sneaker>
    {
        private static string _filepath = "../StoreDL/Data/";
        public void Add(Sneaker p_resource)
        {
            throw new NotImplementedException();
        }

        public void AddSneaker(Sneaker p_sneaker)
        {
            throw new NotImplementedException();
        }

        public List<Sneaker> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Sneaker> ListOfSneaker = JsonSerializer.Deserialize<List<Sneaker>>(jsonString);

            return ListOfSneaker;
        }

        public List<Sneaker> GetAllChoose()
        {
            throw new NotImplementedException();
        }

        public List<Sneaker> GetAllInventory()
        {
            throw new NotImplementedException();
        }

        public void Update(Sneaker p_resource)
        {
            throw new NotImplementedException();
        }

    }
}

//========================================= Old Code =================================================================

            // public void Add(Ability p_resource)
            // {
            //     throw new NotImplementedException();
            // }
            //     List<Ability> IRepository<Ability>.GetAll()
            //     {
            //         throw new NotImplementedException();
            //     }

            //     public void Update(Ability p_resource)
            //     {
            //         throw new NotImplementedException();
            //     }


        // List<Sneaker> listOfSneaker = GetAll();
        // listOfSneaker.Add(p_resource);

        // string jsonString = JsonSerializer.Serialize(listOfSneaker, new JsonSerializerOptions{WriteIndented = true});
        // File.WriteAllText(_filepath, jsonString);

//=========================================================================================================================

        // Current information from the database
            // List<Sneaker> listOfSneaker = GetAll();

            // //Finds the matching pokemon object in the database
            // foreach (Sneaker sneakerObj in listOfSneaker)
            // {
            //     //Condition to find the same pokemon
            //     if (sneakerObj.Name == p_resource.Name)
            //     {
            //     //Saves this information to the list collection
            //     sneakerObj.Abilities = p_resource.Abilities;
            //     }
            // }

            // //Saves this information to the database
            // string jsonString = JsonSerializer.Serialize(listOfSneaker, new JsonSerializerOptions{WriteIndented = true});
            // File.WriteAllText(_filepath, jsonString);