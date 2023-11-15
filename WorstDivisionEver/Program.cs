// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\n");

//decimal numerator, denominator;
//decimal percentage = 0;

//decimal ScaleTest = 1; // Expect 0
//Console.WriteLine($"Scale of {ScaleTest} is {GetCurrentScale(ScaleTest)}\n");
//ScaleTest = (decimal)0.1; // Expect 1
//Console.WriteLine($"Scale of {ScaleTest} is {GetCurrentScale(ScaleTest)}\n");
//ScaleTest = (decimal)0.11111; // Expect 5
//Console.WriteLine($"Scale of {ScaleTest} is {GetCurrentScale(ScaleTest)}\n");

//Console.WriteLine("Enter Numerator: ");
//decimal.TryParse(Console.ReadLine(), out numerator);
//
//Console.WriteLine("Enter Denominator: ");
//decimal.TryParse(Console.ReadLine(), out denominator);

//decimal percentageGuess = 100;


Console.WriteLine($"Percentage: {GetPercentage((decimal)2355.72, (decimal)2825, (decimal)0.5)}");

decimal GetPercentage(decimal numerator, decimal denominator, decimal percentageGuess)
{
    decimal numeratorOfGuess = denominator * percentageGuess;
    Console.WriteLine($"{denominator} * {percentageGuess} = {numeratorOfGuess} ! {numerator}");
    if (numeratorOfGuess == numerator)
        return percentageGuess;

    if (numeratorOfGuess < numerator)
    {
        return GetPercentage(numerator, denominator, percentageGuess + (GetCurrentScale(percentageGuess) * 1));
    }

    if (numeratorOfGuess > numerator)
    {
        return GetPercentage(numerator, denominator, percentageGuess - ((GetCurrentScale(percentageGuess) * 10) * (decimal)0.1));
    }

    return GetPercentage(numerator, denominator, percentageGuess);
}

decimal GetCurrentScale(decimal percentageGuess)
{
    string guess = percentageGuess.ToString();

    if (!guess.Contains('.'))
        return 1;

    int decimalPoints = guess.Split('.')[1].Length;
    decimal scale = 1;
    for(int i = 0; i < decimalPoints; i++)
    {
        scale *= (decimal)0.1;
    }
    return scale;
}