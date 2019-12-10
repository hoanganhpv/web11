using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tintuc.Models
{
    public class Tintuc
    {
        [ScaffoldColumn(false)]
        public int Tin_ID { get; set; }
        public string Tieude { get; set; }
        [Required, StringLength(100), Display(Name = "Tiêu đề")]
        public string Noi_dung { get; set; }
        [Required, StringLength(1000), Display(Name = "Nội dung"),         
        DataType(DataType.MultilineText)]
        public string Hinhanh { get; set; }
        public string Ngaygui { get; set; }
        [Display(Name = "Tác giả")]
        public string TenTacgia { get; set; }
        public virtual Tacgia Tacgia { get; set; }
        public int Chude_ID { get; set; }
    }
}