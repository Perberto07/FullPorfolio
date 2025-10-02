

namespace NETReact.Shared.DTOs.ContentDto
{
    public class CreateContentDto
    {
        public string Name { get; set; }
        public List<CreateItemDto> Items { get; set; } = new List<CreateItemDto>();
    }
}
