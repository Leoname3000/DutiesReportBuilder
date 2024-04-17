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

    [Fact]
    public void TestNoIntersections()
    {
        Employee employee = new Employee("Петя");
        Designation designation = new Designation("Raptors");
        TimeInterval dutyInterval = new TimeInterval(new DateTime(2024, 4, 17), new DateTime(2024, 4, 18));
        TimeInterval vacationInterval = new TimeInterval(new DateTime(2024, 4, 19), new DateTime(2024, 4, 20));
        
        List<Duty> duties = new List<Duty>();
        duties.Add(new Duty(employee, designation, dutyInterval));
        List<Vacation> vacations = new List<Vacation>();
        vacations.Add(new Vacation(employee, vacationInterval));
        List<Sickness> sicknesses = new List<Sickness>();

        List<Problem> problems = CorrectnessChecker.check(duties, vacations, sicknesses);
        Assert.Empty(problems);
    }
}