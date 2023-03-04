using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {//products-name,price,quantity and their price
            //input Beer 2.20 100
            //output Beer -> 220.00
            //•	Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}".
            Dictionary<string, double[]> orders = new Dictionary<string, double[]>();
            string input = Console.ReadLine();
            while (input != "buy")
            {//{name} {price} {quantity}
                string[] cmdArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string product = cmdArg[0];
                double price = double.Parse(cmdArg[1]);
                double quantity = double.Parse(cmdArg[2]);
                if (!orders.ContainsKey(product))
                {
                    orders[product] = new double[2];//[0]-price
                                                    //[1]-quantity//add empty[]
                }
                orders[product][0] = price;//даваме му новата цена 
                orders[product][1] += quantity;//добавяме колич. към другото
                input = Console.ReadLine();
            }
            foreach (var kvp in orders)
            {
                double totalPrice = kvp.Value[0] * kvp.Value[1];
                Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
                //"{productName} -> {totalPrice}"
            }

        }
    }
}
