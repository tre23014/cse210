class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shopping Cart Program\n");

        List<string> names = new List<string>();
        List<double> prices = new List<double>();

        bool done = false

        while (!done)
        {
            DisplayMenu();
            string choice = GetChoice();

            if (choice == "1")
            {
                Add();
            }
            else if (choice == "2")
            {
                Remove();
            }
            else if (choice == "3")
            {
                Display();
            }
            else if (choice == "4")
            {
                CalcTotal();
            }
            else if (choice == "5")
            {
                done = true
            }
        }


    }

    static void DisplayMenu()
    {
        Console.WriteLine("1) Add");
        Console.WriteLine("2) Remove");
        Console.WriteLine("3) Display");
        Console.WriteLine("4) Total");
        Console.WriteLine("5) Quit\n");
    }
    static string GetChoice()
    {
        Console.Write("Enter Choice: ");
        string choice = Console.ReadLine();
        return choice;
    }
    static void Add(List<string> names, List<double> prices)
    {
        // prompt user, add to list
        Console.Write("Enter the name of the item: ");
        string name = Console.ReadLine();


        Console.Write("Enter the price of item: ");
        string priceString = Console.ReadLine();
        double price = Convert.ToDouble(priceString);

        name.Add(name);
        prices.Add(price);
    }
    static double CalcTotal(List<double> prices)
    {
        double total = 0;
        foreach (var prices in prices) ;
        {
            total += prices;
        }
        return 0.0
    }
    static void Remove()
    {

    }
    static void Display(List<string> names, List<double> prices)
    {
        Console.WriteLine("Cart");
        Console.WriteLine("===============");

        for (int i = 0, i < namess.Count, i++)
        {
            Console.WriteLine($"{names[i]}: {prices[i]}");
        }

        Console.WriteLine("====================")
    }
}