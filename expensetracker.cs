using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Net.Cache;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, List<int>> products = new Dictionary<string, List<int>>
        {
        };
        int i = 0;
        int number = 0;
        int sum = 0;
        Console.WriteLine("Welcome to your income tracker");
    a:
        Console.WriteLine("Type 'help' to see a list of items of potential buying.");
        Console.WriteLine("Type 'continue' to go to the income phase.");
        Console.WriteLine("Type 'balance' to see your current balance.");
        Console.WriteLine("What products have you bought? (with capital letter start!)");
        string action = Console.ReadLine();
        if (action.ToLower() == "help")
        {
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Key}: cost = {p.Value[0]}, amount = {p.Value[1]}");
            }
            goto a;
        }
        else if (action.ToLower() == "continue")
        {
            Console.WriteLine("How much do you earn?");
            double earn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Whats the tax where you reside? (type in without the % symbol)");
            double notax = Convert.ToInt32(Console.ReadLine());
            double earned = earn / (notax * earn / 100);
            Console.Clear();
            Console.WriteLine($"Your earnings so far come out to be: {earned}");
            Console.WriteLine("If you would like to see a graph of your purchase history, type in 'graph'. If not, press enter");
            string graph = Console.ReadLine();
            if (graph.ToLower() == "graph")
            {
                          //for later coding
            }
            else
            {
                goto a;
            }
        }
        else
        {
            Console.WriteLine("How much did you buy?");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much did they cost?");
            int cost = Convert.ToInt32(Console.ReadLine());
            products[action] = new List<int> { cost, amount };
            Console.WriteLine($"Your total expenses come out to be: {products.Sum(kv => kv.Value[0] * kv.Value[1])} ");
            Console.WriteLine("If you'd like to see your current balance, press 1. If not, press any other key.");
            int choice = Convert.ToInt32(Console.ReadKey());
            if (choice == 1 && earned != null)
            {
                Console.WriteLine($"Your current balance is: {earned - products.Sum}")
            }
            goto a;
        }
    }
}
