using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        a:
        string[] products = ["Mouse", "Keyboard", "Laptop", "PC", "Mouse Pad"];
        Console.WriteLine("What products have you bought?");
        string action = Console.ReadLine();
        if (action == "help")
        {
            Console.Clear();
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{products[i]}");
            }
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
            Console.Clear();
            goto a;
        }
    }
}
