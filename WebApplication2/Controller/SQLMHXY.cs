using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2.Controller
{
    /// <summary>
    /// SQL操作类
    /// </summary>
    public class SQLMHXY
    {
        //连接数据库
        string str = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
        static string SQLconnect = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
        //String str1 = "connStr";
        //static string SQLconnect = System.Configuration.ConfigurationManager.AppSettings[""+str1+""].ToString();
        SqlConnection conn = new SqlConnection();
        private SqlCommand cmd = null;
        //为了方便，设为全局对象的sql语句
        private string sql = null;

        /// <summary>
        /// 打开数据库的方法
        /// </summary>
        public void openDatabase()
        {
            try
            {
                conn.ConnectionString = str;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 关闭数据库的方法
        /// </summary>
        public void closeDatabase()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //封装的数据库语句执行的方法  ，ExecuteNonQuery()通常情况下为数据库事务处理的首选，当需要执行插入，删除，修改等操作时，首选ExecuteNonQuery(),ExecuteNonQuery()执行成功返回的是一受影响的行数，对于"Create Table"和"Drop Table"语句，返回值是0，而对于其他类型的语句，返回值是-1，ExecuteNonQuery()操作数据时，可以不使用DataSet直接更改数据库中的数据。

        //ExecuteScalar()方法也可以用来执行SQL语句，但是executescalar()执行SQL语句后返回值与ExecuteNonQuery()并不相同，executescalar()方法的返回值的数据类型是object，如果执行的SQL语句是查询语句，则返回结果是查询后的第一行第一列，如果执行的SQL语句不是一个查询语句，则会返回一个未实例化的对象，必须通过类型装换来显示。

        //一般情况下，ExecuteNonQuery()操作后返回的是一个值，而executescalar()操作后则会返回一个对象，executescalar()经常使用当需要返回单一值时的情况。例如当插入一条数据信息时，需要马上知道刚才插入的值，则可以使用executescalar()方法。


        public void execute(String sql)
        {
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 根据sql语句输出SqlDataReader对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataReader load(String sql)
        {
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        /// <summary>
        /// 根据sql语句输出SqlDataAdapter对象，用于填充gridView.sql为查询语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataAdapter gridViewData(String sql)
        {

            conn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            return da;
        }

        /// <summary>
        /// 执行查询，并返回查询所返回的结果集中第一行的第一列。 忽略其他列或行，sql为查询语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public String sqlExecuteScalar(String sql)
        {
            cmd = new SqlCommand(sql, conn);
            String da = cmd.ExecuteScalar().ToString();
            return da;
        }
    }
}