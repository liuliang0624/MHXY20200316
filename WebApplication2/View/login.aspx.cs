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
                    Response.Redirect("test.aspx");
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
        /// <summary>
        /// 查询表格并填充
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button5_Click(object sender, EventArgs e)
        {
            SQLMHXY sQLMHXY = new SQLMHXY();
            sQLMHXY.openDatabase();
            //配置sql语句,查询登录表所有信息
            string sqlStr = System.Configuration.ConfigurationManager.AppSettings["sqlLogin1"].ToString();           
            SqlDataAdapter da = sQLMHXY.gridViewData(sqlStr);
            sQLMHXY.closeDatabase();
            DataSet data = new DataSet();
            da.Fill(data, "table");
            this.GridView1.DataSource = data;
            this.GridView1.DataBind();
        }
        /// <summary>
        /// 查询显示第一项第一列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                SQLMHXY sQLMHXY = new SQLMHXY();
                sQLMHXY.openDatabase();
                String str1 = TextBox3.Text.Trim();                
                string sqlStr = System.Configuration.ConfigurationManager.AppSettings[str1].ToString();
                TextBox3.Text = sQLMHXY.sqlExecuteScalar(sqlStr);
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());                
            }
        }
        /// <summary>
        /// 跳转到主界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main/index.aspx");
        }
    }
}