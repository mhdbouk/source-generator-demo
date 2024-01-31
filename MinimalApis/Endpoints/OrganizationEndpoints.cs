namespace MinimalApis.Endpoints;

public abstract class OrganizationEndpoints : IEndpoint
{
    public static void MapEndpoints(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapPut("/organization", () => "Hi");
    }
}
