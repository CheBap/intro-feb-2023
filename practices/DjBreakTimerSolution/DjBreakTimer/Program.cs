// Iteration 1 
Console.Write("How many minutes is the break? \n");
var breakTime = Console.ReadLine();
var breakAsDouble = double.Parse(breakTime);
Console.Write("How long is the song? \n");
var songLength = Console.ReadLine();
var ts = TimeSpan.Parse(songLength);
var totalMinutes = ts.TotalMinutes;
var endBreakTime = DateTimeOffset.Now.AddMinutes(breakAsDouble);
Console.Write($"At the end of the break, it will be {endBreakTime}\n\n"); 
Console.Write($"The user should start the song at {endBreakTime.AddSeconds(totalMinutes * -1)}\n\n");  

// Iteration 2
var timeRemaining = breakAsDouble;
while (timeRemaining > 0)
{
    Console.Write($"There are {timeRemaining} minutes left in the break\n");
    Thread.Sleep(60000);
    timeRemaining -= 1;
}