using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace XAF
{
    public partial class CreateItem : System.Web.UI.Page
    {
        int iID;
        String iName;
        String iDesc;
        int iStock;
        int iSuppID;
        decimal iPrice;
        ArrayList arrItems = new ArrayList();
        Item item;
        LogicManager logicMgr;

        protected void Page_Load(object sender, EventArgs e)
        {
            logicMgr = LogicManager.GetLogicMgrInstance();
        }

        protected void btnCreateItem_Click(object sender, EventArgs e)
        {
            iID = Convert.ToInt32(txtItemID.Text);
            iName = txtItemName.Text;
            iDesc = txtItemDescription.Text;
            iStock = Convert.ToInt32(txtItemStock.Text);
            iSuppID = Convert.ToInt32(txtItemSupplierID.Text);
            iPrice = Convert.ToDecimal(txtItemPrice);

            logicMgr.CreateItem(iID, iName, iDesc, iStock, iSuppID, iPrice);
        }
    }
}