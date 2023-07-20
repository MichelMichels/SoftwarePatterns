namespace VisitorSample;

public interface IVisitor
{
    void VisitCity(City city);
    void VisitIndustry(Industry industry);
}
