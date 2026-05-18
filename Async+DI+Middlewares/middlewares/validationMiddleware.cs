namespace async_DI_middlewares.middlewares
{
    public class validationMiddleware
    {
        private readonly RequestDelegate _next;

        public validationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Before Validation");
            await _next(context);
            Console.WriteLine("After Validation");
        }

    }
}
