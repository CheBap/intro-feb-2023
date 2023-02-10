using Castle.Core.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator;

public class StringCalculatorInteractionTests
{

    [Theory]
    [InlineData("1,2", "3")]
    [InlineData("1,2,3,4,5,6,7,8,9", "45")]
    public void AnswersAreLoggedToLogger(string numbers, string expected)
    {
        // Given
        var mockedLogger = new Mock<ILogger>();
        var calculator = new StringCalculator(mockedLogger.Object, new Mock<IWebService>().Object); // NEED SOMETHING HERE

        // When
        calculator.Add(numbers);

        // Then
        // I need to verify (assert) that the logger was called with the expected value!
        mockedLogger.Verify(logger => logger.Write(expected), Times.Once);
    }

    [Fact]
    public void WhenLoggerBlowsUpTheWebServiceIsCalled()
    {
        //given
        var stubbedLogger = new Mock<ILogger>();
        stubbedLogger.Setup(m=>m.Write(It.IsAny<string>())).Throws(new LoggerException("Blammo"));
        var mockedWebService = new Mock<IWebService>();
        var calculator = new StringCalculator(stubbedLogger.Object, mockedWebService.Object);

        //when
        calculator.Add("1");

        //then
        //?? the web sersvice should be called
        mockedWebService.Verify(ws =>ws.NotifyOfFailedLogging("Blammo"));
    }
}