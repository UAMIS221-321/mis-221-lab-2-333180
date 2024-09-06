/* INPUT
    numberOfSandwiches
    numberOfToppings
    tip
*/
int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;
double totalSandwichCost;
double totalToppingCost;
double baseCost;
double orderCost;
/* Processing
    totalSandwichCost
    totalToppingCost
    baseCost

    COST_OF_SANDWICH
    COST_OF_TOPPING
    DISCOUNT_AMOUNT
*/
// Initialize Constants
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;
/* Prompt user for number of sandwiches
    Input numberOfSandwiches
*/
System.Console.WriteLine("How many sandwiches?");
numberOfSandwiches = int.Parse(Console.ReadLine());
System.Console.WriteLine("Sandwiches: "+numberOfSandwiches);
/* Prompt user for number of toppings needed
    Input numberOfToppings
*/
System.Console.WriteLine("How many toppings?");
numberOfToppings = int.Parse(Console.ReadLine());
System.Console.WriteLine("Toppings: "+numberOfToppings);
/* Prompt user for the tip 
    Input tip
*/
System.Console.WriteLine("Dollar amount of tip?");
tip = int.Parse(Console.ReadLine());
System.Console.WriteLine("Tip: $"+tip);
/*
totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches
totalToppingCost = COST_OF_TOPPING * numberOfToppings
baseCost = totalSandwichCost + totalToppingCost
*/
totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
baseCost = totalSandwichCost + totalToppingCost;
// orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT)
orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);
// Display orderCost 
System.Console.WriteLine("Order Cost: $"+orderCost);
/*
Output
    orderCost
*/