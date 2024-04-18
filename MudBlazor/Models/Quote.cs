namespace MudBlazor.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public String? Author { get; set; }
        public String? Tags { get; set; }
        public String? QuoteText { get; set; }
        public string Action { get; set; }

    }
    public class TagsModel
    {
        public int Id { get; set; }
        public string tags { get; set; }
    }
    public class QuotesModel
    {
        public int Id { get; set; }
        public string quotes { get; set; }
    }
}
