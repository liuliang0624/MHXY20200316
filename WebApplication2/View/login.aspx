<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication2.View.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        #Text1 {
            margin-top: 0px;
        }

        .auto-style1 {
            font-size: xx-large;
        }

        .auto-style2 {
            color: #CC66FF;
        }

        .auto-style3 {
            text-align: center;
        }

        #Button1 {
            text-align: center;
            height: 49px;
            width: 79px;
        }

        #Button2 {
            height: 49px;
            width: 79px;
        }
    </style>
</head>
<body style="font-weight: 700">
    <form id="form1" runat="server">
        <div class="auto-style3" style="height: 382px; width: 800px; float: inherit; left: 0px; position: absolute; right: 1186px; top: 0px; background-color: #00FFFF;">
            <span class="auto-style1"><span class="auto-style2">
                <br />
                <br />
                中建七局二公司<br />
                <br />
            </span></span>
            <br />
            账号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            密码：<asp:TextBox ID="TextBox2" runat="server" Style="text-align: left"></asp:TextBox>
            <br />
            <br />

            <asp:Button ID="Button3" runat="server" Text="登录" Height="43px" OnClick="Button3_Click" Style="font-size: medium" Width="61px" />

            &nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" Text="输入session" Height="43px" Style="font-size: medium" Width="61px" OnClick="Button4_Click" />

            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="显示数据格式" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="执行查询第一项" />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="跳转主界面" />
        </div>
        <asp:Panel ID="Panel1" runat="server" Height="373px" Style="margin-left: 803px" Width="345px">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="true" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Height="102px" Style="margin-top: 5px; text-align: center;">
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
