using NETReact.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETReact.Shared.DTOs.ProjectDtos
{
    public class CreateProjectDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? VideoLink { get; set; }
        public List<TeckStackDto> TechStacks { get; set; } = new List<TeckStackDto>();
    }
}
