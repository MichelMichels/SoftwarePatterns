namespace VisitorSample;
public class NameVisitor : IVisitor
{
    public void VisitCity(City city)
    {
        WriteName(city.Name);
    }

    public void VisitIndustry(Industry industry)
    {
        WriteName(industry.Name);
    }

    private void WriteName(string name)
    {
        Console.WriteLine($"<name>{name}</name>");
    }
}
