namespace Strategy_instructed;

/// <summary>
/// One of interface implementations
/// </summary>
public class CarStrategy : IRouteStrategy
{
    public void CreateRoute(Coordinate start, Coordinate end)
    {
        Console.WriteLine("Car strategy");
    }
}
