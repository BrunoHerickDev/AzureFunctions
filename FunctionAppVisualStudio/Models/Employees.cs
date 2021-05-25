using Microsoft.WindowsAzure.Storage.Table;

namespace FunctionAppVisualStudio.Models
{
    public class Employees
    {
        public string MethodName { get; set; }
        public string CheckMethod { get; set; }
        public object[] Entities { get; set; }
        public string Text { get; set; }
        public string TextWord { get; set; }
        public bool IsActive { get; set; }
    }
}
