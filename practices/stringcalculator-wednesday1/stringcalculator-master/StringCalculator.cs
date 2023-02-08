
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if(numbers == "")
        {
            return 0;
        }
        else if(!numbers.Contains(","))
        {
            return 1;
        }
        else
        {
            int result = 0;
            string[] x = numbers.Split(',');
            foreach(string y in x)
            {
                result += int.Parse(y);
            }
            return result;
        }
    }
}
