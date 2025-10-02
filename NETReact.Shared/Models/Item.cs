using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETReact.Shared.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Header { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string? TextContent { get; set; }

    }
}
