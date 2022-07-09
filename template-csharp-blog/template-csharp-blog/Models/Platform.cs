namespace template_csharp_blog.Models
{
    public class Platform
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public virtual List<Post> Posts { get; set; }
       
     

    }
}
