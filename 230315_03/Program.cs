string seriesSum (int n) {
    int divisor = 1;
    double output = 0;
    for (int i = 0; i < n; i++)
    {
        output += ((double)1 / divisor);
        divisor += 3;
        Console.WriteLine(divisor);
    }
    return output.ToString("0.00");
}

Console.WriteLine(seriesSum(0));