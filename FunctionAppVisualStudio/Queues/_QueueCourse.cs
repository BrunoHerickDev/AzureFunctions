//using FunctionAppVisualStudio.Models;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Extensions.Logging;
//using Microsoft.WindowsAzure.Storage.Table;
//using Newtonsoft.Json;
//using System;

//namespace FunctionAppVisualStudio
//{
//    public static class QueueCourse
//    {
//        [FunctionName("QueueCourse")] 
//        public static void Run([QueueTrigger("course", Connection = "ConnectionStrings:AzureWebJobsStorage")]string myQueueItem, 
//                                ILogger log,
//                                CloudTable cloudTable)
//        {
//            log.LogInformation($"C# Queue trigger function started.");

//            var data = JsonConvert.DeserializeObject<Course>(myQueueItem);
//            data.PartitionKey = "Course";
//            data.RowKey = Guid.NewGuid().ToString();

//            var tableOperation = TableOperation.Insert(data);
//            cloudTable.ExecuteAsync(tableOperation);

//            log.LogInformation($"C# Queue trigger function finished.");
//        }
//    }
//}
