using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.View.Main
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            SqlConnection cn = new SqlConnection(@"server=(local);uid=sa;pwd=123;database=MHXY");
            SqlDataAdapter da = new SqlDataAdapter("select * from nav where parentId = 0", cn);
            DataSet ds = new DataSet();
            cn.Open();          //打开数据库连接
            da.Fill(ds);
            rptNav.DataSource = ds.Tables[0].DefaultView;
            rptNav.DataBind();
            cn.Close();
        }

        //绑定一级菜单时绑定二级菜单
        protected void rptNav_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            //判断repeater的数据绑定列
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //当前一级菜单的ID
                string id = ((DataRowView)(e.Item.DataItem)).Row["Id"].ToString();
                //找到下面的repeater控件 
                Repeater rpt = (Repeater)e.Item.FindControl("rptSub");
                if (rpt != null)
                {
                    SqlConnection cn = new SqlConnection(@"server=(local);uid=sa;pwd=123456;database=Test");
                    SqlCommand cmd = new SqlCommand("select * from nav where parentId =@parentId", cn);
                    cmd.Parameters.Add("@parentId", SqlDbType.VarChar, 11).Value = id;
                    cn.Open();
                    rpt.DataSource = cmd.ExecuteReader();
                    rpt.DataBind();
                    cn.Close();

                }

            }
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}