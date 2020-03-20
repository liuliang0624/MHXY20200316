using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.View.Main1
{
    public partial class Main2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button5.Text = "编号51";
            Button6.Text = "编号600";
            Button7.Text = "编号32";
            Button8.Visible = false;
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button5.Text = "编号32";
            Button6.Text = "编号132";
            Button7.Text = "编号232";
            Button8.Visible = true;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://i.qq.com/?s_url=http%3A%2F%2Fuser.qzone.qq.com%2F379790917%2Fphoto%2FV14Xq1gV0bvbgY%2F&rd=1");
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://i.qq.com/?s_url=http%3A%2F%2Fuser.qzone.qq.com%2F379790917%2Fphoto%2FV14Xq1gV0bvbgY%2F&rd=1");
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://i.qq.com/?s_url=http%3A%2F%2Fuser.qzone.qq.com%2F379790917%2Fphoto%2FV14Xq1gV0bvbgY%2F&rd=1");
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://i.qq.com/?s_url=http%3A%2F%2Fuser.qzone.qq.com%2F379790917%2Fphoto%2FV14Xq1gV0bvbgY%2F&rd=1");
        }
    }
}