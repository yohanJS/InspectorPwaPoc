namespace InspectorPwaPoc.Models
{
    public class Visit
    {
        public string Id { get; set; } = "";
        public string ClientName { get; set; } = "";
        public string ClientPhone { get; set; } = "";
        public string ClientEmail { get; set; } = "";
        public string PropertyAddress { get; set; } = "";
        public string PropertyType { get; set; } = "";
        public string Date { get; set; } = "";
        public string Time { get; set; } = "";
        public string Status { get; set; } = ""; // "upcoming" or "completed"
        public string? Outcome { get; set; }     // "passed" or "issues-found"
        public int? PendingBalance { get; set; }
    }
}