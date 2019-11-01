using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanSite.Models
{
    public class UserStory
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public string Story { get; set; }   
        public List<String> StoryComments { get; set; }
    }
}
