using System;
namespace Core_app
{
    public class ProductPrice
    {
        public int ItemPrice { get; set; }

        public int ApplyDiscount(int price, int disccount)
        {
            return ItemPrice - CalculateDisccount(price, disccount);
        }

        private Boolean IsDisccountValid(int disccount)
        {
            if ((disccount >= 100) || (disccount < 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int CalculateDisccount(int totalprice, int percentage)
        {
            if (IsDisccountValid(percentage))
            {
                return (totalprice * percentage) / 100;
            }
            else
            {
                return 0;
            }

        }
    }
}
