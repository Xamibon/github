using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XAF
{
    public partial class DeleteOrder : System.Web.UI.Page
    {
        int oID;
        LogicManager logicMgr;

        protected void Page_Load(object sender, EventArgs e)
        {
            logicMgr = LogicManager.GetLogicMgrInstance();
        }

        protected void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            oID = Convert.ToInt32(txtOrderID.Text);

            logicMgr.DeleteOrder(oID);
        }
    }
}