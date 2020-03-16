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
                String i ="SELECT TOP 1000 [ID],[NAME] ,[PASSWORD]  FROM [MHXY].[dbo].[login]";
                SqlDataReader dr= sQLMHXY.load(i);
                while (dr.Read())
                {
                    TextBox1.Text=dr[0].ToString().Trim();
                    TextBox2.Text=dr[1].ToString().Trim();
                    TextBox3.Text = dr[2].ToString().Trim();
                }
                sQLMHXY.closeDatabase();
                
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());                
            }
      
        }
    }
}