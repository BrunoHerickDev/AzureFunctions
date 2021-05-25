using Microsoft.WindowsAzure.Storage.Table;

namespace FunctionAppVisualStudio.Models
{
    public class CommonReturnType
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Employees Employees { get; set; }
        public string IsCheck { get; set; }
    }
}
