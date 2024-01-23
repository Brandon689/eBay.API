namespace eBay.API.Facade
{
    public class LoggingHandler : DelegatingHandler
    {
        public LoggingHandler(HttpMessageHandler innerHandler)
            : base(innerHandler)
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Log the request information
            var requestInfo = $"{request.Method} {request.RequestUri}";
            var requestHeaders = request.Headers.ToString();

            string requestBody = "";
            if (request.Content != null)
            {
                //requestBody = await request.Content.ReadAsStringAsync();
                // Log request body here
            }

            // Log it somewhere
            Console.WriteLine(requestInfo);
            Console.WriteLine(requestHeaders);
            Console.WriteLine(requestBody);

            // Call the inner handler.
            var response = await base.SendAsync(request, cancellationToken);

            return response;
        }
    }


}
