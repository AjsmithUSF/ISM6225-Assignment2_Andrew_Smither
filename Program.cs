// Combined programs for Questions 1 through 10.
// Each program is commented out.
// To run a question, remove only its opening /* and closing */ markers.

// Question 1 Subscription Revenue Calculator
/*
Console.Write("Enter the current number of customers: ");
string customerCountInput = Console.ReadLine() ?? "";

Console.Write("Enter the monthly price per customer: ");
string monthlyPriceInput = Console.ReadLine() ?? "";

Console.Write("Enter the percentage price increase: ");
string percentageIncreaseInput = Console.ReadLine() ?? "";

try
{
    int currentNumberOfCustomers = Convert.ToInt32(customerCountInput);
    decimal monthlyPricePerCustomer = Convert.ToDecimal(monthlyPriceInput);
    decimal percentagePriceIncrease = Convert.ToDecimal(percentageIncreaseInput);

    if (currentNumberOfCustomers < 0 || monthlyPricePerCustomer < 0)
    {
        Console.WriteLine("Error: The number of customers and monthly price cannot be negative.");
    }
    else
    {
        decimal currentMonthlyRevenue = currentNumberOfCustomers * monthlyPricePerCustomer;
        decimal priceIncreaseMultiplier = percentagePriceIncrease / 100m;
        decimal dollarIncrease = currentMonthlyRevenue * priceIncreaseMultiplier;
        decimal projectedMonthlyRevenue = currentMonthlyRevenue + dollarIncrease;

        Console.WriteLine($"Current monthly revenue: {currentMonthlyRevenue:C2}");
        Console.WriteLine($"Projected monthly revenue: {projectedMonthlyRevenue:C2}");
        Console.WriteLine($"Dollar Change: {dollarIncrease:C2}");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Enter valid numeric values for all inputs.");
}
catch (OverflowException)
{
    Console.WriteLine("Error: One or more inputs are outside the supported numeric range.");
}
*/
// Question 2 Investment Doubling Time
/*
Console.Write("Enter the annual return rate (percentage): ");
try
{
    double ratePercent = Convert.ToDouble(Console.ReadLine());

    if (ratePercent <= 0)
    {
        Console.WriteLine("The annual return rate must be greater than zero.");
    }
    else
    {
        double rate = ratePercent / 100;
        double doublingTime = Math.Log(2) / Math.Log(1 + rate);

        Console.WriteLine($"Doubling time: {doublingTime:F2} years");

        if (doublingTime < 10)
        {
            Console.WriteLine("Classification: Fast");
        }
        else if (doublingTime <= 20)
        {
            Console.WriteLine("Classification: Moderate");
        }
        else
        {
            Console.WriteLine("Classification: Slow");
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Please enter a valid number for the annual return rate.");
}
catch (OverflowException)
{
    Console.WriteLine("The entered rate is too large or too small to process.");
}
*/
// Question 3 Delivery Region Triangle
/*
Console.Write("Enter side a: ");
string? inputA = Console.ReadLine();
Console.Write("Enter side b: ");
string? inputB = Console.ReadLine();
Console.Write("Enter side c: ");
string? inputC = Console.ReadLine();

try
{
    double a = Convert.ToDouble(inputA);
    double b = Convert.ToDouble(inputB);
    double c = Convert.ToDouble(inputC);

    if (!(a > 0) || !(b > 0) || !(c > 0))
    {
        Console.WriteLine("Invalid triangle: all side lengths must be positive.");
    }
    else if (a + b <= c || a + c <= b || b + c <= a)
    {
        Console.WriteLine("Invalid triangle: the sum of each pair of sides must be greater than the remaining side.");
    }
    else
    {
        double s = (a + b + c) / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        Console.WriteLine($"The area of the triangle is {area}.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid input: please enter numeric side lengths.");
}
catch (OverflowException)
{
    Console.WriteLine("Invalid input: the side length is outside the supported numeric range.");
}
*/
// Question 4 Cloud Usage Invoice
/*
decimal hours = -1;
bool validInput = false;

while (!validInput)
{
    Console.Write("Enter the number of compute hours used: ");
    string? input = Console.ReadLine();

    try
    {
        hours = Convert.ToDecimal(input);
        if (hours < 0)
        {
            Console.WriteLine("Hours cannot be negative. Please try again.");
        }
        else
        {
            validInput = true;
        }
    }
    catch
    {
        Console.WriteLine("Please enter a valid number of hours.");
    }
}

decimal usageCharge;

if (hours <= 100)
{
    usageCharge = hours * 0.12m;
}
else if (hours <= 500)
{
    usageCharge = 100 * 0.12m + (hours - 100) * 0.09m;
}
else
{
    usageCharge = 100 * 0.12m + 400 * 0.09m + (hours - 500) * 0.06m;
}

decimal serviceFee = usageCharge * 0.05m;
decimal totalInvoice = usageCharge + serviceFee;

Console.WriteLine($"Usage charge: {usageCharge:C2}");
Console.WriteLine($"Service fee (5%): {serviceFee:C2}");
Console.WriteLine($"Total invoice: {totalInvoice:C2}");
*/
// Question 5 Daily Sales Entry with a Sentinel
/*
double saleAmount = 0;
double totalSales = 0;
double averageSale;
int validSalesCount = 0;

while (saleAmount != -1)
{
    Console.Write("Enter a sale amount (-1 to finish): ");

    try
    {
        saleAmount = Convert.ToDouble(Console.ReadLine());

        if (saleAmount == -1)
        {
            continue;
        }

        if (saleAmount < 0)
        {
            Console.WriteLine("Invalid amount. Enter zero or a positive amount.");
        }
        else
        {
            totalSales += saleAmount;
            validSalesCount++;
        }
    }
    catch
    {
        Console.WriteLine("Invalid input. Enter a numeric amount.");
    }
}

if (validSalesCount == 0)
{
    Console.WriteLine("No valid sales were entered.");
}
else
{
    averageSale = totalSales / validSalesCount;
    Console.WriteLine($"Number of valid sales: {validSalesCount}");
    Console.WriteLine($"Total sales: {totalSales}");
    Console.WriteLine($"Average sale: {averageSale}");
}
*/
// Question 6 Investment Payback Simulator
/*
decimal initialInvestment = 0;
while (initialInvestment <= 0)
{
    Console.Write("Enter a positive initial investment: ");
    try
    {
        initialInvestment = Convert.ToDecimal(Console.ReadLine());
        if (initialInvestment <= 0)
        {
            Console.WriteLine("The investment must be greater than zero.");
        }
    }
    catch
    {
        initialInvestment = 0;
        Console.WriteLine("Invalid input. Enter a positive number.");
    }
}

decimal monthlyBenefit = 0;
while (monthlyBenefit <= 0)
{
    Console.Write("Enter a positive expected monthly benefit: ");
    try
    {
        monthlyBenefit = Convert.ToDecimal(Console.ReadLine());
        if (monthlyBenefit <= 0)
        {
            Console.WriteLine("The monthly benefit must be greater than zero.");
        }
    }
    catch
    {
        monthlyBenefit = 0;
        Console.WriteLine("Invalid input. Enter a positive number.");
    }
}

decimal cumulativeBenefits = 0;
decimal unrecoveredBalance = initialInvestment;
int month = 0;

while (cumulativeBenefits < initialInvestment && month < 600)
{
    month++;
    cumulativeBenefits += monthlyBenefit;
    unrecoveredBalance = initialInvestment - cumulativeBenefits;

    if (unrecoveredBalance < 0)
    {
        unrecoveredBalance = 0;
    }

    Console.WriteLine($"Month {month}: Unrecovered balance = {unrecoveredBalance:C}");
}

if (cumulativeBenefits >= initialInvestment)
{
    Console.WriteLine($"Payback month: {month}");
    Console.WriteLine($"Cumulative benefits at payback: {cumulativeBenefits:C}");
}
else
{
    Console.WriteLine("The investment was not recovered within 600 months.");
}
*/
// Question 7 Weekly Demand Bar Chart
/*
int[] demand = new int[7];

for (int i = 0; i < demand.Length; i++)
{
    bool validInput = false;

    while (!validInput)
    {
        Console.Write($"Enter demand for day {i + 1}: ");

        try
        {
            int value = Convert.ToInt32(Console.ReadLine());

            if (value >= 0)
            {
                demand[i] = value;
                validInput = true;
            }
            else
            {
                Console.WriteLine("Demand must be zero or greater.");
            }
        }
        catch
        {
            Console.WriteLine("Enter a valid whole number.");
        }
    }
}

Console.WriteLine();
Console.WriteLine("Demand chart:");

for (int i = 0; i < demand.Length; i++)
{
    Console.Write($"Day {i + 1}, Demand: {demand[i]}: ");

    for (int j = 0; j < demand[i] / 10; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
*/
// Question 8 Customer Risk Score Method
/*
Console.WriteLine("Customer Retention Risk Score");

int missedPayments = 0;
bool validInput = false;
while (!validInput)
{
    Console.Write("Enter missed payments: ");
    string input = Console.ReadLine();
    try
    {
        if (input == null)
        {
            Console.WriteLine("Input is required.");
        }
        else
        {
            missedPayments = Convert.ToInt32(input);
            if (missedPayments < 0)
            {
                Console.WriteLine("Enter a nonnegative number.");
            }
            else
            {
                validInput = true;
            }
        }
    }
    catch
    {
        Console.WriteLine("Enter a whole number.");
    }
}

int supportTickets = 0;
validInput = false;
while (!validInput)
{
    Console.Write("Enter support tickets: ");
    string input = Console.ReadLine();
    try
    {
        if (input == null)
        {
            Console.WriteLine("Input is required.");
        }
        else
        {
            supportTickets = Convert.ToInt32(input);
            if (supportTickets < 0)
            {
                Console.WriteLine("Enter a nonnegative number.");
            }
            else
            {
                validInput = true;
            }
        }
    }
    catch
    {
        Console.WriteLine("Enter a whole number.");
    }
}

int monthsInactive = 0;
validInput = false;
while (!validInput)
{
    Console.Write("Enter months inactive: ");
    string input = Console.ReadLine();
    try
    {
        if (input == null)
        {
            Console.WriteLine("Input is required.");
        }
        else
        {
            monthsInactive = Convert.ToInt32(input);
            if (monthsInactive < 0)
            {
                Console.WriteLine("Enter a nonnegative number.");
            }
            else
            {
                validInput = true;
            }
        }
    }
    catch
    {
        Console.WriteLine("Enter a whole number.");
    }
}

int riskScore = ComputeRiskScore(missedPayments, supportTickets, monthsInactive);
string classification;

if (riskScore < 30)
{
    classification = "Low";
}
else if (riskScore < 60)
{
    classification = "Moderate";
}
else
{
    classification = "High";
}

Console.WriteLine("Risk score: " + riskScore);
Console.WriteLine("Classification: " + classification);

int ComputeRiskScore(int missedPayments, int supportTickets, int monthsInactive)
{
    return missedPayments * 20 + supportTickets * 5 + monthsInactive * 8;
}
*/
// Question 9 Transaction Anomaly Screening
/*
int transactionCount = 0;
bool validCount = false;

while (!validCount)
{
    Console.Write("How many transaction amounts will be entered? (3 through 20): ");

    try
    {
        transactionCount = Convert.ToInt32(Console.ReadLine());

        if (transactionCount >= 3 && transactionCount <= 20)
        {
            validCount = true;
        }
        else
        {
            Console.WriteLine("Enter a whole number from 3 through 20.");
        }
    }
    catch
    {
        Console.WriteLine("Enter a whole number from 3 through 20.");
    }
}

decimal[] amounts = new decimal[transactionCount];

for (int i = 0; i < transactionCount; i++)
{
    bool validAmount = false;

    while (!validAmount)
    {
        Console.Write("Enter transaction amount " + (i + 1) + ": ");

        try
        {
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            if (amount >= 0)
            {
                amounts[i] = amount;
                validAmount = true;
            }
            else
            {
                Console.WriteLine("Transaction amounts cannot be negative.");
            }
        }
        catch
        {
            Console.WriteLine("Enter a valid numeric amount.");
        }
    }
}

decimal minimum = amounts[0];
decimal maximum = amounts[0];
decimal total = 0;

for (int i = 0; i < transactionCount; i++)
{
    if (amounts[i] < minimum)
    {
        minimum = amounts[i];
    }

    if (amounts[i] > maximum)
    {
        maximum = amounts[i];
    }

    total = total + amounts[i];
}

decimal mean = total / transactionCount;
decimal reviewThreshold = 1.5m * mean;

Console.WriteLine();
Console.WriteLine("Summary statistics");
Console.WriteLine("Minimum: " + minimum);
Console.WriteLine("Maximum: " + maximum);
Console.WriteLine("Total: " + total);
Console.WriteLine("Mean: " + mean);
Console.WriteLine();
Console.WriteLine("Transaction results");

for (int i = 0; i < transactionCount; i++)
{
    if (amounts[i] > reviewThreshold)
    {
        Console.WriteLine("Transaction " + (i + 1) + ": " + amounts[i] + " - Review");
    }
    else
    {
        Console.WriteLine("Transaction " + (i + 1) + ": " + amounts[i] + " - Normal");
    }
}
*/
// Question 10 Seven Day Performance Summary
/*
decimal[] sales = new decimal[7];

for (int day = 0; day < sales.Length; day++)
{
    bool validSales = false;

    while (!validSales)
    {
        Console.Write($"Enter sales for day {day + 1}: ");

        try
        {
            string? input = Console.ReadLine();

            // Revised after testing: stop on end-of-input instead of treating missing values as zero.
            if (input == null)
            {
                Console.WriteLine("Input ended before all seven sales values were entered.");
                return;
            }

            decimal value = Convert.ToDecimal(input);

            if (value < 0)
            {
                Console.WriteLine("Sales cannot be negative. Please try again.");
            }
            else
            {
                sales[day] = value;
                validSales = true;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a numeric sales value.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("That value is too large. Please try again.");
        }
    }
}

decimal totalSales = CalculateTotalSales(sales);
decimal averageSales = CalculateAverageSales(totalSales, sales.Length);
decimal highestSales = CalculateHighestSales(sales);
decimal lowestSales = CalculateLowestSales(sales);
int daysAboveAverage = CountDaysAboveAverage(sales, averageSales);

Console.WriteLine();
Console.WriteLine("Daily Sales");
for (int day = 0; day < sales.Length; day++)
{
    Console.WriteLine($"Day {day + 1}: {sales[day]:C}");
}

Console.WriteLine();
Console.WriteLine($"Total sales: {totalSales:C}");
Console.WriteLine($"Average sales: {averageSales:C}");
Console.WriteLine($"Highest sales: {highestSales:C}");
Console.WriteLine($"Lowest sales: {lowestSales:C}");
Console.WriteLine($"Days above average: {daysAboveAverage}");

if (daysAboveAverage >= 4)
{
    Console.WriteLine("Week classification: Strong");
}
else if (daysAboveAverage >= 2)
{
    Console.WriteLine("Week classification: Balanced");
}
else
{
    Console.WriteLine("Week classification: Concentrated");
}

decimal CalculateTotalSales(decimal[] dailySales)
{
    decimal total = 0;

    for (int day = 0; day < dailySales.Length; day++)
    {
        total += dailySales[day];
    }

    return total;
}

decimal CalculateAverageSales(decimal total, int numberOfDays)
{
    return total / numberOfDays;
}

decimal CalculateHighestSales(decimal[] dailySales)
{
    decimal highest = dailySales[0];

    for (int day = 1; day < dailySales.Length; day++)
    {
        if (dailySales[day] > highest)
        {
            highest = dailySales[day];
        }
    }

    return highest;
}

decimal CalculateLowestSales(decimal[] dailySales)
{
    decimal lowest = dailySales[0];

    for (int day = 1; day < dailySales.Length; day++)
    {
        if (dailySales[day] < lowest)
        {
            lowest = dailySales[day];
        }
    }

    return lowest;
}

int CountDaysAboveAverage(decimal[] dailySales, decimal average)
{
    int count = 0;

    for (int day = 0; day < dailySales.Length; day++)
    {
        if (dailySales[day] > average)
        {
            count++;
        }
    }

    return count;
}
*/
