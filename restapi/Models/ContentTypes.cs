namespace restapi.Models
{
    public class ContentTypes
    {
        private ContentTypes() {}

        public const string Root = "application/com.my-company.my-product.root+json";

        public const string Timesheet = "application/com.my-company.my-product.timesheet+json";

        public const string Timesheets = "application/com.my-company.my-product.timesheets+json";

        public const string TimesheetLine = "application/com.my-company.my-product.timesheet-lines+json";
    
        public const string Transitions = "application/com.my-company.my-product.timesheet-transitions+json";
    
        public const string Error = "application/com.my-company.my-product.simple-error+json";
    }
}