namespace NetPokedex.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public String Text { get; set; }
        public Reviewer Reviewer { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
