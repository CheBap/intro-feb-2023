
using Microsoft.VisualBasic;
using System.Numerics;

namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if(numbers == "")
        {
            return 0;
        }
        else if(!numbers.Contains(",") || !numbers.Contains("\n"))
        {
            return Int32.Parse(numbers);
        }
        else
        {
            int result = 0;
            //string[] x = numbers.Split(',');
            string[] x = numbers.Split(new Char[] { ',', '\n' },
                                 StringSplitOptions.RemoveEmptyEntries);
            foreach (string y in x)
            {
                result += int.Parse(y);
            }
            return result;
        }
    }
}
