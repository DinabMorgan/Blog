namespace template_csharp_blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<Catagory> Catagories { get; set; }
        public string Name { get; set; }
        
        public DateTime DateTime { get; set; }
    }
}
