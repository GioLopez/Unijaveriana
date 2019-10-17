using System;

namespace BussinesLogic
{
    public class Price
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
            } else {
                return true;
                    }
        }

        private int CalculateDisccount(int totalprice, int percentage)
        {
            if (IsDisccountValid(percentage))
            {
                return (totalprice * percentage) / 100;
            }
            else {
                return 0;
            }
            
        }

        
    }
}
