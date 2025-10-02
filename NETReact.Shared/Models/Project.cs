

namespace NETReact.Shared.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Videolink { get; set; }
        public List<TechStack> TechStacks { get; set; } = new List<TechStack> { };
        public bool IsDelete { get; set; } = false;
    }
}
