using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionAppVisualStudio
{
    public static class QueueCourse
    {
        [FunctionName("QueueCourse")]
        public static void Run([QueueTrigger("course-queue", Connection = "ConnectionStrings:AzureQueueConnection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
