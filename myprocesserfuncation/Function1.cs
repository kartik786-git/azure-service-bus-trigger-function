using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace myprocesserfuncation
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([ServiceBusTrigger("mynewqueue", Connection = "myqueuecs")]string myQueueItem, ILogger log)
        {
            
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }

        [FunctionName("Function2")]
        public void Run1([ServiceBusTrigger("mysecondqueue", Connection = "myqueuecs")] string myQueueItem, ILogger log)
        {
 
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
