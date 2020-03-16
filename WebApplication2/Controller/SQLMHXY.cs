using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2.Controller
{
    public class SQLMHXY
    {

        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        //为了方便，设为全局对象的sql语句
        private string sql = null;
        //公用 打开数据库的方法
        public void openDatabase()
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Integrated Security=SSPI;Data Source=(local);initial catalog=MHXY;";
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
        //公用 关闭数据库的方法
        public void closeDatabase()
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Integrated Security=SSPI;Data Source=(local);initial catalog=MHXY;";
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
        //方法根据sql语句输出SqlDataReader对象
        public SqlDataReader load(String sql)
        {           
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();          
            
            return dr;
        }
       
    }
}