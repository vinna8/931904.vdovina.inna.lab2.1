using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.Services
{
    public class CalcService
    {
        private readonly Random _random = new Random();

        public CalcModel GetCalcModel()
        {
            var x = _random.Next() % 11;
            var y = _random.Next() % 11;
            return new CalcModel(
                x, y,
                add: $"{x} + {y} = {x + y}",
                sub: $"{x} - {y} = {x - y}",
                mult: $"{x} * {y} = {x * y}",
                div: y != 0 ? $"{x} /  {y} = {x / y}" : "Division by zero"
            );
        }
    }
}
