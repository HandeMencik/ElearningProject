using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyElearning.DataAccess.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}