using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FunctionAppOutoutNet5
{
    public static class Function2
    {
        [Function("Function2")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "")] string myQueueItem,
            FunctionContext context)
        {
            var logger = context.GetLogger("Function2");
            logger.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
