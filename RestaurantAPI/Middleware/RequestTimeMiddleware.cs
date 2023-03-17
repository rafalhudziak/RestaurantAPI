using System.Diagnostics;

namespace RestaurantAPI.Middleware
{
    public class RequestTimeMiddleware : IMiddleware
    {
        private ILogger<RequestTimeMiddleware> _Logger;
        private Stopwatch _StopWatch;

        public RequestTimeMiddleware(ILogger<RequestTimeMiddleware> logger)
        {
            _Logger = logger;
            _StopWatch = new Stopwatch();
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            _StopWatch.Start();
           await next.Invoke(context);
            _StopWatch.Stop();

            var elapsedMiliseconds = _StopWatch.ElapsedMilliseconds;

            if(elapsedMiliseconds / 1000 > 4)
            {
                var message = $"Request[{context.Request.Method}] at {context.Request.Path} took {elapsedMiliseconds} ms";

                _Logger.LogInformation(message);
            }
        }
    }
}
