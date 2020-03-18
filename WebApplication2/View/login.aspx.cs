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
                    Response.Redirect("Test.aspx");
                    Response.End();
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
       

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["LoginName"] = TextBox1.Text;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SQLMHXY sQLMHXY = new SQLMHXY();
            sQLMHXY.openDatabase();
            //配置sql语句
            string sqlStr = "SELECT TOP 1000 [ID],[NAME] ,[PASSWORD]  FROM [MHXY].[dbo].[login]";
            SqlDataAdapter da = sQLMHXY.gridViewData(sqlStr);
            sQLMHXY.closeDatabase();
            DataSet data = new DataSet();
            da.Fill(data, "table");
            this.GridView1.DataSource = data;
            this.GridView1.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SQLMHXY sQLMHXY = new SQLMHXY();
            sQLMHXY.openDatabase();
            //配置sql语句
            string sqlStr = "SELECT TOP 1000 [ID],[NAME] ,[PASSWORD]  FROM [MHXY].[dbo].[login]";
            TextBox3.Text = sQLMHXY.sqlExecuteScalar(sqlStr);
        }
    }
}