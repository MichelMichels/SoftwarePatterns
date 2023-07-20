namespace VisitorSample;
public class City : Node
{
    public string Name { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;

    public override void Accept(IVisitor visitor)
    {
        visitor.VisitCity(this);
    }
}
