using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace XAF
{
    public class FakeDAL : IDAL
    {
        private static ArrayList _fakeDAL;
        private ArrayList _searchResult;

        public FakeDAL()
        {
            _fakeDAL = new ArrayList();
            _searchResult = new ArrayList();
        }

        public static ArrayList GetListOfObjects()
        {
            return _fakeDAL;
        }

        #region IDAL Members

        public void CreateSupplier(Supplier supp)
        {
            _fakeDAL.Add(supp);
        }

        public void DeleteSupplier(string supplierSE)
        {
            foreach (Supplier s in _fakeDAL.ToArray())
            {
                if (s.SupplierSE == supplierSE)
                {
                    _fakeDAL.Remove(s);
                }
            }
        }

        public void EditSupplier(Supplier supplier)
        {
            foreach (Supplier s in _fakeDAL)
            {
                if (s.SupplierSE == supplier.SupplierSE)
                {
                    s.SupplierName = supplier.SupplierName;
                }
            }
        }

        public ArrayList SearchSupplier(string supplierSE)
        {
            _searchResult = new ArrayList();
            foreach (Supplier s in _fakeDAL)
            {
                if (s.SupplierSE == supplierSE)
                {
                    _searchResult.Add(s);
                }
            }

            return _searchResult;
        }

        public void DeleteItem(int itemID)
        {
            throw new NotImplementedException();
        }

        public void CreateItem(ArrayList items)
        {
            throw new NotImplementedException();
        }

        public void EditItem(Item item)
        {
            throw new NotImplementedException();
        }

        public ArrayList GetAllItems()
        {
            throw new NotImplementedException();
        }

        public ArrayList SearchItem(int itemID)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public void EditUser(User user)
        {
            throw new NotImplementedException();
        }

        public void SaveUser(User user)
        {
            throw new NotImplementedException();
        }

        public ArrayList SearchUser(string userFirstName, string userLastName)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(int order)
        {
            throw new NotImplementedException();
        }

        public void EditOrder(int orderID, System.Collections.ArrayList orderItems)
        {
            throw new NotImplementedException();
        }

        public void CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}