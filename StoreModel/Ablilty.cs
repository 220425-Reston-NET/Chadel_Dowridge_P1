namespace StoreModel
{
    public class Ability
    {
        public string Style { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }
        
        //PowerPoint cannot be neagtive
        private int _PP;
        public int PP
        {
            get { return _PP; }
            set
            {

            if (value > 0)
            {
               _PP = value;
            }
            else
            {  
                Console.WriteLine("Powerpoint cannot be neagtive");
            }
            }
        }

        
    }
}
        