using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace XAF
{
    public class SQLDatabaseQueries : IDAL
    {
        private SqlParameter _dalStmt;
        private SqlConnection _dalConn;
        private String _dalDBUserName;
        private String _dalDBPassword;
        private String _dalPortNo;
        private String _dalHostName;
        private String _dalDBName;

        public SQLDatabaseQueries()
        {
            _dalHostName = "Server=(local)";
            _dalDBName = "DataBase=XAF";
            _dalDBUserName = "user=SA";
            _dalDBPassword = "password=VolvoR0x";
            _dalConn = new SqlConnection(_dalHostName + ";" + _dalDBName + ";Integrated Security=SSPI;" + _dalDBUserName + ";" + _dalDBPassword);
        }

        #region IDAL Members

        /// <summary>
        /// This method is opening the given object and parses it as sqlparameters to a StoredProcedure.
        /// </summary>
        /// <param name="supp">The supplier object which needs to be stored.</param>
        public void CreateSupplier(Supplier supp)
        {
            try
            {
                String supplierName = supp.SupplierName;
                String supplierSE = supp.SupplierSE;

                SqlCommand cmd = new SqlCommand("sp_CreateSupplier", _dalConn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@SuplierSE", supplierSE));
                cmd.Parameters.Add(new SqlParameter("@Name", supplierName));

                _dalConn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }

        }

        /// <summary>
        /// This method is deleting an supplier recognized by the given string value
        /// </summary>
        /// <param name="supplierSE">The supplier SE.</param>
        public void DeleteSupplier(String supplierSE)
        {
            bool isExisting = false;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteSupplier", _dalConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SuplierSE", supplierSE));

                _dalConn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    isExisting = true;
                }
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
            if (!isExisting)
            {
                throw new Exception("Det angivne leverandør CVR nr eksisterer ikke");
            }
        }

        /// <summary>
        /// This method is giving an object of Supplier which has new information and parsing the information to a StoredProcedure
        /// </summary>
        /// <param name="supplier">The supplier.</param>
        public void EditSupplier(Supplier supplier)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateSupplier", _dalConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SuplierSE", supplier.SupplierSE));
                cmd.Parameters.Add(new SqlParameter("@Name", supplier.SupplierName));

                _dalConn.Open();

                cmd.ExecuteReader();
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
        }

        /// <summary>
        /// This method is giving a searchterm and is parsing this to a StoredProcedure which will return with results and making objects of the rows and adding them to an arraylist.
        /// </summary>
        /// <param name="supplierSE">The supplier SE.</param>
        /// <returns>
        /// Returns an arraylists of Supplier objects
        /// </returns>
        public ArrayList SearchSupplier(String supplierSE)
        {
            bool isExisting = false;
            ArrayList tmpArr = new ArrayList();
            Supplier tmpSupplier;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_SearchSupplier", _dalConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SuplierSE", supplierSE));

                _dalConn.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        tmpSupplier = new Supplier(rdr.GetString(rdr.GetOrdinal("SuplierSE")), rdr.GetString(rdr.GetOrdinal("Name")));
                        tmpArr.Add(tmpSupplier);
                    }
                    if (tmpArr.Count > 0)
                    {
                        isExisting = true;
                    }
                    rdr.Close();
                }
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
            if (!isExisting)
            {
                throw new Exception("Intet matcher dit søge kriterie");
            }
            return tmpArr;
        }

        /// <summary>
        /// This method is deleting an Item recognized by the given string value
        /// </summary>
        /// <param name="itemID">The item ID.</param>
        public void DeleteItem(int itemID)
        {
            bool existing = false;

            try
           
            {                
               
                int ItemID = itemID;

                SqlCommand cmd = new SqlCommand("sp_DeleteItem", _dalConn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ItemID", ItemID));

                _dalConn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    existing = true;
                } 
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
            if (!existing)
            {
                throw new Exception("Item ID eksistere ikke");
            }
        }

        /// <summary>
        /// Creates the item.
        /// </summary>
        /// <param name="items">The item.</param>
        public void CreateItem(ArrayList items)
        {
            Item item = (Item)items[0];
            int itemStock = items.Count + 1;

            try
            {

                SqlCommand cmd = new SqlCommand("sp_CreateItem", _dalConn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@ItemID", item.ItemID));
                cmd.Parameters.Add(new SqlParameter("@ItemName", item.ItemName));
                cmd.Parameters.Add(new SqlParameter("@ItemStock", itemStock));
                cmd.Parameters.Add(new SqlParameter("@ItemSupplier", item.ItemSupplier));
                cmd.Parameters.Add(new SqlParameter("@ItemPrice", item.ItemPrice));
                cmd.Parameters.Add(new SqlParameter("@ItemDescription", item.ItemDescription));

                _dalConn.Open();

                cmd.ExecuteNonQuery();
                
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
        }


        /// <summary>
        /// Edits the item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void EditItem(Item item)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("sp_EditItem", _dalConn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@itemID", item.ItemID));
                cmd.Parameters.Add(new SqlParameter("@itemName", item.ItemName));
                //cmd.Parameters.Add(new SqlParameter("@itemStock", item.ItemStock));
                cmd.Parameters.Add(new SqlParameter("@itemSupplier", item.ItemSupplier));
                cmd.Parameters.Add(new SqlParameter("@itemPrice", item.ItemPrice));
                cmd.Parameters.Add(new SqlParameter("@itemDescription", item.ItemDescription));

                _dalConn.Open();

                cmd.ExecuteNonQuery();

            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
        }

        /// <summary>
        /// Get all items from the database.
        /// </summary>
        /// <returns></returns>
        /// 
        public ArrayList GetAllItems()
        {
            ArrayList arrItems = new ArrayList();
            try
            {

                int iID;
                String iName;
                String iDesc;
                int iStock;
                int iSuppID;
                decimal iPrice;

                SqlCommand cmd = new SqlCommand("sp_GetAllItems", _dalConn);

                cmd.CommandType = CommandType.StoredProcedure;

                _dalConn.Open();

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        iID = rdr.GetInt32(rdr.GetOrdinal("itemID"));
                        iName = rdr.GetString(rdr.GetOrdinal("itemName"));
                        iDesc = rdr.GetString(rdr.GetOrdinal("itemDescription"));
                        iStock = rdr.GetInt32(rdr.GetOrdinal("itemStock"));
                        iSuppID = rdr.GetInt32(rdr.GetOrdinal("suplierSE"));
                        iPrice = rdr.GetDecimal(rdr.GetOrdinal("itemPrice"));

                        for (int i = 0; i < iStock; i++)
                        {
                            Item item = new Item(iID, iName, iDesc, iSuppID, iPrice);
                            arrItems.Add(item);
                        }
                    }
                    rdr.Close();
                }
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }

            return arrItems;
        }

        /// <summary>
        /// Searches the item.
        /// </summary>
        /// <param name="itemID">The item ID.</param>
        /// <returns></returns>
        public ArrayList SearchItem(int itemID)
        {
            ArrayList itemarr = new ArrayList();
            try
            {
                
                Item item;
                int ItemID = itemID;

                SqlCommand cmd = new SqlCommand("sp_SearchItem", _dalConn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ItemID", ItemID));

                _dalConn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    item = new Item(rdr.GetInt32(rdr.GetOrdinal("itemID")), 
                                       rdr.GetString(rdr.GetOrdinal("itemName")),
                                       rdr.GetString(rdr.GetOrdinal("itemDescription")),
                                       rdr.GetInt32(rdr.GetOrdinal("suplierSE")), 
                                       rdr.GetDecimal(rdr.GetOrdinal("itemPrice")));

                    itemarr.Add(item);
                }

                rdr.Close();
     
                
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }

            return itemarr;
        }


        public void DeleteUser(User user)
        {
            try
            {
                int userID = user.UserID;

                SqlCommand cmd = new SqlCommand("spDeleteUser", _dalConn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@userID", userID));

                _dalConn.Open();

                cmd.ExecuteReader();
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
        }

        public void EditUser(User user)
        {
            try
            {
                int userID = user.UserID;
                string userFirstName = user.FirstName;
                string userLastName = user.LastName;

                SqlCommand cmd = new SqlCommand("spUpdateUser", _dalConn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@userID", userID));
                cmd.Parameters.Add(new SqlParameter("@firstName", userFirstName));
                cmd.Parameters.Add(new SqlParameter("@lastName", userLastName));

                _dalConn.Open();

                cmd.ExecuteReader();
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
        }

        public void SaveUser(User user)
        {
            try
            {
                String firstName = user.FirstName;
                String lastName = user.LastName;
                int userID = user.UserID;

                SqlCommand cmd = new SqlCommand("sp_CreateUser", _dalConn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Firstname", firstName));
                cmd.Parameters.Add(new SqlParameter("@Lastname", lastName));

                _dalConn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
        }

        public ArrayList SearchUser(String userFirstName, String userLastName)
        {
            ArrayList _arUsers = new ArrayList();

            try
            {
                SqlCommand cmd = new SqlCommand("spSearchUser", _dalConn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@firstName", userFirstName));
                cmd.Parameters.Add(new SqlParameter("@lastName", userLastName));

                _dalConn.Open();

                cmd.ExecuteReader();

                return _arUsers;
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
        }

        public void DeleteOrder(int order)
        {
            try
            {                
                SqlCommand cmd = new SqlCommand("spDeleteOrder", _dalConn);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@orderID", order));

                _dalConn.Open();

                cmd.ExecuteReader();
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
        }

        public void EditOrder(int orderID, ArrayList orderItems)
        {
            try
            {
                int index;
                int iID;
                int oID = orderID;

                SqlCommand cmd = new SqlCommand("spDeleteFromItemsOrdered", _dalConn);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@orderID", oID));


                cmd = new SqlCommand("spUpdateOrder", _dalConn);

                cmd.CommandType = CommandType.StoredProcedure;

                    // Start loop
                    for ( index = 0; index <= orderItems.Count; index++ )
                    {
                        Item item = (Item)orderItems[index];
                        iID = item.ItemID;

                        cmd.Parameters.Add(new SqlParameter("@itemID", iID));
                        cmd.Parameters.Add(new SqlParameter("@orderID", oID));

                        _dalConn.Open();

                        cmd.ExecuteReader();
                    }
                    // End loop
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
        }

        public void CreateOrder(Order order)
        {
            try
            {
                int orderID = order.OrderID;
                DateTime orderCreatedDate = order.OrderCreatedDate;
                int orderCreatedBy = order.OrderCreatedBy;

                SqlCommand cmd = new SqlCommand("sp_CreateOrder", _dalConn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@OrderID", orderID));
                cmd.Parameters.Add(new SqlParameter("@Createddate", orderCreatedDate));
                cmd.Parameters.Add(new SqlParameter("@UserID", orderCreatedBy));

                _dalConn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                throw se;
            }
            catch (FormatException fe)
            {
                throw fe;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _dalConn.Close();
            }
        }

        #endregion
    }
}