using System.Text.Json;
using StoreModel;

namespace StoreDL
{
    public class ShoeRepository : IRepository<Sneaker>
    {
        private string _filepath = "../StoreDL/Data/SelectShoe.json";
        public void Add(Sneaker p_sneaker)
        {
            List<Sneaker> listOfSneaker = GetAll();
            listOfSneaker.Add(p_sneaker);

            string jsonString = JsonSerializer.Serialize(listOfSneaker, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }

        public void AddSneaker(Sneaker p_sneaker)
        {
            throw new NotImplementedException();
        }

        public List<Sneaker> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Sneaker> listOfSneaker = JsonSerializer.Deserialize<List<Sneaker>>(jsonString);

            return listOfSneaker;
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
            //Current information from the database
            List<Sneaker> listOfSneaker = GetAll();
        
            //Finds the matching Sneaker object in the database
            foreach (Sneaker sneakerObj in listOfSneaker)
            {
                //Condition to find the same Sneaker
                if (sneakerObj.Name == p_resource.Name)
                {
                    //Saves this information to list collection
                    sneakerObj.Abilities = p_resource.Abilities;
                }
            }
        
            //Saves this information to the database
            string jsonString = JsonSerializer.Serialize(listOfSneaker, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }        

    }
}


//=================================Old Code =================================\\
   
               