namespace Test;
using NumberSummerApp;

// testaamisessa tärkeää on nimetä testattavat asiat kuvaavasti

public class NumberSummerTest
{
    private readonly NumberSummer _numberSummer = new NumberSummer();

    // Testataan että 1,2,3,4,5 tulos on 15
    [Fact]
    public void SumNumbers_ShouldReturnCorrectSum_WhenListHasNumbers()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        int result = _numberSummer.SumNumbers(numbers);

        Assert.Equal(15, result);
    }
    
    // Testataan negatiiviset luvut
    [Fact]
    public void SumNumbers_HandlesNegativeNumbers()
    {
        var numbers = new List<int> { -1, -2, -3, -4, -5 };
        int result = _numberSummer.SumNumbers(numbers);
        Assert.Equal(-15, result);
    }
    
    // Testataan, että tyhjä listä palauttaa nollan
    [Fact]
    public void SumNumbers_ShouldReturnZero_WhenListIsEmpty()
    {
        var numbers = new List<int>();

        int result = _numberSummer.SumNumbers(numbers);

        Assert.Equal(0, result);
    }
    
    // Testataan, että 0 palauttaa ArgumentNullException-poikkeuksen
    [Fact]
    public void SumNumbers_ShouldThrowArgumentNullException_WhenListIsNull()
    {

        Assert.Throws<ArgumentNullException>(() => _numberSummer.SumNumbers(null)); // Tämä testi on oikein, koska se ei ole async
    }
    
  
}