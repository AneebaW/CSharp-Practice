namespace async_DI_middlewares.middlewares
{
    public class authenticateMiddleware
    {
        private readonly RequestDelegate _next;

        public authenticateMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Before Authentication");
            await _next(context);
            Console.WriteLine("After Authentication");
        }
    }
}
