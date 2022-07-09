namespace template_csharp_blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CatagoryId  { get; set; }    
        public virtual Catagory Catagory { get; set; }
        public string Author { get; set; }
        public string Thoughts { get; set; }
        public bool IsRewatchable { get; set; }
        public  int Rating { get; set; }
        public DateTime DateTime { get; set; }
        public virtual Platform Platform { get; set; }
        public int PlatformId { get; set; }
    }
}
