static int Addition(int numOne, int numTwo)
{
    return numOne + numTwo;
}

static int Subtraction(int numOne, int numTwo)
{
    return numOne - numTwo;
}

static int Multiplication(int numOne, int numTwo)
{
    return numOne * numTwo;
}

static decimal Division(decimal numOne, decimal numTwo)
{
    return numOne / numTwo;
}


Console.WriteLine(Addition(1, 2));
Console.WriteLine(Subtraction(1, 2));
Console.WriteLine(Multiplication(1, 2));
Console.WriteLine(Division(1, 2));