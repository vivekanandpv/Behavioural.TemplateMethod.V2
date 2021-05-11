using System;

namespace Behavioural.TemplateMethod.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderBase regularOrder = new RegularOrder();
            OrderBase premiumOrder = new PremiumOrder();

            regularOrder.Process(); //  template method
            Console.WriteLine("-------------------------");
            premiumOrder.Process();
        }
    }
}
