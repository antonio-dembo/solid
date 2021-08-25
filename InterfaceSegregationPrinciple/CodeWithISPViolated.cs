namespace InterfaceSegregationPrinciple
{
    //We can resolve this violation by dividing IOrder Interface.
    public interface IOrder
    {
        void AddToCart();        
    }

    public interface IOnlineOrder
    {
        void CCProcess();
    }

    public class OnlineOrder : IOrder , IOnlineOrder
    {
        public void AddToCart()
        {
            // Do add product to cart
        }

        public void CCProcess()
        {
            // process througth credit card
        }
    }

    public class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            // Do add product to cart
        }
        
    }

}