using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace XAF
{
    public class LogicManager
    {
        private Item _logicMgrItem;
        private User _logicMgrUser;
        private Order _logicMgrOrder;
        private Supplier _logicMgrSupplier;
        private IDAL _logicMgrIDAL;
        private ArrayList _logicMgrArrItem;
        private static LogicManager _logicMgrInstance;

        protected LogicManager() : this(false)
        {

        }

        protected LogicManager(bool isFake)
        {
            _logicMgrIDAL = DAL.GetDALInstance(isFake);
        }

        public static LogicManager GetLogicMgrInstance()
        {
            if (_logicMgrInstance == null)
            {
                _logicMgrInstance = new LogicManager();
            }
            return _logicMgrInstance;
        }

        #region SupplierMethods

        /// <summary>
        /// Is parsing the Supplier object to the DAL class.
        /// </summary>
        /// <param name="supplier">Expecting an object of Supplier</param>
        public void CreateSupplier(String supplierSE, String supplierName)
        {
            _logicMgrSupplier = new Supplier(supplierSE, supplierName);
            _logicMgrIDAL.CreateSupplier(_logicMgrSupplier);
        }

        /// <summary>
        /// Is parsing the SupplierSE as a string to the DAL class
        /// </summary>
        /// <param name="supplierSE">The supplier SE.</param>
        public void DeleteSupplier(String supplierSE)
        {
            _logicMgrIDAL.DeleteSupplier(supplierSE);
        }

        /// <summary>
        /// Edits the supplier.
        /// </summary>
        /// <param name="supplier">The supplier.</param>
        public void EditSupplier(String supplierName, String supplierSE)
        {
            _logicMgrSupplier = new Supplier(supplierName, supplierSE);
            _logicMgrIDAL.EditSupplier(_logicMgrSupplier);
        }

        /// <summary>
        /// Searches after an supplier which matches the searchterm.
        /// </summary>
        /// <param name="supplierSE">The supplier SE.</param>
        /// <returns>
        /// Returns an array with objects of suppliers which matches the searchterm
        /// </returns>
        public ArrayList SearchSupplier(String supplierSE)
        {
            ArrayList supplierArr = new ArrayList();

            supplierArr = _logicMgrIDAL.SearchSupplier(supplierSE);

            return supplierArr;
        }
        #endregion

        /// <summary>
        /// Is parsing the object to the DAL class which handles the item for further handling.
        /// </summary>
        /// <param name="item">Expecting an object of Item.</param>
        public void CreateItem(int iID, String iName, String iDesc, int iStock, int iSuppID, decimal iPrice)
        {
            _logicMgrArrItem = new ArrayList();
            for (int i = 0; i < iStock; i++)
            {
                _logicMgrItem = new Item(iID, iName, iDesc, iSuppID, iPrice);
                _logicMgrArrItem.Add(_logicMgrItem);
            }

            _logicMgrIDAL.CreateItem(_logicMgrArrItem);
        }

        /// <summary>
        /// Is parsing the object to the DAL class which handles the item for further handling.
        /// </summary>
        /// <param name="itemID">The item ID.</param>
        public void DeleteItem(int iID)
        {
            _logicMgrIDAL.DeleteItem(iID);
        }

        /// <summary>
        /// Is parsing the object to the DAL class which handles the item for further handling. 
        /// </summary>
        /// <param name="item">The item.</param>
        public void EditItem(Item item)
        {

            //DAL dalObj = DAL.Instance();
            //dalObj.EditItem(item);

        }

        /// <summary>
        /// Is parsing the object to the DAL class which handles the item for further handling. 
        /// <returns>
        /// Returns an array with objects of Items which matches the itemID
        /// </returns>
        /// <param name="itemID">The item ID.</param>
        public ArrayList SearchItem(int itemID)
        {
            ArrayList arrItems = new ArrayList();

            //DAL dalObj = DAL.Instance();

            //arrItems = dalObj.SearchItem(itemID);

            return arrItems;
        }

        /// <summary>
        /// Fetching item objects from DAL. 
        /// <returns>
        /// Returns an array with objects of all the items from the database
        /// </returns>
        public ArrayList GetAllItems()
        {
            ArrayList arrItems = new ArrayList();

            arrItems = _logicMgrIDAL.GetAllItems();

            return arrItems;
        }

        /// <summary>
        /// Sends the object to the DAL class.
        /// </summary>
        /// <param name="order">Expecting an object order object.</param>
        public void CreateOrder(int oID, DateTime oCreated, int uID)
        {
            _logicMgrOrder = new Order(oID,oCreated,uID);
            _logicMgrIDAL.CreateOrder(_logicMgrOrder);
        }

        /// <summary>
        /// Sends an order object to the DAL class for deletion.
        /// </summary>
        /// <param name="user">Expecting an order object.</param>
        public void DeleteOrder(int oID)
        {
            _logicMgrIDAL.DeleteOrder(oID);
        }

        /// <summary>
        /// Sends an order object to the DAL class for updating.
        /// </summary>
        /// <param name="order">Expecting an order object.</param>
        public void EditOrder(Order order)
        {
            //DAL dalObj = DAL.Instance();
            //dalObj.EditOrder(OrderID, OrderItemList);
        }

        /// <summary>
        /// Sends parameters to the DAL class in order to search for orders.
        /// </summary>
        /// <param name="orderID">Expecting an integer to identify orders.</param>
        /// <param name="createdDate">Expecting a datetime type to identify orders.</param>
        /// <param name="createdBy">Expecting an integer to identify users.</param>
        public void SearchOrder(int orderID, DateTime createdDate, int createdBy)
        {
            //DAL dalObj = DAL.Instance();
            //dalObj.SearchOrder(orderID, createdDate, createdBy);
        }

        /// <summary>
        /// Is parsing the user object to the DAL class.
        /// </summary>
        /// <param name="user">Expecting a user object.</param>
        public void CreateUser(String firstName, String lastName)
        {
            _logicMgrUser = new User(firstName, lastName);
            _logicMgrIDAL.SaveUser(_logicMgrUser);
        }


        /// <summary>
        /// Sends a user object to the DAL class for deletion.
        /// </summary>
        /// <param name="user">Expecting a user object.</param>
        public void DeleteUser(User user)
        {
            _logicMgrIDAL.DeleteUser(user);
        }

        /// <summary>
        /// Sends a user object to the DAL class for updating.
        /// </summary>
        /// <param name="user">Expecting a user object.</param>
        public void EditUser(User user)
        {
            _logicMgrIDAL.EditUser(user);
        }

        /// <summary>
        /// Sends parameters to the DAL class in order to search for users.
        /// </summary>
        /// <param name="user">Expecting none or more parameters to identify users.</param>
        public void SearchUser(String userFirstName, String userLastName)
        {
            _logicMgrIDAL.SearchUser(userFirstName, userLastName);
        }
    }
}