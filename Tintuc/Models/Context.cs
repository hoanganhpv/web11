using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Tintuc.Models
{
    public class Context : DbContext
    {
        public Context() : base("Tintuc") { }
        public DbSet<Tacgia> Tacgias { get; set; }
        public DbSet<Tintuc> Tintucs { get; set; }
        public DbSet<Chude> Chudes { get; set; }
    }
}