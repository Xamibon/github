using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace XAF
{
    public interface IDAL
    {
        void CreateSupplier(Supplier supp);

        void DeleteSupplier(String supplierSE);

        void EditSupplier(Supplier supplier);

        ArrayList SearchSupplier(String supplierSE);

        void DeleteItem(int itemID);

        void CreateItem(ArrayList item);
        
        void EditItem(Item item);

        ArrayList GetAllItems();

        ArrayList SearchItem(int itemID);

        void DeleteUser(User user);

        void EditUser(User user);

        void SaveUser(User user);

        ArrayList SearchUser(String userFirstName, String userLastName);

        void DeleteOrder(int order);

        void EditOrder(int orderID, ArrayList orderItems);

        void CreateOrder(Order order);
    }
}
