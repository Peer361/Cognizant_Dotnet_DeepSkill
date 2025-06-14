using System;

class Forecast {
    public static double PredictGrowth(double currentValue, double rate, int years) {
        if (years == 0) return currentValue;
        return PredictGrowth(currentValue * (1 + rate), rate, years - 1);
    }

    public static double PredictGrowthMemo(double currentValue, double rate, int years, double[] memo) {
        if (years == 0) return currentValue;
        if (memo[years] != 0) return memo[years];
        return memo[years] = PredictGrowthMemo(currentValue * (1 + rate), rate, years - 1, memo);
    }

    public static void Main() {
        double result = PredictGrowth(1000, 0.1, 5);
        Console.WriteLine($"Recursive Result: {result}");

        double[] memo = new double[6];
        double resultMemo = PredictGrowthMemo(1000, 0.1, 5, memo);
        Console.WriteLine($"Memoized Result: {resultMemo}");
    }
}
