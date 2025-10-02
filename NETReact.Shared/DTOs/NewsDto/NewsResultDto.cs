using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETReact.Shared.DTOs.NewsDto
{
    public class NewsResultDto
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Image_Url { get; set; }
        public List<string> Creator { get; set; }
        public string PubDate { get; set; }
        public string Source_Name { get; set; }
        public List<string> Country { get; set; }
        public List<string> Category { get; set; }
    }
}
