using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DVMSWebApi.Models
{
    public class visitorCarType
    {
        //public visitorCarType()
        //{
        //    trans = new HashSet<trans>();
        //}
        [Key]
        public int visitorCarType_ID { get; set; }
        public string visitorCarType_Name { get; set; }
        public string visitorCarType_Comment { get; set; }

        //public virtual ICollection<trans> trans { get; set; }
    }
}
