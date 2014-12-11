namespace FizzBuzz
{
    public class FizzBuzzImpl : IFizzBuzzKata
    {
       string IFizzBuzzKata.Answer(int number)
       {
          return number.Fizz()
                       .Buzz(number)
                       .OrNumber(number);
       }
    }

    public static class Ext
    {
       public static string Fizz(this int number)
       {
          return (number%3).Equals(0)
             ? "fizz"
             : "";
       }

       public static string Buzz(this string s,int number)
       {
          return (number % 5).Equals(0)
             ? s + "buzz"
             : s;
       }

       public static string OrNumber(this string s, int number)
       {
          return string.IsNullOrEmpty(s)
             ? number.ToString()
             : s;
       }
    }

    public interface IFizzBuzzKata
    {
       /// <summary>
       /// Give an answer to the current game
       /// </summary>
       /// <param name="number">current number in the game sequence</param>
       /// <returns>appropriate answer to the current number</returns>
       string Answer(int number);
    }
}
