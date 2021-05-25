using FunctionAppVisualStudio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace FunctionAppVisualStudio.HttpTriggers
{
    public static class FunctionAppVSCommonReturnType
    {
        [FunctionName("FunctionVSCommonReturnType")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Admin, "get", "post", Route = null)] HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");
            string jsonContent = await req.Content.ReadAsStringAsync();
            if (jsonContent != "")
            {
                /*De serailizing json data here*/
                CommonReturnType fdata = JsonConvert.DeserializeObject<CommonReturnType>(jsonContent);
                //string inputMessageJSON = fdata.Employees;
                //Employees msg = JsonConvert.DeserializeObject<Employees>(inputMessageJSON);
                /*De serailizing json data here*/
                if (fdata.Employees.MethodName == "CheckMethod" && fdata.IsCheck == "true")
                {
                    switch (fdata.Employees.Text.ToLower())
                    {
                        case "how_are_you":
                            fdata.Employees.Text = "How are you today";
                            fdata.IsCheck = "true";
                            break;
                        case "good_bye":
                            fdata.Employees.Text = "Good Bye";
                            fdata.IsCheck = "false";
                            break;
                        default:
                            fdata.Employees.Text = "Hi. How may I help you today..!";
                            fdata.IsCheck = "true";
                            break;
                    }
                    var employeesReturn = JsonConvert.SerializeObject(fdata.Employees, Formatting.Indented);
                    return new OkObjectResult(employeesReturn);
                }
            }
            return new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}
