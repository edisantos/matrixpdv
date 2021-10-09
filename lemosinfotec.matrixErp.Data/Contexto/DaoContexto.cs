using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace lemosinfotec.matrixErp.Data.Contexto
{
    public class DaoContexto
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader Dr;

        public SqlConnection OpenConnection()
        {
            try
            {
                string strConnection = string.Format(@"workstation id=DbLemos.mssql.somee.com;packet size=4096;user id=edylemos_SQLLogin_1;pwd=nsytnrghhk;data source=DbLemos.mssql.somee.com;persist security info=False;initial catalog=DbLemos");
                con = new SqlConnection(strConnection);
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public SqlConnection ClosedConnection()
        {
            try
            {
               
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    con.Dispose();
                }
                return con;
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
