
namespace NETReact.Shared.Models
{
    public class Content
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public bool IsDeleted { get; set; }
    }
}
