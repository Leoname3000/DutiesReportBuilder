namespace DutiesReportBuilder.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        List<Duty> duties = new List<Duty>();
        List<Vacation> vacations = new List<Vacation>();
        List<Sickness> sicknesses = new List<Sickness>();
        List<Problem> problems = CorrectnessChecker.check(duties, vacations, sicknesses);
        Assert.Empty(problems);
    }
}