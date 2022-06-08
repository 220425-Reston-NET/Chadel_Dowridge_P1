// using StoreDL;
// using StoreModel;

// namespace StoreAppUI
// {
//     public class ViewSneakerOrder : IMenu
//     {
//         // //==========dependency injection=====================
        
//         // private IOrderedQueryable _orderBL;

//         // public ViewCustomerOrder(IOrderedQueryable p_orderBL)
//         // {
//         //     _orderBL = p_orderBL;
//         // }
//         // //===================================================
//         public void Display()
//         {
//             Console.WriteLine("===Customer Orders===");
//             foreach(Sneaker _sneakerObj in SearchCustomer.foundedSneaker.Orders)
//             {
//                 Console.WriteLine(_sneakerObj);
//             }
//             Console.WriteLine("0 - Go Back");
//         }

//         public string YourChoice()
//         {
//             string userInput = Console.ReadLine();
//             if(userInput == "0")
//             {
//                 return "SearchCustomer";
//             }
//             else
//             {
//                 return "MainMenu";
//             }
//         }
//     }
// }