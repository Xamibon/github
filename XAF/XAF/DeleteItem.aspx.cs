using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XAF
{
    public partial class DeleteItem : System.Web.UI.Page
    {
        int iID;
        LogicManager logicMgr;

        protected void Page_Load(object sender, EventArgs e)
        {
            logicMgr = LogicManager.GetLogicMgrInstance();
        }

        protected void btnDeleteItem_Click(object sender, EventArgs e)
        {
            iID = Convert.ToInt32(txtItemID.Text);

            logicMgr.DeleteOrder(iID);
        }
    }
}