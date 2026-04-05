using System;

namespace C__Interfaces_Assignment
{
    public abstract class SaleOverview
    {
        public int DailySales()
        {
            return 400;
        }

        public abstract int MonthlySales();
    }

    public interface IYearlyOverview
    {
        int YearlySales(int monthlySales);
    }

    public class TotalSales : SaleOverview, IYearlyOverview
    {
        public override int MonthlySales()
        {
            int daily = DailySales();
            return daily * 30;
        }

        public int YearlySales(int monthlySales)
        {
            return monthlySales * 12;
        }
    }

    class Sales
    {
        static void Main()
        {
            TotalSales obj = new TotalSales();

            int daily = obj.DailySales();
            int monthly = obj.MonthlySales();
            int yearly = obj.YearlySales(monthly);

            Console.WriteLine("Daily sales: Rs." + daily);
            Console.WriteLine("Monthly sales: Rs." + monthly);
            Console.WriteLine("Annual sales: Rs." + yearly);
        }
    }
}