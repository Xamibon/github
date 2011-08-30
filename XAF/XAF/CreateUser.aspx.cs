﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XAF
{
    public partial class CreateUser : System.Web.UI.Page
    {
        String uFirstName;
        String uLastName;
        LogicManager logicMgr;

        protected void Page_Load(object sender, EventArgs e)
        {
            logicMgr = LogicManager.GetLogicMgrInstance();
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            uFirstName = txtFirstName.Text;
            uLastName = txtLastName.Text;

            logicMgr.CreateUser(uFirstName, uLastName);
        }
    }
}