using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETReact.Shared.DTOs.NewsDto
{
    public class NewsApiResponseDto
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<NewsResultDto> Results { get; set; }
    }
}
