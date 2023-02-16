using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FahrenheitToCelsius(double f)
        {
            
            double Celcius = (f - 32) * 5 / 9;

            return Celcius;
        }
        
        public static double CelsiusToFahrenheit(double c)
        {
            
            double Fahrenheit = (c * 9) / 5 + 32;

            return Fahrenheit;
        }
            
        
    }
}
