using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyElearning.DataAccess.Entities
{
    public class CourseRegister
    {
        public int CourseRegisterId { get; set; }

        public int StudentId { get; set; }
        public virtual Student student  { get; set; }

        public int CourseId { get; set; }
        public virtual Course course { get; set; }

        [Column("Date")] //sadece tarih gelicek saat gelmeyecek
        public DateTime RegisterDate { get; set; }
    }
}