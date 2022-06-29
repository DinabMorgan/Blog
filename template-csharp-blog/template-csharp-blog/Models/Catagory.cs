namespace template_csharp_blog.Models
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Catagory> Catagories { get; set; }


        public Catagory()
        {

        }

   

    }
}
