using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETReact.Shared.DTOs.ProjectDtos
{
    public class GetProjectDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? VideoLink { get; set; }
        public List<TeckStackDto> TechStacks { get; set; } = new List<TeckStackDto>();
    }
}
