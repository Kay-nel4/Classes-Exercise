using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ford = new Car();

            ford.Make = "Ford";
            ford.Model = "Escape";
            ford.Year = 2005;

            ford.CarType();

        }
    }
}
