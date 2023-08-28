// Program: Circus
// Programmer: Nathaniel Pardee
// Date created: 08-26-2023
// Description: This program calculates the total profit for a circus based on user 
//input. The profit is based on ticket sales, t-shirt sales, concessions, rent, and labor cost.


class Pardee_Nathaniel_Circus
{
    private static void Main(string[] args)
    {
        /**********************************
            Declare constants
        **********************************/
        const decimal ADULT_TICKET_PRICE    = 12.00m,
                      CHILD_TICKET_PRICE    = 8.00m,
                      TSHIRT_PRICE          = 15.00m,
                      TICKET_PROFIT_MARGIN  = 0.7m,
                      TSHIRT_PROFIT_MARGIN  = 0.5m,
                      FOOD_PROFIT_MARGIN    = 0.65m,
                      RENT                  = 2000.0m,
                      LABOR_COST            = 3500.0m;   

        /**********************************
            Declare variables
        **********************************/ 
        decimal ticket_profit, tshirt_profit, food_profit, total_profit, food_revenue;
        int adult_tickets_sold, child_tickets_sold, tshirts_sold;
        string circus_name, date_held; 

        /**********************************
            Display header
        **********************************/ 
        Console.WriteLine("Circus Profit Calculator");
        Console.WriteLine("---------------------------\n");

        /**********************************
            Read Input from the
             user
        **********************************/ 

        Console.Write("Enter the name of the circus: ");
        circus_name = Console.ReadLine()!;

        Console.Write("Enter the date that the circus was held: ");
        date_held = Console.ReadLine()!;

        Console.Write("Enter the number of adult tickets sold: ");
        adult_tickets_sold = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of child tickets sold: ");
        child_tickets_sold = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of t-shirts sold: ");
        tshirts_sold = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the total concession stand revenue: ");
        food_revenue = Convert.ToInt32(Console.ReadLine());

        /**********************************
            Make calculations
        **********************************/ 
        ticket_profit = TICKET_PROFIT_MARGIN * (adult_tickets_sold * ADULT_TICKET_PRICE + child_tickets_sold * CHILD_TICKET_PRICE);
        tshirt_profit = TSHIRT_PROFIT_MARGIN * tshirts_sold * TSHIRT_PRICE;
        food_profit = FOOD_PROFIT_MARGIN * (food_revenue);
        total_profit = ticket_profit + tshirt_profit + food_profit - RENT - LABOR_COST;

        /**********************************
            Display Output
        **********************************/ 
        Console.WriteLine();
        Console.WriteLine($"Circus Name:                              {circus_name}");
        Console.WriteLine($"Date Held:                                {date_held}");
        Console.WriteLine($"Profit from ticket sales:                 {ticket_profit.ToString("C2")}");
        Console.WriteLine($"Profit from t-shirt sales:                {tshirt_profit.ToString("C2")}");
        Console.WriteLine($"Profit from concession stand sales:       {food_profit.ToString("C2")}");
        Console.WriteLine($"Rent:                                     {RENT.ToString("C2")}");
        Console.WriteLine($"Labor Cost:                               {LABOR_COST.ToString("C2")}");
       Console.WriteLine($"Total Profit:                             {total_profit.ToString("C2")}");
       Console.WriteLine();

    }
}