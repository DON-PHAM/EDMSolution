using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Tag
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public List<PostTag> PostTags { set; get; }
    }
}
