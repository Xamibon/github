using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XAF
{
    public partial class CreateSupplier : System.Web.UI.Page
    {
        String sSE;
        String sName;
        LogicManager logicMgr;

        protected void Page_Load(object sender, EventArgs e)
        {
            logicMgr = LogicManager.GetLogicMgrInstance();
        }

        protected void btnAddSupplier_Click(object sender, EventArgs e)
        {
            sSE = txtSupplierSE.Text;
            sName = txtSupplierName.Text;

            logicMgr.CreateSupplier(sSE, sName);
        }
    }
}