using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace XAF
{
    public class DAL
    {
        private static IDAL _dalInstance;

        //private DAL() :this(new SQLDatabaseQueries())
        //{
        //}

        //private DAL(IDAL dalType)
        //{

        //}

        public static IDAL GetDALInstance(bool isFake)
        {
            if (_dalInstance == null && (!isFake))
            {
                _dalInstance = new SQLDatabaseQueries();
            }
            else if (_dalInstance == null && (isFake))
            {
                _dalInstance = new FakeDAL();
            }
            return _dalInstance;
        }
    }
}