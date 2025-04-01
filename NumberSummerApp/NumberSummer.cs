namespace NumberSummerApp;

// Tehdään luokka NumberSummer, jonka tarkoituksena on laskea numerot yhteen listalta
public class NumberSummer
{
    public int SumNumbers(List<int> numbers)
    {
        if (numbers == null)
            throw new ArgumentNullException(nameof(numbers), "Lista ei voi olla tyhjä"); // Error tyhjästä listasta

        int sum = 0;
        
        // käydään foreachilla lista läpi ja lisätään numerot toisiinsa
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum; // palautetaan summa
    }
}
