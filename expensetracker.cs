using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
    a:
        Dictionary<string, int> products = new Dictionary<string, int>()
        {
            {"Mouse", 10 },
            {"Keyboard", 50 },
            {"Laptop", 300 },
            {"PC", 600 },
            {"Mouse Pad", 5 }
        };
        Console.WriteLine("What products have you bought? (with capital letter start!)");
        int number = 0;
        int i = 0;
        int sum = 0;
        string action = Console.ReadLine();
        if (action == "help")
        {
            Console.Clear();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key}");
            }
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
            Console.Clear();
            goto a;
        }
        else if (products.ContainsKey(action))
        {
            i++;
            Console.WriteLine("How many of these did you buy?");
            int number = Convert.ToInt16(Console.ReadLine());
            int convert = Convert.ToInt32(products[action]);
            int result = convert * number;
            sum = sum + result;
            Console.WriteLine($"The cost for this is: {result}");
            goto a;
        }
        else if (products.ContainsKey(action) && i > 0)
        {
            Console.WriteLine("How many of these did you buy?");
            int number = Convert.ToInt16(Console.ReadLine());
            int convert = Convert.ToInt32(products[action]);
            int result = convert * number;
            sum = sum + result;
            Console.WriteLine($"The total cost so far is: {sum}");
            goto a;
        }
    }
}
