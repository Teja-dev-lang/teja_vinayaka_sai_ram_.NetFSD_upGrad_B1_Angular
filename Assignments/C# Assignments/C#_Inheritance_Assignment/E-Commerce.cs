using System;
using System.Collections.Generic;

using System.Text;

namespace C__Inheritance_Assignment
{
    class Order
    {
        public int OrderID
        {
            get;
            set;
        }
        public double OrderAmount
        {
            get;
            set;
        }

        public Order(int orderID, double orderAmount)
        {
            OrderID = orderID;
            OrderAmount = orderAmount;
        }
        public virtual double CalculateShippingCost()
        {
            return 50;
        }
    }
    class ExpressOrder: Order
    {
        public ExpressOrder(int orderID, double orderAmount) : base(orderID, orderAmount) 
        { 
            
        }

        public override double CalculateShippingCost()
        {
            return 100;
        }
    }

    class InternationalOrder : Order
    {
        public InternationalOrder(int orderID, double orderAmount) : base(orderID, orderAmount) { }

        public override double CalculateShippingCost()
        {
            return 500;
        }
    }
}
