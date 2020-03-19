using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Controller;

namespace WebApplication2.View.Main
{
    public partial class main : System.Web.UI.Page
    {
        SQLMHXY sQLMHXY = new SQLMHXY();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
        /// <summary>
        /// 点击编号管理；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Menu1_MenuItemClick1(object sender, MenuEventArgs e)
        {

            sQLMHXY.openDatabase();
            //配置sql语句
            string sqlStr = "SELECT TOP 1000 [ID],[NAME] ,[PASSWORD]  FROM [MHXY].[dbo].[login]";  //初始化查询所有编号
            SqlDataAdapter da = sQLMHXY.gridViewData(sqlStr);
            sQLMHXY.closeDatabase();
            DataSet data = new DataSet();
            da.Fill(data, "table");
            this.GridView1.DataSource = data;
            this.GridView1.DataBind();
            Session["TaskTable"] = data;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Set the edit index.
            GridView1.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            BindData();
        }
        private void BindData()
        {
            GridView1.DataSource = Session["TaskTable"];
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            ////Retrieve the table from the session object.
            DataSet dt = (DataSet)Session["TaskTable"];
            string str = System.Configuration.ConfigurationManager.AppSettings["sqlTest"].ToString();
           // dt.Fill(data, "table");
            //this.GridView1.DataSource = data;
            ////Update the values.

            //this.GridView1.DataSource = data;
            ////dt.Rows[row.DataItemIndex]["ID"] = ((TextBox)(row.Cells[1].Controls[0])).Text;
            ////  dt.Rows[row.DataItemIndex]["NAME"] = ((TextBox)(row.Cells[2].Controls[0])).Text;
            //// dt.Rows[row.DataItemIndex]["PASSWORD"] = ((TextBox)(row.Cells[3].Controls[0])).Text;

            ////Reset the edit index.
            //GridView1.EditIndex = -1;


            BindData();
        }


    }
}