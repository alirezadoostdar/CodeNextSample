using Microsoft.AspNetCore.Http.HttpResults;

namespace Options_Pattern
{
    public static class SmsEndpoints
    {
        public static void MapSmsEndpoits(this IEndpointRouteBuilder endpoint)
        {
            endpoint.MapGet("/GetSmsToken", (SmsService smsService) =>
            {
                return Results.Ok(smsService.Send("test"));
            });
        }
    }
}
