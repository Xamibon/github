using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XAF
{
    public partial class Items : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateItem_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateItem.aspx");      
        }

        protected void SearchItem_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchItem.aspx");
        }
    }
}