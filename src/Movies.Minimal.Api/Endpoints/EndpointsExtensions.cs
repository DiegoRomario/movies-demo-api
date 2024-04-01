using Movies.Minimal.Api.Endpoints.Movies;
using Movies.Minimal.Api.Endpoints.Ratings;

namespace Movies.Minimal.Api.Endpoints;

public static class EndpointsExtensions
{
    public static IEndpointRouteBuilder MapApiEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapMovieEndpoints();
        app.MapRatingEndpoints();
        return app;
    }
}
