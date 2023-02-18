namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = TempConverter.FahrenheitToCelsius(100.00);
            Console.WriteLine(answer);

            var answer2 = TempConverter.CelsiusToFahrenheit(0);
            Console.WriteLine(answer2);
        }

        

    }
}
