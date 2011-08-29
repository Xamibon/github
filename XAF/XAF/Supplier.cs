using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace XAF
{
    /// <summary>
    /// This class describes the Supplier object
    /// </summary>
    public class Supplier
    {
        private String _supplierName;
        private String _supplierSE;

        #region Properties
        /// <summary>
        /// Gets or sets the name of the supplier.
        /// </summary>
        /// <value>
        /// The name of the supplier.
        /// </value>
        public String SupplierName
        {
            set
            {
                _supplierName = value;
            }
            get
            {
                return _supplierName;
            }
        }

        /// <summary>
        /// Gets or sets the supplier SE.
        /// </summary>
        /// <value>
        /// The supplier SE.
        /// </value>
        public String SupplierSE
        {
            set
            {
                _supplierSE = value;
            }
            get
            {
                return _supplierSE;
            }
        }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Supplier"/> class.
        /// </summary>
        /// <param name="supplierName">Name of the supplier.</param>
        /// <param name="supplierSE">The supplier SE.</param>
        public Supplier(String supplierName, String supplierSE)
        {
            SupplierName = supplierName;
            SupplierSE = supplierSE;
        }
    }
}