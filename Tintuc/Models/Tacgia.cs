using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tintuc.Models
{
    public class Tacgia
    {
        [ScaffoldColumn(false)]
        public int TGia_ID { get; set; }
        [Required, StringLength(100), Display(Name = "Tác giả")]
        public string TenTacgia { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Tintuc> Tintucs { get; set; }
    }
}