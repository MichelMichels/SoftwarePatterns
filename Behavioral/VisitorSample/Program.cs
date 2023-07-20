using VisitorSample;

List<Node> nodes = new()
{
    new Industry
    {
        Name = "Microsoft",
        Type = "IT",
    },
    new City
    {
        Name = "Ghent",
        PostalCode = "9000"
    },
};

NameVisitor nameVisitor = new();

foreach (Node node in nodes)
{
    node.Accept(nameVisitor);
}