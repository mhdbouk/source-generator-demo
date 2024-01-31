namespace MinimalApis.Endpoints;

public interface IEndpoint
{
    static abstract void MapEndpoints(IEndpointRouteBuilder endpoints);
}
