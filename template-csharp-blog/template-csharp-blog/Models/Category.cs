namespace template_csharp_blog.Models
{
    public class Category
    {
     public int Id { get; set; }
     public string Name { get; set; } // should this be an enum?
     public virtual List<Post> posts { get; set; }





    }
}
