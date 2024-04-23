using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CA1SQT
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class DiscountServiceReal : DiscountService
    {
        public double GetDiscount()
        {
            return 0.8;
        }
    }

    public interface DiscountService
    {
        double GetDiscount();
    }

    public class InsuranceService
    {
        public double CalcPremium(int age, string location, DiscountService ds)
        {
            double premium = 0.0;

            if (location != "rural" && location != "urban")
            {
                return premium;
            }
            if (age < 18)
            {
                return premium;
            }

            if (location == "rural")
            {
                if ((age >= 18) && (age <= 30))
                    premium = 5.0;
                else if (age >= 31)
                    premium = 2.50;
            }
            else if (location == "urban")
            {
                if ((age >= 18) && (age <= 35))
                    premium = 6.0;
                else if (age >= 36)
                    premium = 5.0;
            }

            double discount = ds.GetDiscount();
            if (age >= 50)
                premium *= discount;

            return premium;
        }
    }
}

