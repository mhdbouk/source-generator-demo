namespace MinimalApis.Endpoints;

public abstract class UserEndpoints : IEndpoint
{
    public static void MapEndpoints(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/users", () => "list of users");
        endpoints.MapPost("/users", () => Results.Ok("user created"));
    }
}
