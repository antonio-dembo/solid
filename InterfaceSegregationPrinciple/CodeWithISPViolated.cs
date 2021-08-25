namespace InterfaceSegregationPrinciple
{
    public interface IOrder
    {
        void AddToCart();
        void CCProcess();
    }

    public class OnlineOrder : IOrder
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

        public void CCProcess()
        {
            // no required for Cash , offline Order
            throw new System.NotImplementedException();
        }
    }

}