using System;

class FinancialForecast
{
    // Recursive method to calculate future value
    public static double CalculateFutureValue(double principal, double rate, int years)
    {
        if (years == 0)
            return principal; // Base case
        return CalculateFutureValue(principal, rate, years - 1) * (1 + rate);
    }

    // Optimized version using memoization (optional)
    public static double CalculateFutureValueMemo(double principal, double rate, int years, double[] memo)
    {
        if (years == 0)
            return principal;

        if (memo[years] != 0)
            return memo[years];

        memo[years] = CalculateFutureValueMemo(principal, rate, years - 1, memo) * (1 + rate);
        return memo[years];
    }

    static void Main()
    {
        double principal = 1000.0;
        double rate = 0.05; // 5% annual growth
        int years = 10;

        Console.WriteLine("Recursive Forecast (No Optimization):");
        double result = CalculateFutureValue(principal, rate, years);
        Console.WriteLine($"Future Value after {years} years: {result:F2}");

        Console.WriteLine("\nOptimized Forecast using Memoization:");
        double[] memo = new double[years + 1];
        double optimizedResult = CalculateFutureValueMemo(principal, rate, years, memo);
        Console.WriteLine($"Future Value after {years} years: {optimizedResult:F2}");
    }
}
