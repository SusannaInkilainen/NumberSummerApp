namespace NumberSummerApp;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Anna numeroita pilkulla erotettuna (esim. 1,2,3,4,5):");
        string input = Console.ReadLine();

        try
        {
            List<int> numbers = input
                .Split(',', StringSplitOptions.RemoveEmptyEntries)  // Erotetaan numerot pilkulla
                .Select(n => int.Parse(n.Trim()))                   // Muunnetaan numerot kokonaisluvuiksi
                .ToList();

            var summer = new NumberSummer();
            int sum = summer.SumNumbers(numbers);

            Console.WriteLine($"Numeroiden summa: {sum}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Virheellinen syöte! Varmista, että annat vain numeroita pilkulla erotettuna.");
        }
    }
}