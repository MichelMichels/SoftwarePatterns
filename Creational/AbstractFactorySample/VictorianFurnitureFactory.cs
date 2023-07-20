namespace AbstractFactorySample;
public class VictorianFurnitureFactory : FurnitureFactory
{
    public override IChair CreateChair()
    {
        return new VictorianChair();
    }
}
