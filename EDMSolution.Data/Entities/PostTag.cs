using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class PostTag
    {
        public int PostID { set; get; }
        public string TagID { set; get; }
        public Tag Tag { set; get; }
        public Post Post { set; get; }
    }
}
