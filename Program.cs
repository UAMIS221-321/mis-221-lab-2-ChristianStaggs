
int numberOfSandwiches = GetNumberSandwiches();
int numberOfToppings = GetNumberToppings();
double tip = GetTip();
const double costOfSandwich = 4.75;
const double costOfTopping = .55;
const double discount = .10;
double totalCostOfSandwich = TotalCostOfSandwich();
double totalCostOfToppings = TotalCostOfToppings();
double baseCost = totalCostOfSandwich + totalCostOfToppings;

static int GetNumberSandwiches() {
Console.WriteLine("How many sandwiches?");
return int.Parse(Console.ReadLine());
}

static int GetNumberToppings() {
Console.WriteLine("How many toppings?");
return int.Parse(Console.ReadLine());
}

static double TotalCostOfSandwich() {
    costOfSandwich * numberOfSandwiches
}

static double TotalCostOfToppings() {
    costOfTopping * numberOfSandwiches
}

static double GetTip() {
    Console.WriteLine("What percentage would you like to tip?");
    return int.Parse(Console.ReadLine());
}

static double OrderCost(){
    return (tip + baseCost(1-discount));
}
