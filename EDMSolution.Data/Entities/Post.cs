using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Post
    {
        public int ID { set; get; }
        public string Alias { set; get; }
        public string Image { set; get; }
        public int CategoryID { set; get; }
        public DateTime CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime ModifiedDate { set; get; }
        public string ModifiedBy { set; get; }
        public Status Status { set; get; }
        public DateTime TopHot { set; get; }
        public string Tags { set; get; }
        public int ViewCount { set; get; }
        public Category Category { set; get; }
        public List<PostTag> PostTags { set; get; }

    }
}
