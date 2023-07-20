namespace VisitorSample;
public abstract class Node
{
    public abstract void Accept(IVisitor visitor);
}
