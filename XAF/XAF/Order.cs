using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace XAF
{
    /// <summary>
    /// This class describes an order in the system
    /// </summary>
    public class Order
    {
        private int _orderID;
        private DateTime _orderCreatedDate;
        private int _orderCreatedBy;
        private ArrayList _orderArrItemList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class
        /// </summary>
        /// <param name="orderID">The order ID.</param>
        /// <param name="createdDate">The date this ordser was created.</param>
        /// <param name="createdBy">Id who created the order.</param>

        public Order(DateTime createdDate, int userID)
        {
            _orderCreatedDate = createdDate;
            _orderCreatedBy = userID;
            _orderArrItemList = new ArrayList();
        }
        
        public Order(int orderID, DateTime createdDate, int userID)
        {
            _orderID = orderID;
            _orderCreatedDate = createdDate;
            _orderCreatedBy = userID;
            _orderArrItemList = new ArrayList();
        }

        /// <summary>
        /// Gets or sets the order ID.
        /// </summary>
        /// <value>
        /// The order ID.
        /// </value>
        public int OrderID
        {
            set
            {
                _orderID = value;
            }
            get
            {
                return _orderID;
            }
        }

        /// <summary>
        /// Gets or sets the order created date.
        /// </summary>
        /// <value>
        /// The order created date.
        /// </value>
        public DateTime OrderCreatedDate
        {
            set
            {
                _orderCreatedDate = value; 
            }
            get
            {
                return _orderCreatedDate;
            }
        }

        /// <summary>
        /// Gets or sets the order created by.
        /// </summary>
        /// <value>
        /// The order created by.
        /// </value>
        public int OrderCreatedBy
        {
            set
            {
                _orderCreatedBy = value;
            }
            get
            {
                return _orderCreatedBy;
            }
        }

        public ArrayList OrderArrItemList
        {
            set
            {
                _orderArrItemList = value;
            }
            get
            {
                return _orderArrItemList;
            }
        }
    }
}