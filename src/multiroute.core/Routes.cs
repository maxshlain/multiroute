namespace multiroute.core;

public class Routes
{
    public string Editor { get; set; }
    public RouteConfig Default { get; set; }
    public Dictionary<string, RouteConfig> Rules { get; set; }
}
