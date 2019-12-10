using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tintuc.Models;
using System.Linq;

namespace Tintuc
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Chude> GetChudes()
        {
            var _db = new Tintuc.Models.Context();
            IQueryable<Chude> query = _db.Chudes; return query; }
    }
}