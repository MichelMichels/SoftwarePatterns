namespace VisitorSample;
public class Industry : Node
{
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;

    public override void Accept(IVisitor visitor)
    {
        visitor.VisitIndustry(this);
    }
}
