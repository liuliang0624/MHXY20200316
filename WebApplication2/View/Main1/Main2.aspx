<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main2.aspx.cs" Inherits="WebApplication2.View.Main1.Main2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            font-weight: 700;
        }
    </style>
</head>
<body style="height: 644px; width: 1162px">
    <form id="form1" runat="server">
        <div>
            <div style="height: 79px; text-align: center">
                <br />
                <span class="auto-style1">炮哥梦幻西游租号官网</span></div>
        </div>
        <div style="height: 464px; width: 237px">
            <asp:Button ID="Button1" runat="server" Height="90px" Text="可租号查询" Width="230px" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Height="97px" OnClick="Button2_Click" Text="所有号查询" Width="230px" />
            <asp:Button ID="Button3" runat="server" Height="101px" Text="编号管理" Width="229px" />
            <asp:Button ID="Button4" runat="server" Height="93px" Text="生成订单" Width="229px" />
        </div>
        <div style="position: absolute; left: 280px; top: 114px; height: 466px; width: 857px">
            <asp:Button ID="Button5" runat="server" Height="117px" Text="编号51" Width="222px" OnClick="Button5_Click" />
            <asp:Button ID="Button6" runat="server" Height="113px" Text="编号600" Width="249px" />
            <asp:Button ID="Button7" runat="server" Height="114px" Text="编号32" Width="248px" />
            <br />
            <asp:Button ID="Button8" runat="server" Height="105px" Text="编号70" Visible="False" Width="223px" />
        </div>
    </form>
</body>
</html>
