using System;
using System.Collections;
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

        Dictionary<string, int> products = new Dictionary<string, int>()
        {
            {"Mouse", 10 },
            {"Keyboard", 50 },
            {"Laptop", 300 },
            {"PC", 600 },
            {"Mouse Pad", 5 },
            {"Doormat", 20 },
            {"Lamp", 30 }
        };
        int i = 0;
        int number = 0;
        int sum = 0;
        Console.WriteLine("Welcome to your income tracker");
            a:
        Console.WriteLine("Type 'help' to see a list of items of potential buying");
        Console.WriteLine("Type 'continue' to go to the income phase");
        Console.WriteLine("What products have you bought? (with capital letter start!)");

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
        else if (products.ContainsKey(action) && i == 0)
        {
            i++;
            Console.WriteLine("How many of these did you buy?");
            number = Convert.ToInt16(Console.ReadLine());
            int convert = Convert.ToInt32(products[action]);
            int result = convert * number;
            sum += result;
            Console.WriteLine($"The cost for this is: {result}");
            goto a;
        }
        else if (products.ContainsKey(action) && i > 0)
        {
            Console.WriteLine("How many of these did you buy?");
            number = Convert.ToInt16(Console.ReadLine());
            int convert = Convert.ToInt32(products[action]);
            int result = convert * number;
            sum += result;
            Console.WriteLine($"The total cost so far is: {sum}");
            goto a;
        }
        else if (action == "continue")
        {
            Console.WriteLine("Insert the amount of money you'd gained in hand (minus tax) this month:");
            int income = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write in all money gifts you've received in this period:");
            int gifts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write in other means of income (i.e. couch sale)");
            int additional = Convert.ToInt32(Console.ReadLine());
            int added = income + gifts + additional;
            int final = added - sum;
            Console.WriteLine($"Your total this time period comes out to be: {final}");
            Console.ReadKey();
        }
    }
}
