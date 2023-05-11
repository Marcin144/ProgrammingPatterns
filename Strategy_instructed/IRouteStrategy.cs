namespace Strategy_instructed;

/// <summary>
/// This is an interfece being implemented to all strategies
/// </summary>
public interface IRouteStrategy
{
    void CreateRoute(Coordinate start, Coordinate end);
}
