using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EXAM2019.Models
{
    public class ClassStudent
    {
        [Key]
        public long ClassID { get; set; }
        public string NameClass { get; set; }
        [ForeignKey("StudentID")]
        public Student student { get; set; }
    }
}
