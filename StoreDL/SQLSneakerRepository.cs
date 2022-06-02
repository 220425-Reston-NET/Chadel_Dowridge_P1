using Microsoft.Data.SqlClient;
using StoreModel;

namespace StoreDL
{
    public class SQLSneakerRepository : IRepository<Sneaker>
    {
    //===== Dependency Injection===========================
        private string _connectionString;
        public SQLSneakerRepository(string p_connectionString)
        {
            this._connectionString = p_connectionString;
        }
    
    //==============Dependency Injection ==================
    public void Add(Sneaker p_resource)

    {
        //@ inside the string acts as a parameter
        //We will dymatcially change the information there at a later point in this code
        string SQLQuery = @"insert into Sneaker
                            values (@SneakerName,@SneakerSize,@SneakerType)";
        
        using (SqlConnection con = new SqlConnection(_connectionString))
        {
            con.Open();

            SqlCommand command = new SqlCommand(SQLQuery, con);

            //We fill in the parameters we add earlier
            //We dynamically change information using Addwith value and Parameters to avoid the risk of SQL injection attack
            command.Parameters.AddWithValue("@SneakerName", p_resource.Name);
            command.Parameters.AddWithValue("@SneakerSize", p_resource.Size);
            command.Parameters.AddWithValue("@SneakerType", p_resource.Type);

            //Execute sql statement that is nonquery meaning it will not give infomation back (unlike a select statement)             
            command.ExecuteNonQuery();
        }
    }

        public void AddSneaker(Sneaker p_sneaker)
        {
            throw new NotImplementedException();
        }

        //============================== Select SQL From Sneaker ==================================
        public List<Sneaker> GetAllChoose()
        {
            string SQLQuery = @"select * from Sneaker c
                    inner join Store_Sneaker sc on c.SneakerID = sc.SneakerID
                    inner join Store s on s.StoreID = sc.StoreID";
            List<Sneaker> listOfSneaker = new List<Sneaker>();

            //SqlConnection object is reponsible for establishing a connection to your database
            //Hence why we pass out connectionString information when we construct that object
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                //This opens the connection to the database
                con.Open();

                //Sqlcommand object is reposible for excuting sql statements to a database
                //It needs a string that is a sql statement
                //It needs a Sqlconnection obj that has a connection
                SqlCommand command = new SqlCommand(SQLQuery, con);
                
                //SqlDataReader object is reponsible for reading information froma SQL Server database (Since it gives tables and tables doesnt exist in C# only objects/class)
                SqlDataReader reader = command.ExecuteReader();

                //Mapping the table format that SQL understands to a List collection that C# understands
                //While loop because we dont know many rows there will be in this table
                //reader.Read() method goes from row to row
                while (reader.Read())
                {
                    //We are adding a new Sneaker object to our list collection
                    listOfSneaker.Add(new Sneaker(){
                        
                        //The new Sneaker will hold the properties obtained from a single row in SQL
                        //It is Zero-based index meaning the first column would be a 0
                        // SneakerID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Size = reader.GetString(2),
                        Type = reader.GetString(3),
                        Inventory = reader.GetByte(6),

                });
            }
            return listOfSneaker;
        }
        //==============================================================================================
        
    }

        public List<Sneaker> GetAllInventory()
        {
            string SQLQuery = @"select * from Sneaker c
                    inner join Store_Sneaker sc on c.SneakerID = sc.SneakerID
                    inner join Store s on s.StoreID = sc.StoreID";
            List<Sneaker> listOfSneaker = new List<Sneaker>();

            //SqlConnection object is reponsible for establishing a connection to your database
            //Hence why we pass out connectionString information when we construct that object
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                //This opens the connection to the database
                con.Open();

                //Sqlcommand object is reposible for excuting sql statements to a database
                //It needs a string that is a sql statement
                //It needs a Sqlconnection obj that has a connection
                SqlCommand command = new SqlCommand(SQLQuery, con);

                //SqlDataReader object is reponsible for reading information froma SQL Server database (Since it gives tables and tables doesnt exist in C# only objects/class)
                SqlDataReader reader = command.ExecuteReader();

                //Mapping the table format that SQL understands to a List collection that C# understands
                //While loop because we dont know many rows there will be in this table
                //reader.Read() method goes from row to row
                while (reader.Read())
                {
                    //We are adding a new Sneaker object to our list collection
                    listOfSneaker.Add(new Sneaker(){

                        //The new Sneaker will hold the properties obtained from a single row in SQL
                        //It is Zero-based index meaning the first column would be a 0
                        SneakerID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        // Inventory = reader.GetString(6),
                        // Type = reader.GetString(3)

                });
            }
            return listOfSneaker;
        }
            // throw new NotImplementedException();
        }

        // public List<Sneaker> GetAllInventory()
        // {
        // }

        public void Update(Sneaker p_resource)
    {
        throw new NotImplementedException();
    }
}
}

