using asm2_1651.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651.Builder
{
    public abstract class ShoeBuilder
    {
        public abstract void Build(Shoe shoe);
    }

    public class SneakerBuilder : ShoeBuilder
    {
        public override void Build(Shoe shoe)
        {
            Console.WriteLine("Sneaker Tailor");
            Console.WriteLine("Set Lace type: ");
            bool lace = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Set Sole: ");
            string sole = Console.ReadLine();

            Console.WriteLine("Set Elastic type: ");
            bool elastic = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Set Upper: ");
            string upper = Console.ReadLine();

            Console.WriteLine("Set Color: ");
            string color = Console.ReadLine();

            shoe = new Sneaker(){ Lace = lace, Sole = sole, Elastic = elastic, Upper = upper, Color = color };
            Console.WriteLine(shoe.ToString());
            Program.shoes.Add(shoe);
        }
    }
    public class LoaferBuilder : ShoeBuilder
    {
        public override void Build(Shoe shoe)
        {
            Console.WriteLine("Loafer Tailor");
            Console.WriteLine("Set Sole: ");
            string sole = Console.ReadLine();

            Console.WriteLine("Set Elastic type: ");
            bool elastic = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Set Upper: ");
            string upper = Console.ReadLine();

            Console.WriteLine("Set Color: ");
            string color = Console.ReadLine();

            Loafer lf = new Loafer(sole, elastic, upper, color);
            shoe = lf;
        }
    }

    public class ChelseaBuilder : ShoeBuilder
    {
        public override void Build(Shoe shoe)
        {
            Console.WriteLine("Chelsea Tailor");
            Console.WriteLine("Set Lace type: ");
            bool lace = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Set Sole: ");
            string sole = Console.ReadLine();

            Console.WriteLine("Set Elastic type: ");
            bool elastic = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Set Ankle type: ");
            bool ankle = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Set Upper: ");
            string upper = Console.ReadLine();

            Console.WriteLine("Set Color: ");
            string color = Console.ReadLine();

            Chelsea cs = new Chelsea(lace, sole, elastic, ankle, upper, color);
            shoe = cs;
        }
    }
}
