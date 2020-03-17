using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Controller;



namespace WebApplication2.View
{
    public partial class login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SQLMHXY sQLMHXY = new SQLMHXY();
            if (TextBox2.Text.ToString().Trim() == "" || TextBox1.Text.ToString().Trim() == "")
            {
                Response.Write("<script>javascript:alert('请输入完整的账户名或者密码');history.back();</script>");
                Response.End();
            }
            try
            {
                sQLMHXY.openDatabase();
                String i = "SELECT TOP 1000 [ID],[NAME] ,[PASSWORD]  FROM [MHXY].[dbo].[login]";
                SqlDataReader dr = sQLMHXY.load(i);
                while (dr.Read())
                {
                    TextBox1.Text = dr[0].ToString().Trim();
                    TextBox2.Text = dr[1].ToString().Trim();
                    TextBox3.Text = dr[2].ToString().Trim();
                }
                sQLMHXY.closeDatabase();

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void gridViewBind()
        {
            /*
        * 建立数据库连接
        * 首先在头部引入DATA包
        * using System.Data;
        * using System.Data.SqlClient;
        */
          
            string str = System.Configuration.ConfigurationManager.AppSettings["connStr"].ToString();
            SqlConnection dataBaseCon = new SqlConnection(str);

            //配置sql语句
            string sqlStr = "SELECT TOP 1000 [ID],[NAME] ,[PASSWORD]  FROM [MHXY].[dbo].[login]";
            //实例化SqlDataAdapter sql数据适配器对象
            SqlDataAdapter da = new SqlDataAdapter(sqlStr, dataBaseCon);
            //实例化 DataSet 数据集 这个数据集会绑定在gridview上
            DataSet data = new DataSet();
            //向数据集中fill（填入）数据 da填入data
            da.Fill(data, "table");
            //将填好数据的数据集data 绑定到gridView空间上
            this.GridView1.DataSource = data;
            this.GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            gridViewBind();
        }
    }
}