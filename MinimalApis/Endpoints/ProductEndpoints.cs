namespace MinimalApis.Endpoints;

public abstract class ProductEndpoints : IEndpoint
{
    public static void MapEndpoints(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapPost("/products", () => Results.Ok());
    }
}
