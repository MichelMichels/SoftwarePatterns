namespace AbstractFactorySample;
public class ModernFurnitureFactory : FurnitureFactory
{
    public override IChair CreateChair()
    {
        return new ModernChair();
    }
}
