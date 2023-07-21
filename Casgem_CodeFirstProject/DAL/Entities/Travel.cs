using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Travel
    {
        public int TravelID { get; set; }
        public string TravelTitle { get; set; }
        public string TravelContent { get; set; }
        public string TravelImageURL { get; set; }
    }
}