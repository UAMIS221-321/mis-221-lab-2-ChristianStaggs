
int numberOfSandwiches = GetNumberSandwiches();
int numberOfToppings = GetNumberToppings();
double tip = GetTip();
const double costOfSandwich = 4.75;
const double costOfTopping = .55;
const double discount = .10;
double totalCostOfSandwich = TotalCostOfSandwich(costOfSandwich, numberOfSandwiches);
double totalCostOfToppings = TotalCostOfToppings(costOfTopping, numberOfSandwiches);
double baseCost = totalCostOfSandwich + totalCostOfToppings;
double orderCost = GetOrderCost(tip, baseCost, discount);
Console.WriteLine ("Your total is " + Math.Round(orderCost,2));

static int GetNumberSandwiches() {
Console.WriteLine("How many sandwiches?");
return int.Parse(Console.ReadLine());
}

static int GetNumberToppings() {
Console.WriteLine("How many toppings?");
return int.Parse(Console.ReadLine());
}

static double TotalCostOfSandwich(double costOfSandwich, int numberOfSandwiches) {

   return costOfSandwich * numberOfSandwiches;
}

static double TotalCostOfToppings(double costOfTopping, int numberOfSandwiches) {
    return costOfTopping * numberOfSandwiches;
}

static double GetTip() {
    Console.WriteLine("How much would you like to tip?");
    return double.Parse(Console.ReadLine());
}

static double GetOrderCost(double tip, double baseCost, double discount){

    return baseCost*(1-discount) + tip;
    
}
