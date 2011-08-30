using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XAF
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        int uID;
        LogicManager logicMgr;

        protected void Page_Load(object sender, EventArgs e)
        {
            logicMgr = LogicManager.GetLogicMgrInstance();
        }

        protected void btnDeleteUser_Click(object sender, EventArgs e)
        {
            uID = Convert.ToInt32(txtUserID.Text);

            logicMgr.DeactivateUser(uID);
        }
    }
}