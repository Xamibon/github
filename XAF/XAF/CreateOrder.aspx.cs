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
        DateTime dateCreated = DateTime.Now;
        int uID = 1;
        Order order;
        ArrayList arrOrderItems;
        ArrayList arrReturnedItems;
        LogicManager logicMgr;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblCreatedDate.Text = dateCreated.ToString("dd/mm/yyyy");
            lblCreatedBy.Text = "Systembruger";
            
            logicMgr = LogicManager.GetLogicMgrInstance();

            // Call the searchitems method from DAL and catch the returned data in a new arraylist
            arrReturnedItems = logicMgr.GetAllItems();

            order = logicMgr.CreateOrder(dateCreated, uID);
            arrOrderItems = order.OrderArrItemList;
        }

        protected void btnAddItemToOrder_Click(object sender, EventArgs e)
        {
            decimal iPrice = 0;
            int iQty;
            int iSuppID = 0;

            // Get textbox values and store them in local variables
            iID = Convert.ToInt32(txtItemID.Text);
            iQty = Convert.ToInt32(txtItemQty.Text);

            // Clear the textboxes
            txtItemID.Text = "";
            txtItemQty.Text = "";

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
                arrOrderItems.Add(item);
            }
        }

        protected void btnSaveOrder_Click(object sender, EventArgs e)
        {
            logicMgr.SaveOrder(order);
        }
    }
}