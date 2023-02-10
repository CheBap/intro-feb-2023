
namespace StringCalculator;

public class StringCalculator
{
    private ILogger _logger;
    private IWebService _webService; //can add iwebservice to logger by doing ctrl+.

    public StringCalculator(ILogger logger, IWebService webService)
    {
        _logger = logger;
        _webService = webService;
    }

    public int Add(string numbers)
    {
        int answer = 0;
        if (numbers == "")
        {

            answer = 0;
        }
        else
        {
            answer = numbers.Split(',', '\n')
                .Select(int.Parse)
                .Sum();
        }
        // WTCYWYH
        try //ctrl k + ctrl s to generate try statement
        {
            _logger.Write(answer.ToString());
        }
        catch (LoggerException ex)
        {
            //write the code you wish you had
            _webService.NotifyOfFailedLogging(ex.Message);
        }


        return answer;
    }
}

public interface ILogger
{
    void Write(string message);
}

public interface IWebService
{
    void NotifyOfFailedLogging(string message);
}


public class LoggerException : ApplicationException
{
    public string Message { get; private set; } = ""; //you can get this but can only set it in here
    public LoggerException(string message)
    {
        Message = message;
    }
}