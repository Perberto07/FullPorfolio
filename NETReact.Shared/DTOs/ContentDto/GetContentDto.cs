using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETReact.Shared.DTOs.ContentDto
{
    public class GetContentDto
    {
        public string Name { get; set; }
        public List<CreateItemDto> Items { get; set; } = new List<CreateItemDto>();
    }
}
