using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XAF
{
    public partial class DeleteSupplier : System.Web.UI.Page
    {
        String sID;
        LogicManager logicMgr;

        protected void Page_Load(object sender, EventArgs e)
        {
            logicMgr = LogicManager.GetLogicMgrInstance();
        }

        protected void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            sID = txtSupplierID.Text;

            logicMgr.DeactivateSupplier(sID);
        }
    }
}