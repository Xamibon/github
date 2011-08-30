using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XAF
{
    public partial class Suppliers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateSupplier_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateSupplier.aspx");
        }

        protected void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchSupplier.aspx");
        }
    }
}