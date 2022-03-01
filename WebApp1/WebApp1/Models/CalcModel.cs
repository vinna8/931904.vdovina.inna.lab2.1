using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class CalcModel
    {
        public readonly int X;
        public readonly int Y;
        public readonly string Add;
        public readonly string Sub;
        public readonly string Mult;
        public readonly string Div;
        public CalcModel(int x, int y, string add, string sub, string mult, string div)
        {
            X = x;
            Y = y;
            Add = add;
            Sub = sub;
            Mult = mult;
            Div = div;
        }
    }
}
