using asm2_1651.Builder;
using asm2_1651.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651.Builder
{
    public abstract class CustomerBuilder
    {
        public abstract void Build(Customer cust);
    }

    public class VipCustomerBuilder : CustomerBuilder
    {
        public override void Build(Customer cust)
        {
            Console.WriteLine("Customer edit");
            Console.Write("Enter VIP customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter VIP customer email: ");
            string email = Console.ReadLine();

            Console.Write("Enter VIP customer phone number: ");
            string phone = Console.ReadLine();

            Console.Write("Enter VIP customer measurement: ");
            string measurement = Console.ReadLine();

            Console.Write("Enter VIP customer discount: ");
            float discount;
            float.TryParse(Console.ReadLine(), out discount);

            Console.Write("Enter VIP customer fee: ");
            float fee;
            float.TryParse(Console.ReadLine(), out fee);

            VipCustomer vip = new VipCustomer(name, email, phone, measurement, discount, fee);

        }

    }

    public class DailyCustomerBuilder : CustomerBuilder
    {
        public override void Build(Customer cust)
        {
            Console.WriteLine("Customer edit");
            Console.Write("Enter daily customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter daily customer email: ");
            string email = Console.ReadLine();

            Console.Write("Enter daily customer phone number: ");
            string phone = Console.ReadLine();

            Console.Write("Enter daily customer measurement: ");
            string measurement = Console.ReadLine();

            DailyCustomer daily = new DailyCustomer(name, email, phone, measurement);

        }

    }
}

