using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tintuc.Models
{
    public class Chude
    {
        [ScaffoldColumn(false)]
        public int Chude_ID { get; set; }
        [Required, StringLength(100), Display(Name = "Chủ đề")]
        public string TenChude { get; set; }
        public virtual ICollection<Tintuc> Tintucs { get; set; }
    }
}