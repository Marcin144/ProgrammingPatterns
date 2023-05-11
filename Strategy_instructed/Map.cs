namespace Strategy_instructed;

/// <summary>
/// Class performing work.
/// Gets proper interface implementation in constructor.
/// </summary>
public class Map
{
    private readonly IRouteStrategy _routeStrategy;

    public Map(IRouteStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }

    public void CreateRoute(Coordinate start, Coordinate end)
    {
        _routeStrategy.CreateRoute(start, end);
    }
}
