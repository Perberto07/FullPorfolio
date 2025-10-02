using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETReact.Shared.DTOs.NewsDto
{
    public class NewsArticleDto
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Creator { get; set; }
        public string PubDate { get; set; }
        public string SourceName { get; set; }
        public List<string> Country { get; set; }
        public List<string> Category { get; set; }
    }
}
