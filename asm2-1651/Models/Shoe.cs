using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651.Models
{
    public class Sneaker : Shoe
    {
        public Sneaker() { }
        public Sneaker(bool lace, string sole, bool elastic, string upper, string color)
        {
            base.Lace = lace;
            base.Sole = sole;
            base.Elastic = elastic;
            base.Upper = upper;
            base.Color = color;
        }
    }

    public class Loafer : Shoe
    {
        public Loafer(string sole, bool elastic, string upper, string color)
        {
            Sole = sole;
            Elastic = elastic;
            Upper = upper;
            Color = color;
        }
    }

    public class Chelsea : Shoe
    {
        public Chelsea(bool lace, string sole, bool elastic, bool ankle, string upper, string color)
        {
            Lace = lace;
            Sole = sole;
            Elastic = elastic;
            Ankle = ankle;
            Upper = upper;
            Color = color;
        }
    }

    public class Shoe
    {
        public bool Lace { get; set; }
        public string Sole { get; set; } = "";
        public bool Elastic { get; set; }
        public bool Ankle { get; set; }
        public string Upper { get; set; } = "";
        public string Color { get; set; } = "";
        public string ToString()
        {
            return $"Lace: {Lace}\nSole: {Sole}\nElastic: {Elastic}\nAnkle: {Ankle}\nUpper: {Upper}\nColor: {Color}";
        }
        
    }

}
