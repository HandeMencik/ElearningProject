﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyElearning.DataAccess.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public string Comment { get; set; }
        public bool Status { get; set; }
    }
}