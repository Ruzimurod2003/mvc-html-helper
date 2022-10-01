namespace HtmlHelperApp.Models
{
    public class AllProcess
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Enable { get; set; }
        public string Password { get; set; }
        public List<string> Option { get; set; }
    }
}
