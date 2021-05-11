using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural.TemplateMethod.V2
{
    public abstract class OrderBase
    {
        //  High-level steps
        protected abstract void EnsurePayment();
        protected abstract void CheckStock();
        protected abstract void PackItems();
        protected abstract void ShipItems();

        //  template-method
        public void Process()
        {
            EnsurePayment();
            CheckStock();
            PackItems();
            ShipItems();
        }
    }


    public class PremiumOrder : OrderBase
    {
        protected override void CheckStock()
        {
            Console.WriteLine("PremiumOrder: CheckStock");
        }

        protected override void EnsurePayment()
        {
            Console.WriteLine("PremiumOrder: EnsurePayment");
        }

        protected override void PackItems()
        {
            Console.WriteLine("PremiumOrder: PackItems");
        }

        protected override void ShipItems()
        {
            Console.WriteLine("PremiumOrder: ShipItems");
        }
    }

    public class RegularOrder : OrderBase
    {
        protected override void CheckStock()
        {
            Console.WriteLine("RegularOrder: CheckStock");
        }

        protected override void EnsurePayment()
        {
            Console.WriteLine("RegularOrder: EnsurePayment");
        }

        protected override void PackItems()
        {
            Console.WriteLine("RegularOrder: PackItems");
        }

        protected override void ShipItems()
        {
            Console.WriteLine("RegularOrder: ShipItems");
        }
    }
}
