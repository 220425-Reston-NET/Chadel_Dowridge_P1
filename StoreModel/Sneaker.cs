using System.ComponentModel.DataAnnotations;

namespace StoreModel
{
    public class Sneaker
    {    
    // This is a field
        private int _SneakerID;
    // This is a property
    // I only want Poke ID to only hold postive numbers     
        public int SneakerID
        {
            get { return _SneakerID; }
            set 
            { 
                if (value > 0)
                {
                
                    _SneakerID = value; 
                }
                else
                {
                    //We will replace this line later on once we learn exceptions
                    throw new ValidationException("SneakerID needs to be above 0.");
                }
            }
        }
        
        public string Name { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public byte Inventory { get; set; }

        public List<Ability> Abilities {get; set;}
        public string Style { get; set; }


        //Everytime you make a new model, make sure you create a construstor 
        //This construstor will be reposible for instatiating other projects as well as setting defualt values for your other properties

        public Sneaker()
        {
            SneakerID = 1;
            Name = "Yezzy";
            Type = "350";
            Abilities = new List<Ability>();

            SneakerID = 2;
            Name = "Nike";
            Type = "Air Forces 1s";
            Abilities = new List<Ability>();

            SneakerID = 3;
            Name = "Jordan";
            Type = "Air 1s";
            Abilities = new List<Ability>();
        }

        public override string ToString()
        {
            return $"===Sneaker Info===\nSneaker Name: {Name}\nSneaker Type: {Type}\nSneaker Size: {Size}\nShoe Inventory: {Inventory}\n========================";
        }

    }
}

