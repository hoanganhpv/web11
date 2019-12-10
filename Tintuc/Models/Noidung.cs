using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Tintuc.Models
{
    public class Noidung : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            GetChudes().ForEach(c => context.Chudes.Add(c));
            GetTintucs().ForEach(p => context.Tintucs.Add(p));
        }
        private static List<Chude> GetChudes()
        {
            var chudes = new List<Chude> {
                new Chude
                {
                    Chude_ID = 1,
                    TenChude = "Đời sống"
                },
                new Chude
                {
                    Chude_ID = 2,
                    TenChude = "Giáo dục"
                },
                new Chude
                {
                    Chude_ID = 3,
                    TenChude = "Giải trí"
                },
                new Chude
                {
                    Chude_ID = 4,
                    TenChude = "Thể thao"
                },
        }; return chudes; }
        private static List<Tintuc> GetTintucs()
        {
            var tintucs = new List<Tintuc> {
                new Tintuc
                {
                    Tin_ID = 1,
                    Tieude ="",
                    Noi_dung = "",
                    Hinhanh ="",
                    Ngaygui ="",
                    TenTacgia="",
                    Chude_ID = 1
                },
                new Tintuc
                {
                    Tin_ID = 2,
                    Tieude ="",
                    Noi_dung = "",
                    Hinhanh ="",
                    Ngaygui ="",
                    TenTacgia="",
                    Chude_ID = 1
                },
                new Tintuc
                {
                    Tin_ID = 3,
                    Tieude ="",
                    Noi_dung = "",
                    Hinhanh ="",
                    Ngaygui ="",
                    TenTacgia="",
                    Chude_ID = 2
                },
                new Tintuc
                {
                    Tin_ID = 4,
                    Tieude ="",
                    Noi_dung = "",
                    Hinhanh ="",
                    Ngaygui ="",
                    TenTacgia="",
                    Chude_ID = 2
                },
                 new Tintuc
                {
                    Tin_ID = 5,
                    Tieude ="",
                    Noi_dung = "",
                    Hinhanh ="",
                    Ngaygui ="",
                    TenTacgia="",
                    Chude_ID = 3
                },
                  new Tintuc
                {
                    Tin_ID = 6,
                    Tieude ="",
                    Noi_dung = "",
                    Hinhanh ="",
                    Ngaygui ="",
                    TenTacgia="",
                    Chude_ID = 3
                },
                   new Tintuc
                {
                    Tin_ID = 7,
                    Tieude ="",
                    Noi_dung = "",
                    Hinhanh ="",
                    Ngaygui ="",
                    TenTacgia="",
                    Chude_ID = 4
                },
                    new Tintuc
                {
                    Tin_ID = 8,
                    Tieude ="",
                    Noi_dung = "",
                    Hinhanh ="",
                    Ngaygui ="",
                    TenTacgia="",
                    Chude_ID = 4
                },
            }; return tintucs;
        }
    }
}