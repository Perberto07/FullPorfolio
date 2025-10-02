using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETReact.Shared.DTOs.ContentDto
{
    public class CreateItemDto
    {
        public string Header { get; set; }
        public string? ImageUrl { get; set; }
        public string? TextContent { get; set; }
    }
}
