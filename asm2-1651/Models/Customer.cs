using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651.Models
{
    public class VipCustomer : Customer
    {
        public VipCustomer(string name, string email, string phone, string measurement, float discount, float fee)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Measurement = measurement;
            Discount = discount;
            Fee = fee;
        }

        public string ToString()
        {
            return $"Lace: {Name}\nSole: {Email}\nElastic: {Phone}\nAnkle: {Measurement}\nUpper: {Discount}\nColor: {Fee}";
        }
    }

    public class DailyCustomer :Customer
    {
        public DailyCustomer(string name, string email, string phone, string measurement)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Measurement = measurement;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Measurement { get; set; }
        public float Discount { get; set; }
        public float Fee { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
