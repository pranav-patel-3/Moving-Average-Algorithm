namespace Moving_Average_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, let's begin, shree ganeshay namah :)..");

            double[] sharePrices = { 1,2,3,4,5 };
            double[] movingAverages = CalculateMovingAverage(sharePrices, 5);

        }
        public static double[] CalculateMovingAverage(double[] prices, int period)
        {
            double[] movingAverages = new double[prices.Length];

            for (int i = period - 1; i < prices.Length; i++)
            {
                double sum = 0;

                for (int j = 0; j < period; j++)
                {
                    sum += prices[i - j];
                }

                movingAverages[i] = sum / period;
            }

            return movingAverages;
        }
    }




}