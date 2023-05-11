namespace Strategy_instructed;

public class WalkStrategy : IRouteStrategy
{
    public void CreateRoute(Coordinate start, Coordinate end)
    {
        Console.WriteLine("Walk strategy");
    }
}
