using AbstractFactorySample;


List<FurnitureFactory> factories = new()
{
    new ModernFurnitureFactory(),
    new VictorianFurnitureFactory(),
};

foreach (FurnitureFactory factory in factories)
{
    IChair chair = factory.CreateChair();

    Console.WriteLine($"Created a chair of type {chair.GetType().Name}");
}

