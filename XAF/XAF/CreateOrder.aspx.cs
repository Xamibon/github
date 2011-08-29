using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace XAF
{
    public partial class CreateOrder : System.Web.UI.Page
    {

        int iID;
        String iName;
        String iDesc;
        int iSuppID;
        decimal iPrice;
        int iQty;
        DateTime dateCreated = DateTime.Now;
        ArrayList arrItems = new ArrayList();
        LogicManager logicMgr;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblCreatedDate.Text = dateCreated.ToString("dd/mm/yyyy");
            lblCreatedBy.Text = "Systembruger";
            logicMgr = LogicManager.GetLogicMgrInstance();
        }

        protected void btnAddItemToOrder_Click(object sender, EventArgs e)
        {
            
            // Get textbox values and store them in local variables
            iID = Convert.ToInt32(txtItemID.Text);
            iQty = Convert.ToInt32(txtItemQty.Text);

            // Clear the textboxes
            txtItemID.Text = "";
            txtItemQty.Text = "";

            // Call the searchitems method from DAL and catch the returned data in a new arraylist
            ArrayList arrReturnedItems = logicMgr.GetAllItems();

            // Go thru the returned items to find a match for the item id entered.
            foreach (Item item in arrReturnedItems)
            {
                if (item.ItemID == iID)
                {
                    iName = item.ItemName;
                    iDesc = item.ItemDescription;
                    iSuppID = item.ItemSupplier;
                    iPrice = item.ItemPrice;
                }
            }

            // Create a new object of the selected item and store it in the list
            for (int i = 0; i < iQty; i++) 
            {
                Item item = new XAF.Item(iID, iName, iDesc, iSuppID, iPrice);
                arrItems.Add(item);
            }
        }
    }
}