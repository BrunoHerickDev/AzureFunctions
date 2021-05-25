using Microsoft.WindowsAzure.Storage.Table;

namespace FunctionAppVisualStudio.Models
{
    public class Course : TableEntity
    {
        public string Name { get; set; }        
    }
}
