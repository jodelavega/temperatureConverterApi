namespace HistoryApi.Models
{
    public class History
    {
        public int Id { get; set; }
        public string? InputType { get; set; }
        public float InputValue { get; set; }
        public string? OutputType { get; set; }
        public float OutputValue { get; set; }
    }
}
