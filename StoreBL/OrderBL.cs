// using StoreAppBL;
// using StoreDL;
// using StoreModel;

// namespace StoreBL
// {
//     public class OrderBL : iOrderBL
//     {
//         //======Dependency Injection==========
//         private IRepository<Order> _orderRepo;

//         public OrderBL(IRepository<Order> p_orderRepo)
//         {
//             _orderRepo = p_orderRepo;
//         }

//         //====================================
//         public List<Order> GetAllOrders()
//         {
//             return _orderRepo.GetAll();
//         }

//         public Order SearchOrderbyLocation(string p_orderLocation)
//         {
//             List<Order> currentOrderList = _orderRepo.GetAll();

//             foreach(Order orderobj in currentOrderList)
//             {
//                 if(orderobj.Location == p_orderLocation)
//                 {
//                     return orderobj;
//                 }

//             }
            
//             //returns nothing/no value
//             return null;
//         }
//     }
// }