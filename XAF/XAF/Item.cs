using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace XAF
{
    /// <summary>
    /// This class describes an Item in the system
    /// </summary>
    public class Item
    {
        private int _itemID;
        private String _itemName;
        private String _itemDescription;
        private int _itemSupplier;
        private decimal _itemPrice;

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="itemID">The item ID.</param>
        /// <param name="itemName">Name of the item.</param>
        /// <param name="itemStock">The item stock.</param>
        /// <param name="supplierID">The supplier of the item.</param>
        /// <param name="itemPrice">The item price.</param>
        /// <param name="itemDescription">The item description.</param>

        public Item(int itemID, String itemName, String itemDescription, int supplierID, decimal itemPrice)
        {
            ItemID = itemID;
            ItemName = itemName;
            ItemDescription = itemDescription;
            ItemSupplier = supplierID;
            ItemPrice = itemPrice;
        }

        /// <summary>
        /// Gets or sets the item ID.
        /// </summary>
        /// <value>
        /// The item ID.
        /// </value>
        public int ItemID
        {
            set
            {
                _itemID = value;
            }
            get
            {
                return _itemID;
            }
        }

        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        /// <value>
        /// The name of the item.
        /// </value>
        public String ItemName
        {
            set
            {
                _itemName = value;
            }
            get
            {
                return _itemName;
            }
        }

        /// <summary>
        /// Gets or sets the item supplier.
        /// </summary>
        /// <value>
        /// The item supplier.
        /// </value>
        public int ItemSupplier
        {
            set
            {
                _itemSupplier = value;
            }
            get
            {
                return _itemSupplier;
            }
        }

        /// <summary>
        /// Gets or sets the item price.
        /// </summary>
        /// <value>
        /// The item price.
        /// </value>
        public decimal ItemPrice
        {
            set
            {
                _itemPrice = value;
            }
            get
            {
                return _itemPrice;
            }
        }

        /// <summary>
        /// Gets or sets the item description.
        /// </summary>
        /// <value>
        /// The item description.
        /// </value>
        public String ItemDescription
        {
            set
            {
                _itemDescription = value;
            }
            get
            {
                return _itemDescription;
            }
        }
    }
}